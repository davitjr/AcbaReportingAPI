using AcbaReportsApi.Application.Settings;
using System.Text.Json.Serialization;

namespace AcbaReportsApi.Application.Models
{
    /// <summary>
    /// Report-ների անունները
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ReportsNames
    {
        CardAccountDetails = 1,
        RenewedCardApplication,
        CardReplacementApplication,
        CardAccountDetailChange,
        CardRenewalApplication,
        AdditionalCardApplication,
        CardClosingApplication,
        CardBlockApplication,
        TransactionChargebackApplication = 10,
        SMSDimum,
        CreditlineClosingApplication,
        LinkedCard,
        BusinessCardApplicationProlongation,
        RenewedOtherTypeCardApplication = 17,
        ThreeDSecureDimum,
        ACBADigitalCardOrderReceiptConfirmation = 20,
        VivaCell_Payment_Report_Pl_Por,
        VivaCell_Payment_Report_CASH,
        Armentel_Payment_Report_Pl_Por,
        Armentel_Payment_Report_CASH,
        Orange_Payment_Report_Pl_Por,
        Orange_Payment_Report_CASH,
        GasProm_Payment_Report_Pl_Por,
        GasProm_Payment_Report_Cash,
        UCOM_Payment_Report_Pl_Por,
        UCOM_Payment_Report_CASH,
        VeoliaJur_Payment_Report_Pl_Por,
        VeoliaJur_Payment_Report_Cash,
        ArmWater_Payment_Report_PL_POR,
        ArmWater_Payment_Report_CASH,
        ElentricityPaymentReportPlPor,
        ElentricityPaymentReportCash,
        WaterCo_Payment_Report_CASH,
        WaterCo_Payment_Report_REESTR,
        Trash_Payment_Report_PL_POR,
        Trash_Payment_Report_CASH,
        RepLeasingCastomerConnection,
        RepLeasingOneMoreClassifiedCustomers,
        LeasingStatementSession,
        LeasingCustomersWithoutEmail,
        LeasingCustomersWithoutEmailForStatement,
        LeasingScheduleNonSubsid,
        LeasingScheduleSubsid,
        LeasingCustomerWithOpenClassificationBasis,
        LeasingClassificationBasisChangedCustomers,
        SSTerminal_Operations_NATK,
        SSTerminal_Operations_ACBA,
        SSTerminal_Operations_Not_Exist_In_ACBA,
        SSTerminal_Operations_To_Resend,
        SSTerminal_Incomplete_Operations_NATK,
        NewTerminalReport,
        CardStatement,
        CardStatement_eng,
        SentSMSMessages,
        PaymentInstructionByPeriodFromAppID,
        PaymentInstructionByPeriodSwiftExtractFromAppID,
        ClosePaymentInstructionByPeriodFromAppID,
        Loan_Repayment_Schedule,
        Payment_Order,
        Convertation_NonCash,
        Memorial_by_Period,
        Loan_Statment,
        Loan_Statment_NEW,
        KYC_Individual_MVC,
        KYC_Legal_MVC,
        Cash_In,
        Cash_Out,
        Convertation_Cash,
        Convertation_Cash_NonCash,
        Convertation_NonCash_Cash,
        Cash_Big_Amount,
        InternationalTransferApplicationForm,
        BankMail,
        Cross_Convertation_Cash,
        Cross_Convertation_Cash_NonCash,
        Cross_Convertation_NonCash_Cash,
        Prix_Rasx_Operations,
        Transfer_Without_Account_Report,
        Account_Statement_Report_For_Cash_Book,
        Pension_Application,
        Cash_In_By_Reestr_Amounts,
        Cash_In_By_Reestr,
        Cash_In_By_Reestr_Note,
        POS_Statement_Report,
        SMS_notification_REPORT_for_cards,
        Current_Account_Journal_Report,
        Closed_Current_Account_Journal_Report,
        Reopeneded_Current_Account_Journal_Report,
        Deposits_Journal_Report,
        Rep_ListOfCustomerDeposits,
        Intra_Transactions_By_Period,
        GivenCardsReport,
        CashTransactionExceeded,
        VisaOverAccRests,
        GetProductPercentsAccumulationDetails,
        NotMaturedLoans,
        ProvisionsReport,
        CardStatementSession,
        O_B_P_Expired,
        O_B_P_NotExecuted,
        O_B_P_Counts,
        Introduced_O_B_P_Counts,
        ClosedDepositsReport,
        DailyBalanceReport,
        SwiftTransferMessage,
        CashDailyFlow,
        CashJournalDailyReport,
        CashTotalQuantityReport,
        NewPaidTransfers,
        BankMailTransfers,
        BondCustomerCard,
        BondCustomerCardLegal,
        Transfers_By_Call_Report,
        ActiveTokensByFilialsReport,
        CashBookReport,
        CashBookReportTotal,
        StoredCreditProductsByCustReport,
        StoredCreditProductReport,
        ReportOfLoansToOutBalance,
        ReportOfLoansReturningToOutBalance,
        SaledEquipmentsReport,
        SalPaymentReport,
        FondAccountsList,
        ArcaCardsTransactions,
        OnlineBankingOrdersReport,
        IBankingUsersCount,
        IBankingContractsCount,
        HBUsersActivity,
        HBApplicationsAndOrdersReport,
        HBDocumentsReport,
        Aparik_Report_Submitted,
        Aparik_Report_Given,
        Aparik_Report_Current,
        EO_Get_Client_Responses_Report,
        NewCreditCommitmentForgiveness,
        Tokenization_Card_Report,
        PlasticCardOrdersReport,
        CardsToBeShippedReport,
        RemoteServicesMonitoringReport,
        CardAccountClosingApplication,
        VisaDirectMasterMoneySend,
        CreditLine_Orders_Report,
        ClosedCreditLine_Orders_Report,
        ProlongCreditLine_Orders_Report,
        Cross_Convertation_NonCash,
        CreditLine_Repayment_Schedule,
        DepositRepaymentsGrafik,
        CurrentAccountStatement,
        CurrentAccountStatementNew,
        DepositAccountStatementNew,
        LoanStatementSession,
        StakRemittancePayoutOrder,
        STAKSendMoneyApplicationForm,
        Rep_Pension_Application,
        Rep_SafekeepingItem,
        Rep_transfer_received_BankMail_all_field,
        Rep_transfer_received_BankMail,
        PaymentOrderWithStateDutiesMark,
        REP_CommitteeSparox,
        REP_CommitteeMortgage,
        REP_CommitteeSparox_ashx,
        Consume_Resume_Scoring,
        MortgageResume,
        Rep_Arca_Points_List,
        CardlessCashoutCancellationOrder,
        CardlessCashoutReport,
        CardTarifReport,
        SalaryProgramReport,
        SPChangeHistoryReport,
        REP_Comittee_Loan_Line,
        REP_Committee_Loan_Line_Ashx,
        REP_CommitteeBussines,
        REP_CommitteeExpressBussines,
        REP_CommitteeStandartAgriLoan,
        REP_CommitteeAgriLoanLine,
        InternationalCardTransactionsReport,
        Consume_Loan_Settlement_Schedule,
        ExperienceAndKnowledgeQuestionnaire,
        Rep_AccountTransactions,
        REP_CommitteeGuarantee,
        REP_CommitteeBussinesExportInportLine,
        REP_CommitteeFactoring,
        REP_CommitteeOverdraft,
        ThirdPartyOrganizationReportInternal,
        BankruptCustomersReport,
        BankruptReport,
        CashTerminalOperationsReport,
        DAHKfreezedAmountsReport,
        RenewCards,
        ReplacedCards,
        NotRenewCards,
        NewPosTerminalApplicationReport,
        NewVPosApplicationReport
    }

