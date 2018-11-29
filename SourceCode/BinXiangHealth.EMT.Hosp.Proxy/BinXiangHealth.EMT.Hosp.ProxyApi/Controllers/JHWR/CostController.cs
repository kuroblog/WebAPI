using Agebull.Common.Ioc;
using Agebull.ZeroNet.ZeroApi;
using BinXiangHealth.EMT.Hosp.ProxyApi.Models;
using Gboxt.Common.DataModel;
using System.Linq;
using HModels = BinXiangHealth.EMT.Hosp.ProxyApi.Models.HOSP.JHWR;

namespace BinXiangHealth.EMT.Hosp.ProxyApi.Controllers.JHWR
{
    public class CostController : ApiController
    {
        private readonly IProxyService proxyService = IocHelper.Create<IProxyService>();

        [Route("api/v1/cost/list")]
        public ApiArrayResult<CostListResponse> CostList(CostListRequest request) => this.DoApiArrayResult(
            proxyService.DoTrans<HModels.Hosp4002Request, HModels.Hosp4002Response, CostListRequest, CostListResponse[]>(
                request,
                req => new HModels.Hosp4002Request
                {
                    clinicNo = req.id,
                    patientCard = req.cardNo
                },
                res => res.data?.Select(a => new CostListResponse
                {
                    costCode = a.Fee_Code,
                    docDeptName = a.DocDept_Name,
                    docName = a.Doc_Name,
                    drugFlag = a.Drug_Flag,
                    execDeptCode = a.Exec_DeptCode,
                    execDeptName = a.Exec_DeptName,
                    itemCode = a.Item_Code,
                    itemName = a.Item_Name,
                    moDate = a.Mo_Date,
                    payFlag = a.Pay_Flag,
                    qty = a.Qty,
                    recipeKey = a.Recipe_Key,
                    recipeNo = a.Recipe_No,
                    seqNo = a.SeqNo,
                    totCost = a.Tot_Cost,
                    transType = a.Trans_Type,
                    unit = a.UNIT,
                    unitPrice = a.Unit_Price
                })?.ToArray()));

        [Route("api/v1/cost/settle")]
        public ApiResult<CostSettleResponse> CostSettle(CostSettleRequest request)
        {
            return this.DoApiResult(
                proxyService.DoTrans<HModels.Hosp4004Request, HModels.Hosp4004Response, CostSettleRequest, CostSettleResponse>(
                    request,
                    p => new HModels.Hosp4004Request
                    {
                        clinicNo = p.clinicNo,
                        feeSource = p.source,
                        operCode = p.operCode,
                        ownCost = p.ownCost,
                        payCost = p.payCost,
                        pubCost = p.pubCost,
                        realName = p.name,
                        recipe_Key = p.recipeKey,
                        siInfo = p.siInfo,
                        termId = p.termId,
                        totCost = p.totCost,
                        tradeNo = p.tradeNo
                    },
                    p => new CostSettleResponse
                    {
                        windowNo = p.data?.windowNo
                    }));
        }

        [Route("api/v1/cost/pre")]
        public ApiResult<CostPreSettleResponse> CostPreSettle(CostPreSettleRequest request)
        {
            return this.DoApiResult(
                proxyService.DoTrans<HModels.Hosp4003Request, HModels.Hosp4003Response, CostPreSettleRequest, CostPreSettleResponse>(
                    request,
                    p => new HModels.Hosp4003Request
                    {
                        clinicNo = p.clinicNo,
                        operCode = p.operCode,
                        realName = p.name,
                        recipe_Key = p.recipeKey
                    },
                    p => new CostPreSettleResponse
                    {
                        ownCost = p.data?.ownCost,
                        payCost = p.data?.payCost,
                        pubCost = p.data?.pubCost,
                        totCost = p.data?.totCost
                    }));
        }
    }
}
