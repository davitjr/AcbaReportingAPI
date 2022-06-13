﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcbaReportsApi.Application.Settings
{
    public class AcbaReportingServiceUrlOptions
    {
        public string BaseUrl { get; init; }
        public string CardAccountDetailsReport { get; init; }

        public string RenewedCardApplicationReport { get; init; }
        public string CardReplacementApplicationReport { get; init; }
        public string CardAccountDetailChangeReport { get; init; }
        public string CardRenewalApplicationReport { get; init; }
        public string AdditionalCardApplicationReport { get; init; }
        public string CardClosingApplicationReport { get; init; }
        public string CardBlockApplicationReport { get; init; }
        public string TransactionChargebackApplicationReport { get; init; }
        public string SMSDimumReport { get; init; }
        public string CreditlineClosingApplicationReport { get; init; }
        public string LinkedCardReport { get; init; }
        public string BusinessCardApplicationProlongationReport { get; init; }
        public string RenewedOtherTypeCardApplicationReport { get; init; }
        public string ThreeDSecureDimumReport { get; init; }
        public string ACBADigitalCardOrderReceiptConfirmationReport { get; init; }

        public string VivaCell_Payment_Report_Pl_Por_Report { get; init; }
        public string VivaCell_Payment_Report_CASH_Report { get; init; }
        public string Armentel_Payment_Report_Pl_Por_Report { get; init; }
        public string Armentel_Payment_Report_CASH_Report { get; init; }
        public string Orange_Payment_Report_Pl_Por_Report { get; set; }
        public string Orange_Payment_Report_CASH_Report { get; set; }
        public string GasProm_Payment_Report_Pl_Por_Report { get; set; }
        public string GasProm_Payment_Report_Cash_Report { get; set; }
        public string UCOM_Payment_Report_Pl_Por_Report { get; set; }
        public string UCOM_Payment_Report_CASH_Report { get; set; }
        public string VeoliaJur_Payment_Report_Pl_Por_Report { get; set; }
        public string VeoliaJur_Payment_Report_Cash_Report { get; set; }
        public string ArmWater_Payment_Report_PL_POR_Report { get; set; }
        public string ArmWater_Payment_Report_CASH_Report { get; set; }
        public string ElentricityPaymentReportPlPorReport { get; set; }
        public string ElentricityPaymentReportCashReport { get; set; }
        public string WaterCo_Payment_Report_CASH_Report { get; set; }
        public string WaterCo_Payment_Report_REESTR_Report { get; set; }
        public string Trash_Payment_Report_PL_POR_Report { get; set; }
        public string Trash_Payment_Report_CASH_Report { get; set; }
        public string RepLeasingCastomerConnectionReport { get; set; }
        public string RepLeasingOneMoreClassifiedCustomersReport { get; set; }
        public string LeasingStatementSessionReport { get; set; }
        public string LeasingCustomersWithoutEmailReport { get; set; }
        public string LeasingCustomersWithoutEmailForStatementReport { get; set; }
        public string LeasingScheduleNonSubsidReport { get; set; }
        public string LeasingScheduleSubsidReport { get; set; }
        public string LeasingCustomerWithOpenClassificationBasisReport { get; set; }
        public string LeasingClassificationBasisChangedCustomersReport { get; set; }
        public string SSTerminal_Operations_NATK_Report { get; set; }
        public string SSTerminal_Operations_ACBA_Report { get; set; }
        public string SSTerminal_Operations_Not_Exist_In_ACBA_Report { get; set; }
        public string SSTerminal_Operations_To_Resend_Report { get; set; }

        public string SSTerminal_Incomplete_Operations_NATK_Report { get; set; }
        public string NewTerminalReport { get; set; }
        public string CardStatementReport { get; set; }
        public string CardStatement_eng_Report { get; set; }
        public string SentSMSMessagesReport { get; set; }
        public string PaymentInstructionByPeriodFromAppIDReport { get; set; }
        public string PaymentInstructionByPeriodSwiftExtractFromAppIDReport { get; set; }
        public string ClosePaymentInstructionByPeriodFromAppIDReport { get; set; }
        public string Loan_Repayment_Schedule_Report { get; set; }
        public string Payment_Order_Report { get; set; }
        public string Convertation_NonCash_Report { get; set; }
        public string Memorial_by_Period_Report { get; set; }
        public string Loan_Statment_Report { get; set; }
        public string Loan_Statment_NEW_Report { get; set; }
        public string KYC_Individual_MVC_Report { get; set; }
        public string KYC_Legal_MVC_Report { get; set; }
        public string Cash_In_Report { get; set; }
        public string Cash_Out_Report { get; set; }
        public string Convertation_Cash_Report { get; set; }
        public string Convertation_Cash_NonCash_Report { get; set; }
        public string Convertation_NonCash_Cash_Report { get; set; }
        public string Cash_Big_Amount_Report { get; set; }
        public string InternationalTransferApplicationFormReport { get; set; }
        public string BankMailReport { get; set; }
        public string Cross_Convertation_Cash_Report { get; set; }
        public string Cross_Convertation_Cash_NonCash_Report { get; set; }
        public string Cross_Convertation_NonCash_Cash_Report { get; set; }
        public string Prix_Rasx_Operations_Report { get; set; }
        public string Transfer_Without_Account_Report { get; set; }
        public string Account_Statement_Report_For_Cash_Book_Report { get; set; }
        public string Pension_Application_Report { get; set; }
        public string Cash_In_By_Reestr_Amounts_Report { get; set; }
        public string Cash_In_By_Reestr_Report { get; set; }
        public string Cash_In_By_Reestr_Note_Report { get; set; }
        public string POS_Statement_Report { get; set; }
        public string SMS_notification_REPORT_for_cards_Report { get; set; }
        public string Current_Account_Journal_Report { get; set; }
        public string Closed_Current_Account_Journal_Report { get; set; }
        public string Reopeneded_Current_Account_Journal_Report { get; set; }
        public string Deposits_Journal_Report { get; set; }
        public string Rep_ListOfCustomerDeposits_Report { get; set; }
        public string Intra_Transactions_By_Period_Report { get; set; }
        public string GivenCardsReport { get; set; }
        public string CashTransactionExceededReport { get; set; }
        public string VisaOverAccRestsReport { get; set; }
        public string GetProductPercentsAccumulationDetailsReport { get; set; }
        public string NotMaturedLoansReport { get; set; }
        public string ProvisionsReport { get; set; }
        public string CardStatementSessionReport { get; set; }
        public string O_B_P_Expired_Report { get; set; }
        public string O_B_P_NotExecuted_Report { get; set; }
        public string O_B_P_Counts_Report { get; set; }
        public string Introduced_O_B_P_Counts_Report { get; set; }
        public string ClosedDepositsReport { get; set; }
        public string DailyBalanceReport { get; set; }
        public string SwiftTransferMessageReport { get; set; }
        public string CashDailyFlowReport { get; set; }
        public string CashJournalDailyReport { get; set; }
        public string CashTotalQuantityReport { get; set; }
        public string NewPaidTransfersReport { get; set; }
        public string BankMailTransfersReport { get; set; }
        public string DAHKfreezedAmountsReport { get; set; }
        public string BondCustomerCardReport { get; set; }
        public string BondCustomerCardLegalReport { get; set; }
        public string Transfers_By_Call_Report { get; set; }
        public string ActiveTokensByFilialsReport { get; set; }
        public string CashBookReport { get; set; }
        public string CashBookReportTotal { get; set; }
        public string StoredCreditProductsByCustReport { get; set; }
        public string StoredCreditProductReport { get; set; }
        public string ReportOfLoansToOutBalance { get; set; }
        public string ReportOfLoansReturningToOutBalance { get; set; }
        public string SaledEquipmentsReport { get; set; }
        public string SalPaymentReport { get; set; }
        public string FondAccountsListReport { get; set; }
        public string ArcaCardsTransactionsReport { get; set; }
        public string OnlineBankingOrdersReport { get; set; }
        public string IBankingUsersCountReport { get; set; }
        public string IBankingContractsCountReport { get; set; }
        public string HBUsersActivityReport { get; set; }
        public string HBApplicationsAndOrdersReport { get; set; }
        public string HBDocumentsReport { get; set; }
        public string Aparik_Report_Submitted { get; set; }
        public string Aparik_Report_Given { get; set; }
        public string Aparik_Report_Current { get; set; }
        public string EOGetClientResponsesReport { get; set; }
        public string NewCreditCommitmentForgivenessReport { get; set; }
        public string TokenizationCardReport { get; set; }
        public string PlasticCardOrdersReport { get; set; }
        public string CardsToBeShippedReport { get; set; }
        public string RemoteServicesMonitoringReport { get; set; }
        public string CardAccountClosingApplicationReport { get; set; }
        public string VisaDirectMasterMoneySendReport { get; set; }
        public string CreditLineOrdersReport { get; set; }
        public string ClosedCreditLineOrdersReport { get; set; }
        public string ProlongCreditLineOrdersReport { get; set; }
        public string Cross_Convertation_NonCash_Report { get; set; }
        public string CreditLine_Repayment_Schedule_Report { get; set; }
        public string DepositRepaymentsGrafikReport { get; set; }
        public string CurrentAccountStatementReport { get; set; }
        public string CurrentAccountStatementNewReport { get; set; }
        public string DepositAccountStatementNewReport { get; set; }
        public string LoanStatementSessionReport { get; set; }
        public string StakRemittancePayoutOrderReport { get; set; }
        public string STAKSendMoneyApplicationFormReport { get; set; }
        public string RepPensionApplication { get; set; }
        public string RepSafekeepingItem { get; set; }
        public string CardTarifReport { get; set; }
        public string SalaryProgramReport { get; set; }
        public string SPChangeHistoryReport { get; set; }
        public string Rep_transfer_received_BankMail_all_field { get; set; }
        public string Rep_transfer_received_BankMail { get; set; }
        public string PaymentOrderWithStateDutiesMark { get; set; }
        public string REP_CommitteeSparox { get; set; }
        public string REP_CommitteeMortgage { get; set; }
        public string REP_CommitteeSparoxAshx { get; set; }
        public string Consume_Resume_Scoring { get; set; }
        public string MortgageResume { get; set; }
        public string CardlessCashoutCancellationOrder { get; set; }

        public string RepArcaPointsList { get; set; }

        public string CardlessCashoutReport { get; set; }
        public string REP_ComitteeLoanLine { get; set; }
        public string REP_CommitteeLoanLineAshx { get; set; }
        public string REP_CommitteeBussines { get; set; }
        public string REP_CommitteeExpressBussines { get; set; }
        public string REP_CommitteeStandartAgriLoan { get; set; }
        public string REP_CommitteeAgriLoanLine { get; set; }
        public string InternationalCardTransactionsReport { get; set; }
        public string Consume_Loan_Settlement_Schedule { get; set; }
        public string RepExperienceAndKnowledgeQuestionnaire { get; set; }
        public string Rep_AccountTransactions { get; set; }
        public string REP_CommitteeGuarantee { get; set; }
        public string REP_CommitteeBussinesExportInportLine { get; set; }
        public string REP_CommitteeFactoring { get; set; }
        public string REP_CommitteeOverdraft { get; set; }
        public string ThirdPartyOrganizationReportInternal { get; set; }
        public string BankruptCustomersReport { get; set; }
        public string BankruptReport { get; set; }
        public string CashTerminalOperationsReport { get; set; }
        public string RenewCards {get; set;}
        public string ReplacedCards { get; set;}
        public string NotRenewCards { get; set;}
        public string NewPosTerminalApplicationReport { get; set; }
        public string NewVPosApplicationReport { get; set; }
    }
}
