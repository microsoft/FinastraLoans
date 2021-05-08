using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Domain.Models
{
    public class DisbursementPayment
    {
        public string sl_adjustedamount { get; set; }
        public string sl_adjustedamount_base { get; set; }
        public string sl_amountofpayment { get; set; }
        public string sl_amountofpayment_base { get; set; }
        public string sl_approveorreject { get; set; }
        public string sl_approveorrejectname { get; set; }
        public string sl_batchid { get; set; }
        public string sl_batchidname { get; set; }
        public string sl_borroweraddressline1 { get; set; }
        public string sl_borroweraddressline2 { get; set; }
        public string sl_borrowerbankaccount { get; set; }
        public string sl_borrowerbankcode { get; set; }
        public string sl_borrowerbranchcode { get; set; }
        public string sl_borrowercity { get; set; }
        public string sl_borrowercountry { get; set; }
        public string sl_borrowerfirstname { get; set; }
        public string sl_borrowerlastname { get; set; }
        public string sl_borrowerpostalcode { get; set; }
        public string sl_borrowerprovince { get; set; }
        public string sl_borrowerprovincename { get; set; }
        public string sl_cancellationrequisitionid { get; set; }
        public string sl_certificatenumber { get; set; }
        public string sl_datecancelled { get; set; }
        public string sl_datepostissued { get; set; }
        public string sl_eiaddressline1 { get; set; }
        public string sl_eiaddressline2 { get; set; }
        public string sl_eibankaccount { get; set; }
        public string sl_eibankcode { get; set; }
        public string sl_eiborroweraggregate { get; set; }
        public string sl_eibranchcode { get; set; }
        public string sl_eicity { get; set; }
        public string sl_eicode { get; set; }
        public string sl_eicountry { get; set; }
        public string sl_einame { get; set; }
        public string sl_eipostalcode { get; set; }
        public string sl_eipreference { get; set; }
        public string sl_eipreferencename { get; set; }
        public string sl_eiprovince { get; set; }
        public string sl_eiprovincename { get; set; }
        public string sl_fdapaymentid { get; set; }
        public string sl_finalamount { get; set; }
        public string sl_finalamount_base { get; set; }
        public string sl_fundingtype { get; set; }
        public string sl_fundingtypename { get; set; }
        public string sl_govissuedate { get; set; }
        public string sl_grantamount1 { get; set; }
        public string sl_grantamount10 { get; set; }
        public string sl_grantamount10_base { get; set; }
        public string sl_grantamount1_base { get; set; }
        public string sl_grantamount2 { get; set; }
        public string sl_grantamount2_base { get; set; }
        public string sl_grantamount3 { get; set; }
        public string sl_grantamount3_base { get; set; }
        public string sl_grantamount4 { get; set; }
        public string sl_grantamount4_base { get; set; }
        public string sl_grantamount5 { get; set; }
        public string sl_grantamount5_base { get; set; }
        public string sl_grantamount6 { get; set; }
        public string sl_grantamount6_base { get; set; }
        public string sl_grantamount7 { get; set; }
        public string sl_grantamount7_base { get; set; }
        public string sl_grantamount8 { get; set; }
        public string sl_grantamount8_base { get; set; }
        public string sl_grantamount9 { get; set; }
        public string sl_grantamount9_base { get; set; }
        public string sl_grantaypeamount2 { get; set; }
        public string sl_grantaypeamount2_base { get; set; }
        public string sl_granttype1 { get; set; }
        public string sl_granttype10 { get; set; }
        public string sl_granttype2 { get; set; }
        public string sl_granttype3 { get; set; }
        public string sl_granttype4 { get; set; }
        public string sl_granttype5 { get; set; }
        public string sl_granttype6 { get; set; }
        public string sl_granttype7 { get; set; }
        public string sl_granttype8 { get; set; }
        public string sl_granttype9 { get; set; }
        public string sl_initialstatuscode { get; set; }
        public string sl_iscancelled { get; set; }
        public string sl_iscancelledname { get; set; }
        public string sl_ispostissue { get; set; }
        public string sl_ispostissuename { get; set; }
        public string sl_itemtracenumber { get; set; }
        public string sl_language { get; set; }
        public string sl_languagename { get; set; }
        public string sl_name { get; set; }
        public string sl_originalamount { get; set; }
        public string sl_originalamount_base { get; set; }
        public string sl_originalamount_date { get; set; }
        public string sl_originalamount_state { get; set; }
        public string sl_parentei { get; set; }
        public string sl_parenteiname { get; set; }
        public string sl_paymentattempteffective { get; set; }
        public string sl_paymentattemptnumber { get; set; }
        public string sl_paymentattemptreason { get; set; }
        public string sl_paymentattemptstatuscode { get; set; }
        public string sl_paymentduedate { get; set; }
        public string sl_paymentkey { get; set; }
        public string sl_paymentspskey { get; set; }
        public string sl_paymentspsnumber { get; set; }
        public string sl_paymenttype { get; set; }
        public string sl_paymenttypecode { get; set; }
        public string sl_paymenttypecodename { get; set; }
        public string sl_paymenttypename { get; set; }
        public string sl_portionstatus { get; set; }
        public string sl_portionstatusname { get; set; }
        public string sl_provinceofissue { get; set; }
        public string sl_provinceofissuename { get; set; }
        public string sl_pscd { get; set; }
        public string sl_psed { get; set; }
        public string sl_reissuepaymentspsnumber { get; set; }
        public string sl_rejectreason { get; set; }
        public string sl_rejectreasonname { get; set; }
        public string sl_requisitionnumber { get; set; }
        public string sl_requisitiontypecode { get; set; }
        public string sl_requisitiontypecodename { get; set; }
        public string sl_sin { get; set; }
        public string sl_studentdob { get; set; }
        public string sl_studenteiid { get; set; }
        public string sl_studytype { get; set; }
        public string sl_studytypename { get; set; }
        public string sl_uniquepaymentid { get; set; }
    }


}