    public class ReportName
    {

        public static string GetRequestUri(ReportsNames reportName, AcbaReportingServiceUrlOptions _acbaReportingServiceUrlOptions)
        {
            string requestUri = string.Empty;

            switch (reportName)
            {
                case ReportsNames.CardAccountDetails:
                    requestUri = _acbaReportingServiceUrlOptions.CardAccountDetailsReport;
                    break;
                case ReportsNames.RenewedCardApplication:
                    requestUri = _acbaReportingServiceUrlOptions.RenewedCardApplicationReport;
                    break;
                case ReportsNames.CardReplacementApplication:
                    requestUri = _acbaReportingServiceUrlOptions.CardReplacementApplicationReport;
                    break;
                case ReportsNames.CardAccountDetailChange:
                    requestUri = _acbaReportingServiceUrlOptions.CardAccountDetailChangeReport;
                    break;
                case ReportsNames.CardRenewalApplication:
                    requestUri = _acbaReportingServiceUrlOptions.CardRenewalApplicationReport;
                    break;
                case ReportsNames.AdditionalCardApplication:
                    requestUri = _acbaReportingServiceUrlOptions.AdditionalCardApplicationReport;
                    break;
                case ReportsNames.CardClosingApplication:
                    requestUri = _acbaReportingServiceUrlOptions.CardClosingApplicationReport;
                    break;
                case ReportsNames.CardBlockApplication:
                    requestUri = _acbaReportingServiceUrlOptions.CardBlockApplicationReport;
                    break;
                case ReportsNames.TransactionChargebackApplication:
                    requestUri = _acbaReportingServiceUrlOptions.TransactionChargebackApplicationReport;
                    break;
                case ReportsNames.SMSDimum:
                    requestUri = _acbaReportingServiceUrlOptions.SMSDimumReport;
                    break;
                case ReportsNames.CreditlineClosingApplication:
                    requestUri = _acbaReportingServiceUrlOptions.CreditlineClosingApplicationReport;
                    break;
                case ReportsNames.LinkedCard:
                    requestUri = _acbaReportingServiceUrlOptions.LinkedCardReport;
                    break;
                case ReportsNames.BusinessCardApplicationProlongation:
                    requestUri = _acbaReportingServiceUrlOptions.BusinessCardApplicationProlongationReport;
                    break;
                case ReportsNames.RenewedOtherTypeCardApplication:
                    requestUri = _acbaReportingServiceUrlOptions.RenewedOtherTypeCardApplicationReport;
                    break;
                case ReportsNames.ThreeDSecureDimum:
                    requestUri = _acbaReportingServiceUrlOptions.ThreeDSecureDimumReport;
                    break;
                case ReportsNames.ACBADigitalCardOrderReceiptConfirmation:
                    requestUri = _acbaReportingServiceUrlOptions.ACBADigitalCardOrderReceiptConfirmationReport;
                    break;
                case ReportsNames.VivaCell_Payment_Report_Pl_Por:
                    requestUri = _acbaReportingServiceUrlOptions.VivaCell_Payment_Report_Pl_Por_Report;
                    break;
                case ReportsNames.VivaCell_Payment_Report_CASH:
                    requestUri = _acbaReportingServiceUrlOptions.VivaCell_Payment_Report_CASH_Report;
                    break;
                case ReportsNames.Armentel_Payment_Report_Pl_Por:
                    requestUri = _acbaReportingServiceUrlOptions.Armentel_Payment_Report_Pl_Por_Report;
                    break;
                case ReportsNames.Armentel_Payment_Report_CASH:
                    requestUri = _acbaReportingServiceUrlOptions.Armentel_Payment_Report_CASH_Report;
                    break;
                case ReportsNames.Orange_Payment_Report_Pl_Por:
                    requestUri = _acbaReportingServiceUrlOptions.Orange_Payment_Report_Pl_Por_Report;
                    break;
                case ReportsNames.Orange_Payment_Report_CASH:
                    requestUri = _acbaReportingServiceUrlOptions.Orange_Payment_Report_CASH_Report;
                    break;
                case ReportsNames.GasProm_Payment_Report_Pl_Por:
                    requestUri = _acbaReportingServiceUrlOptions.GasProm_Payment_Report_Pl_Por_Report;
                    break;
                case ReportsNames.GasProm_Payment_Report_Cash:
                    requestUri = _acbaReportingServiceUrlOptions.GasProm_Payment_Report_Cash_Report;
                    break;
                case ReportsNames.UCOM_Payment_Report_Pl_Por:
                    requestUri = _acbaReportingServiceUrlOptions.UCOM_Payment_Report_Pl_Por_Report;
                    break;
                case ReportsNames.UCOM_Payment_Report_CASH:
                    requestUri = _acbaReportingServiceUrlOptions.UCOM_Payment_Report_CASH_Report;
                    break;
                case ReportsNames.VeoliaJur_Payment_Report_Pl_Por:
                    requestUri = _acbaReportingServiceUrlOptions.VeoliaJur_Payment_Report_Pl_Por_Report;
                    break;
                case ReportsNames.VeoliaJur_Payment_Report_Cash:
                    requestUri = _acbaReportingServiceUrlOptions.VeoliaJur_Payment_Report_Cash_Report;
                    break;
                case ReportsNames.ArmWater_Payment_Report_PL_POR:
                    requestUri = _acbaReportingServiceUrlOptions.ArmWater_Payment_Report_PL_POR_Report;
                    break;
                case ReportsNames.ArmWater_Payment_Report_CASH:
                    requestUri = _acbaReportingServiceUrlOptions.ArmWater_Payment_Report_CASH_Report;
                    break;
                case ReportsNames.ElentricityPaymentReportPlPor:
                    requestUri = _acbaReportingServiceUrlOptions.ElentricityPaymentReportPlPorReport;
                    break;
                case ReportsNames.ElentricityPaymentReportCash:
                    requestUri = _acbaReportingServiceUrlOptions.ElentricityPaymentReportCashReport;
                    break;
                case ReportsNames.WaterCo_Payment_Report_CASH:
                    requestUri = _acbaReportingServiceUrlOptions.WaterCo_Payment_Report_CASH_Report;
                    break;
                case ReportsNames.WaterCo_Payment_Report_REESTR:
                    requestUri = _acbaReportingServiceUrlOptions.WaterCo_Payment_Report_REESTR_Report;
                    break;
                case ReportsNames.Trash_Payment_Report_PL_POR:
                    requestUri = _acbaReportingServiceUrlOptions.Trash_Payment_Report_PL_POR_Report;
                    break;
                case ReportsNames.Trash_Payment_Report_CASH:
                    requestUri = _acbaReportingServiceUrlOptions.Trash_Payment_Report_CASH_Report;
                    break;
                case ReportsNames.RepLeasingCastomerConnection:
                    requestUri = _acbaReportingServiceUrlOptions.RepLeasingCastomerConnectionReport;
                    break;
                case ReportsNames.RepLeasingOneMoreClassifiedCustomers:
                    requestUri = _acbaReportingServiceUrlOptions.RepLeasingOneMoreClassifiedCustomersReport;
                    break;
                case ReportsNames.LeasingStatementSession:
                    requestUri = _acbaReportingServiceUrlOptions.LeasingStatementSessionReport;
                    break;
                case ReportsNames.LeasingCustomersWithoutEmail:
                    requestUri = _acbaReportingServiceUrlOptions.LeasingCustomersWithoutEmailReport;
                    break;
                case ReportsNames.LeasingCustomersWithoutEmailForStatement:
                    requestUri = _acbaReportingServiceUrlOptions.LeasingCustomersWithoutEmailForStatementReport;
                    break;
                case ReportsNames.LeasingScheduleNonSubsid:
                    requestUri = _acbaReportingServiceUrlOptions.LeasingScheduleNonSubsidReport;
                    break;
                case ReportsNames.LeasingScheduleSubsid:
                    requestUri = _acbaReportingServiceUrlOptions.LeasingScheduleSubsidReport;
                    break;
                case ReportsNames.LeasingCustomerWithOpenClassificationBasis:
                    requestUri = _acbaReportingServiceUrlOptions.LeasingCustomerWithOpenClassificationBasisReport;
                    break;
                case ReportsNames.LeasingClassificationBasisChangedCustomers:
                    requestUri = _acbaReportingServiceUrlOptions.LeasingClassificationBasisChangedCustomersReport;
                    break;
                case ReportsNames.SSTerminal_Operations_NATK:
                    requestUri = _acbaReportingServiceUrlOptions.SSTerminal_Operations_NATK_Report;
                    break;
                case ReportsNames.SSTerminal_Operations_ACBA:
                    requestUri = _acbaReportingServiceUrlOptions.SSTerminal_Operations_ACBA_Report;
                    break;
                case ReportsNames.SSTerminal_Operations_Not_Exist_In_ACBA:
                    requestUri = _acbaReportingServiceUrlOptions.SSTerminal_Operations_Not_Exist_In_ACBA_Report;
                    break;
                case ReportsNames.SSTerminal_Operations_To_Resend:
                    requestUri = _acbaReportingServiceUrlOptions.SSTerminal_Operations_To_Resend_Report;
                    break;
                case ReportsNames.SSTerminal_Incomplete_Operations_NATK:
                    requestUri = _acbaReportingServiceUrlOptions.SSTerminal_Incomplete_Operations_NATK_Report;
                    break;
                case ReportsNames.NewTerminalReport:
                    requestUri = _acbaReportingServiceUrlOptions.NewTerminalReport;
                    break;
                case ReportsNames.CardStatement:
                    requestUri = _acbaReportingServiceUrlOptions.CardStatementReport;
                    break;
                case ReportsNames.CardStatement_eng:
                    requestUri = _acbaReportingServiceUrlOptions.CardStatement_eng_Report;
                    break;
                case ReportsNames.SentSMSMessages:
                    requestUri = _acbaReportingServiceUrlOptions.SentSMSMessagesReport;
                    break;
                case ReportsNames.PaymentInstructionByPeriodFromAppID:
                    requestUri = _acbaReportingServiceUrlOptions.PaymentInstructionByPeriodFromAppIDReport;
                    break;
                case ReportsNames.PaymentInstructionByPeriodSwiftExtractFromAppID:
                    requestUri = _acbaReportingServiceUrlOptions.PaymentInstructionByPeriodSwiftExtractFromAppIDReport;
                    break;
                case ReportsNames.ClosePaymentInstructionByPeriodFromAppID:
                    requestUri = _acbaReportingServiceUrlOptions.ClosePaymentInstructionByPeriodFromAppIDReport;
                    break;
                case ReportsNames.Loan_Repayment_Schedule:
                    requestUri = _acbaReportingServiceUrlOptions.Loan_Repayment_Schedule_Report;
                    break;
                case ReportsNames.Payment_Order:
                    requestUri = _acbaReportingServiceUrlOptions.Payment_Order_Report;
                    break;
                case ReportsNames.Convertation_NonCash:
                    requestUri = _acbaReportingServiceUrlOptions.Convertation_NonCash_Report;
                    break;
                case ReportsNames.Memorial_by_Period:
                    requestUri = _acbaReportingServiceUrlOptions.Memorial_by_Period_Report;
                    break;
                case ReportsNames.Loan_Statment:
                    requestUri = _acbaReportingServiceUrlOptions.Loan_Statment_Report;
                    break;
                case ReportsNames.Loan_Statment_NEW:
                    requestUri = _acbaReportingServiceUrlOptions.Loan_Statment_NEW_Report;
                    break;
                case ReportsNames.KYC_Individual_MVC:
                    requestUri = _acbaReportingServiceUrlOptions.KYC_Individual_MVC_Report;
                    break;
                case ReportsNames.KYC_Legal_MVC:
                    requestUri = _acbaReportingServiceUrlOptions.KYC_Legal_MVC_Report;
                    break;
                case ReportsNames.Cash_In:
                    requestUri = _acbaReportingServiceUrlOptions.Cash_In_Report;
                    break;
                case ReportsNames.Cash_Out:
                    requestUri = _acbaReportingServiceUrlOptions.Cash_Out_Report;
                    break;
                case ReportsNames.Convertation_Cash:
                    requestUri = _acbaReportingServiceUrlOptions.Convertation_Cash_Report;
                    break;
                case ReportsNames.Convertation_Cash_NonCash:
                    requestUri = _acbaReportingServiceUrlOptions.Convertation_Cash_NonCash_Report;
                    break;
                case ReportsNames.Convertation_NonCash_Cash:
                    requestUri = _acbaReportingServiceUrlOptions.Convertation_NonCash_Cash_Report;
                    break;
                case ReportsNames.Cash_Big_Amount:
                    requestUri = _acbaReportingServiceUrlOptions.Cash_Big_Amount_Report;
                    break;
                case ReportsNames.InternationalTransferApplicationForm:
                    requestUri = _acbaReportingServiceUrlOptions.InternationalTransferApplicationFormReport;
                    break;
                case ReportsNames.BankMail:
                    requestUri = _acbaReportingServiceUrlOptions.BankMailReport;
                    break;
                case ReportsNames.Cross_Convertation_Cash:
                    requestUri = _acbaReportingServiceUrlOptions.Cross_Convertation_Cash_Report;
                    break;
                case ReportsNames.Cross_Convertation_Cash_NonCash:
                    requestUri = _acbaReportingServiceUrlOptions.Cross_Convertation_Cash_NonCash_Report;
                    break;
                case ReportsNames.Cross_Convertation_NonCash_Cash:
                    requestUri = _acbaReportingServiceUrlOptions.Cross_Convertation_NonCash_Cash_Report;
                    break;
                case ReportsNames.Prix_Rasx_Operations:
                    requestUri = _acbaReportingServiceUrlOptions.Prix_Rasx_Operations_Report;
                    break;
                case ReportsNames.Transfer_Without_Account_Report:
                    requestUri = _acbaReportingServiceUrlOptions.Transfer_Without_Account_Report;
                    break;
                case ReportsNames.Account_Statement_Report_For_Cash_Book:
                    requestUri = _acbaReportingServiceUrlOptions.Account_Statement_Report_For_Cash_Book_Report;
                    break;
                case ReportsNames.Pension_Application:
                    requestUri = _acbaReportingServiceUrlOptions.Pension_Application_Report;
                    break;
                case ReportsNames.Cash_In_By_Reestr_Amounts:
                    requestUri = _acbaReportingServiceUrlOptions.Cash_In_By_Reestr_Amounts_Report;
                    break;
                case ReportsNames.Cash_In_By_Reestr:
                    requestUri = _acbaReportingServiceUrlOptions.Cash_In_By_Reestr_Report;
                    break;
                case ReportsNames.Cash_In_By_Reestr_Note:
                    requestUri = _acbaReportingServiceUrlOptions.Cash_In_By_Reestr_Note_Report;
                    break;
                case ReportsNames.POS_Statement_Report:
                    requestUri = _acbaReportingServiceUrlOptions.POS_Statement_Report;
                    break;
                case ReportsNames.SMS_notification_REPORT_for_cards:
                    requestUri = _acbaReportingServiceUrlOptions.SMS_notification_REPORT_for_cards_Report;
                    break;
                case ReportsNames.Current_Account_Journal_Report:
                    requestUri = _acbaReportingServiceUrlOptions.Current_Account_Journal_Report;
                    break;
                case ReportsNames.Closed_Current_Account_Journal_Report:
                    requestUri = _acbaReportingServiceUrlOptions.Closed_Current_Account_Journal_Report;
                    break;
                case ReportsNames.Reopeneded_Current_Account_Journal_Report:
                    requestUri = _acbaReportingServiceUrlOptions.Reopeneded_Current_Account_Journal_Report;
                    break;
                case ReportsNames.Deposits_Journal_Report:
                    requestUri = _acbaReportingServiceUrlOptions.Deposits_Journal_Report;
                    break;
                case ReportsNames.Rep_ListOfCustomerDeposits:
                    requestUri = _acbaReportingServiceUrlOptions.Rep_ListOfCustomerDeposits_Report;
                    break;
                case ReportsNames.Intra_Transactions_By_Period:
                    requestUri = _acbaReportingServiceUrlOptions.Intra_Transactions_By_Period_Report;
                    break;
                case ReportsNames.GivenCardsReport:
                    requestUri = _acbaReportingServiceUrlOptions.GivenCardsReport;
                    break;
                case ReportsNames.CashTransactionExceeded:
                    requestUri = _acbaReportingServiceUrlOptions.CashTransactionExceededReport;
                    break;
                case ReportsNames.VisaOverAccRests:
                    requestUri = _acbaReportingServiceUrlOptions.VisaOverAccRestsReport;
                    break;
                case ReportsNames.GetProductPercentsAccumulationDetails:
                    requestUri = _acbaReportingServiceUrlOptions.GetProductPercentsAccumulationDetailsReport;
                    break;
                case ReportsNames.NotMaturedLoans:
                    requestUri = _acbaReportingServiceUrlOptions.NotMaturedLoansReport;
                    break;
                case ReportsNames.ProvisionsReport:
                    requestUri = _acbaReportingServiceUrlOptions.ProvisionsReport;
                    break;
                case ReportsNames.CardStatementSession:
                    requestUri = _acbaReportingServiceUrlOptions.CardStatementSessionReport;
                    break;
                case ReportsNames.O_B_P_Expired:
                    requestUri = _acbaReportingServiceUrlOptions.O_B_P_Expired_Report;
                    break;
                case ReportsNames.O_B_P_NotExecuted:
                    requestUri = _acbaReportingServiceUrlOptions.O_B_P_NotExecuted_Report;
                    break;
                case ReportsNames.O_B_P_Counts:
                    requestUri = _acbaReportingServiceUrlOptions.O_B_P_Counts_Report;
                    break;
                case ReportsNames.Introduced_O_B_P_Counts:
                    requestUri = _acbaReportingServiceUrlOptions.Introduced_O_B_P_Counts_Report;
                    break;
                case ReportsNames.ClosedDepositsReport:
                    requestUri = _acbaReportingServiceUrlOptions.ClosedDepositsReport;
                    break;
                case ReportsNames.DailyBalanceReport:
                    requestUri = _acbaReportingServiceUrlOptions.DailyBalanceReport;
                    break;
                case ReportsNames.SwiftTransferMessage:
                    requestUri = _acbaReportingServiceUrlOptions.SwiftTransferMessageReport;
                    break;
                case ReportsNames.CashDailyFlow:
                    requestUri = _acbaReportingServiceUrlOptions.CashDailyFlowReport;
                    break;
                case ReportsNames.CashJournalDailyReport:
                    requestUri = _acbaReportingServiceUrlOptions.CashJournalDailyReport;
                    break;
                case ReportsNames.CashTotalQuantityReport:
                    requestUri = _acbaReportingServiceUrlOptions.CashTotalQuantityReport;
                    break;
                case ReportsNames.NewPaidTransfers:
                    requestUri = _acbaReportingServiceUrlOptions.NewPaidTransfersReport;
                    break;
                case ReportsNames.BankMailTransfers:
                    requestUri = _acbaReportingServiceUrlOptions.BankMailTransfersReport;
                    break;
                case ReportsNames.DAHKfreezedAmountsReport:
                    requestUri = _acbaReportingServiceUrlOptions.DAHKfreezedAmountsReport;
                    break;
                case ReportsNames.BondCustomerCard:
                    requestUri = _acbaReportingServiceUrlOptions.BondCustomerCardReport;
                    break;
                case ReportsNames.BondCustomerCardLegal:
                    requestUri = _acbaReportingServiceUrlOptions.BondCustomerCardLegalReport;
                    break;
                case ReportsNames.Transfers_By_Call_Report:
                    requestUri = _acbaReportingServiceUrlOptions.Transfers_By_Call_Report;
                    break;
                case ReportsNames.ActiveTokensByFilialsReport:
                    requestUri = _acbaReportingServiceUrlOptions.ActiveTokensByFilialsReport;
                    break;
                case ReportsNames.CashBookReport:
                    requestUri = _acbaReportingServiceUrlOptions.CashBookReport;
                    break;
                case ReportsNames.CashBookReportTotal:
                    requestUri = _acbaReportingServiceUrlOptions.CashBookReportTotal;
                    break;
                case ReportsNames.StoredCreditProductsByCustReport:
                    requestUri = _acbaReportingServiceUrlOptions.StoredCreditProductsByCustReport;
                    break;
                case ReportsNames.StoredCreditProductReport:
                    requestUri = _acbaReportingServiceUrlOptions.StoredCreditProductReport;
                    break;
                case ReportsNames.ReportOfLoansToOutBalance:
                    requestUri = _acbaReportingServiceUrlOptions.ReportOfLoansToOutBalance;
                    break;
                case ReportsNames.ReportOfLoansReturningToOutBalance:
                    requestUri = _acbaReportingServiceUrlOptions.ReportOfLoansReturningToOutBalance;
                    break;
                case ReportsNames.SaledEquipmentsReport:
                    requestUri = _acbaReportingServiceUrlOptions.SaledEquipmentsReport;
                    break;
                case ReportsNames.SalPaymentReport:
                    requestUri = _acbaReportingServiceUrlOptions.SalPaymentReport;
                    break;
                case ReportsNames.FondAccountsList:
                    requestUri = _acbaReportingServiceUrlOptions.FondAccountsListReport;
                    break;
                case ReportsNames.ArcaCardsTransactions:
                    requestUri = _acbaReportingServiceUrlOptions.ArcaCardsTransactionsReport;
                    break;
                case ReportsNames.OnlineBankingOrdersReport:
                    requestUri = _acbaReportingServiceUrlOptions.OnlineBankingOrdersReport;
                    break;
                case ReportsNames.IBankingUsersCount:
                    requestUri = _acbaReportingServiceUrlOptions.IBankingUsersCountReport;
                    break;
                case ReportsNames.IBankingContractsCount:
                    requestUri = _acbaReportingServiceUrlOptions.IBankingContractsCountReport;
                    break;
                case ReportsNames.HBUsersActivity:
                    requestUri = _acbaReportingServiceUrlOptions.HBUsersActivityReport;
                    break;
                case ReportsNames.HBApplicationsAndOrdersReport:
                    requestUri = _acbaReportingServiceUrlOptions.HBApplicationsAndOrdersReport;
                    break;
                case ReportsNames.HBDocumentsReport:
                    requestUri = _acbaReportingServiceUrlOptions.HBDocumentsReport;
                    break;
                case ReportsNames.Aparik_Report_Submitted:
                    requestUri = _acbaReportingServiceUrlOptions.Aparik_Report_Submitted;
                    break;
                case ReportsNames.Aparik_Report_Given:
                    requestUri = _acbaReportingServiceUrlOptions.Aparik_Report_Given;
                    break;
                case ReportsNames.Aparik_Report_Current:
                    requestUri = _acbaReportingServiceUrlOptions.Aparik_Report_Current;
                    break;
                case ReportsNames.EO_Get_Client_Responses_Report:
                    requestUri = _acbaReportingServiceUrlOptions.EOGetClientResponsesReport;
                    break;
                case ReportsNames.NewCreditCommitmentForgiveness:
                    requestUri = _acbaReportingServiceUrlOptions.NewCreditCommitmentForgivenessReport;
                    break;
                case ReportsNames.Tokenization_Card_Report:
                    requestUri = _acbaReportingServiceUrlOptions.TokenizationCardReport;
                    break;
                case ReportsNames.PlasticCardOrdersReport:
                    requestUri = _acbaReportingServiceUrlOptions.PlasticCardOrdersReport;
                    break;
                case ReportsNames.CardsToBeShippedReport:
                    requestUri = _acbaReportingServiceUrlOptions.CardsToBeShippedReport;
                    break;
                case ReportsNames.RemoteServicesMonitoringReport:
                    requestUri = _acbaReportingServiceUrlOptions.RemoteServicesMonitoringReport;
                    break;
                case ReportsNames.CardAccountClosingApplication:
                    requestUri = _acbaReportingServiceUrlOptions.CardAccountClosingApplicationReport;
                    break;
                case ReportsNames.VisaDirectMasterMoneySend:
                    requestUri = _acbaReportingServiceUrlOptions.VisaDirectMasterMoneySendReport;
                    break;
                case ReportsNames.CreditLine_Orders_Report:
                    requestUri = _acbaReportingServiceUrlOptions.CreditLineOrdersReport;
                    break;
                case ReportsNames.ClosedCreditLine_Orders_Report:
                    requestUri = _acbaReportingServiceUrlOptions.ClosedCreditLineOrdersReport;
                    break;
                case ReportsNames.ProlongCreditLine_Orders_Report:
                    requestUri = _acbaReportingServiceUrlOptions.ProlongCreditLineOrdersReport;
                    break;
                case ReportsNames.Cross_Convertation_NonCash:
                    requestUri = _acbaReportingServiceUrlOptions.Cross_Convertation_NonCash_Report;
                    break;
                case ReportsNames.CreditLine_Repayment_Schedule:
                    requestUri = _acbaReportingServiceUrlOptions.CreditLine_Repayment_Schedule_Report;
                    break;
                case ReportsNames.DepositRepaymentsGrafik:
                    requestUri = _acbaReportingServiceUrlOptions.DepositRepaymentsGrafikReport;
                    break;
                case ReportsNames.CurrentAccountStatement:
                    requestUri = _acbaReportingServiceUrlOptions.CurrentAccountStatementReport;
                    break;
                case ReportsNames.CurrentAccountStatementNew:
                    requestUri = _acbaReportingServiceUrlOptions.CurrentAccountStatementNewReport;
                    break;
                case ReportsNames.DepositAccountStatementNew:
                    requestUri = _acbaReportingServiceUrlOptions.DepositAccountStatementNewReport;
                    break;
                case ReportsNames.LoanStatementSession:
                    requestUri = _acbaReportingServiceUrlOptions.LoanStatementSessionReport;
                    break;
                case ReportsNames.StakRemittancePayoutOrder:
                    requestUri = _acbaReportingServiceUrlOptions.StakRemittancePayoutOrderReport;
                    break;
                case ReportsNames.STAKSendMoneyApplicationForm:
                    requestUri = _acbaReportingServiceUrlOptions.STAKSendMoneyApplicationFormReport;
                    break;
                case ReportsNames.Rep_Pension_Application:
                    requestUri = _acbaReportingServiceUrlOptions.RepPensionApplication;
                    break;
                case ReportsNames.Rep_SafekeepingItem:
                    requestUri = _acbaReportingServiceUrlOptions.RepSafekeepingItem;
                    break;
                case ReportsNames.CardTarifReport:
                    requestUri = _acbaReportingServiceUrlOptions.CardTarifReport;
                    break;
                case ReportsNames.SalaryProgramReport:
                    requestUri = _acbaReportingServiceUrlOptions.SalaryProgramReport;
                    break;
                case ReportsNames.SPChangeHistoryReport:
                    requestUri = _acbaReportingServiceUrlOptions.SPChangeHistoryReport;
                    break;
                case ReportsNames.Rep_transfer_received_BankMail_all_field:
                    requestUri = _acbaReportingServiceUrlOptions.Rep_transfer_received_BankMail_all_field;
                    break;
                case ReportsNames.Rep_transfer_received_BankMail:
                    requestUri = _acbaReportingServiceUrlOptions.Rep_transfer_received_BankMail;
                    break;
                case ReportsNames.PaymentOrderWithStateDutiesMark:
                    requestUri = _acbaReportingServiceUrlOptions.PaymentOrderWithStateDutiesMark;
                    break;
                case ReportsNames.REP_CommitteeSparox:
                    requestUri = _acbaReportingServiceUrlOptions.REP_CommitteeSparox;
                    break;
                case ReportsNames.REP_CommitteeMortgage:
                    requestUri = _acbaReportingServiceUrlOptions.REP_CommitteeMortgage;
                    break;
                case ReportsNames.REP_CommitteeSparox_ashx:
                    requestUri = _acbaReportingServiceUrlOptions.REP_CommitteeSparoxAshx;
                    break;
                case ReportsNames.Consume_Resume_Scoring:
                    requestUri = _acbaReportingServiceUrlOptions.Consume_Resume_Scoring;
                    break;
                case ReportsNames.MortgageResume:
                    requestUri = _acbaReportingServiceUrlOptions.MortgageResume;
                    break;
                case ReportsNames.Rep_Arca_Points_List:
                    requestUri = _acbaReportingServiceUrlOptions.RepArcaPointsList;
                    break;
                case ReportsNames.CardlessCashoutCancellationOrder:
                    requestUri = _acbaReportingServiceUrlOptions.CardlessCashoutCancellationOrder;
                    break;
                case ReportsNames.CardlessCashoutReport:
                    requestUri = _acbaReportingServiceUrlOptions.CardlessCashoutReport;
                    break;
                case ReportsNames.REP_Comittee_Loan_Line:
                    requestUri = _acbaReportingServiceUrlOptions.REP_ComitteeLoanLine;
                    break;
                case ReportsNames.REP_Committee_Loan_Line_Ashx:
                    requestUri = _acbaReportingServiceUrlOptions.REP_CommitteeLoanLineAshx;
                    break;
                case ReportsNames.REP_CommitteeBussines:
                    requestUri = _acbaReportingServiceUrlOptions.REP_CommitteeBussines;
                    break;
                case ReportsNames.REP_CommitteeExpressBussines:
                    requestUri = _acbaReportingServiceUrlOptions.REP_CommitteeExpressBussines;
                    break;
                case ReportsNames.REP_CommitteeStandartAgriLoan:
                    requestUri = _acbaReportingServiceUrlOptions.REP_CommitteeStandartAgriLoan;
                    break;
                case ReportsNames.REP_CommitteeAgriLoanLine:
                    requestUri = _acbaReportingServiceUrlOptions.REP_CommitteeAgriLoanLine;
                    break;
                case ReportsNames.InternationalCardTransactionsReport:
                    requestUri = _acbaReportingServiceUrlOptions.InternationalCardTransactionsReport;
                    break;
                case ReportsNames.Consume_Loan_Settlement_Schedule:
                    requestUri = _acbaReportingServiceUrlOptions.Consume_Loan_Settlement_Schedule;
                    break;
                case ReportsNames.ExperienceAndKnowledgeQuestionnaire:
                    requestUri = _acbaReportingServiceUrlOptions.RepExperienceAndKnowledgeQuestionnaire;
                    break;
                case ReportsNames.REP_CommitteeGuarantee:
                    requestUri = _acbaReportingServiceUrlOptions.REP_CommitteeGuarantee;
                    break;
                case ReportsNames.REP_CommitteeBussinesExportInportLine:
                    requestUri = _acbaReportingServiceUrlOptions.REP_CommitteeBussinesExportInportLine;
                    break;
                case ReportsNames.REP_CommitteeFactoring:
                    requestUri = _acbaReportingServiceUrlOptions.REP_CommitteeFactoring;
                    break;
                case ReportsNames.REP_CommitteeOverdraft:
                    requestUri = _acbaReportingServiceUrlOptions.REP_CommitteeOverdraft;
                    break;
                case ReportsNames.Rep_AccountTransactions:
                    requestUri = _acbaReportingServiceUrlOptions.Rep_AccountTransactions;
                    break;
                case ReportsNames.ThirdPartyOrganizationReportInternal:
                    requestUri = _acbaReportingServiceUrlOptions.ThirdPartyOrganizationReportInternal;
                    break;
                case ReportsNames.BankruptCustomersReport:
                    requestUri = _acbaReportingServiceUrlOptions.BankruptCustomersReport;
                    break;
                case ReportsNames.BankruptReport:
                    requestUri = _acbaReportingServiceUrlOptions.BankruptReport;
                    break;
                case ReportsNames.CashTerminalOperationsReport:
                    requestUri = _acbaReportingServiceUrlOptions.CashTerminalOperationsReport;
                    break;
                case ReportsNames.RenewCards:
                    requestUri = _acbaReportingServiceUrlOptions.RenewCards;
                    break;
                case ReportsNames.ReplacedCards:
                    requestUri = _acbaReportingServiceUrlOptions.ReplacedCards;
                    break;
                case ReportsNames.NotRenewCards:
                    requestUri = _acbaReportingServiceUrlOptions.NotRenewCards;
                    break;
                case ReportsNames.NewPosTerminalApplicationReport:
                    requestUri = _acbaReportingServiceUrlOptions.NewPosTerminalApplicationReport;
                    break;
                case ReportsNames.NewVPosApplicationReport:
                    requestUri = _acbaReportingServiceUrlOptions.NewVPosApplicationReport;
                    break;
            }

            return requestUri;
        }
    }
}
