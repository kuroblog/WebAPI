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
        public ApiArrayResult<CostListResponse> CostList(CostListRequest request)
        {
            return this.DoApiArrayResult(
                proxyService.DoTrans<HModels.Hosp4002Request, HModels.Hosp4002Response, CostListRequest, CostListResponse[]>(
                    request,
                    p => new HModels.Hosp4002Request
                    {
                        clinicNo = p.clinicNo,
                        patientCard = p.cardNo
                    },
                    p => p.data?.Select(a => new CostListResponse
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
                        unitPrice = a.Unit_Price,
                        ybItemInfo = a.Yb_Item_Info
                    })?.ToArray()));
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
