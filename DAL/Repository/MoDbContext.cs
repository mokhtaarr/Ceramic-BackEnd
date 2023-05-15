using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DAL.Repository.Models;

namespace DAL.Repository
{
    public partial class MoDbContext : DbContext
    {
        public MoDbContext()
        {
        }

        public MoDbContext(DbContextOptions<MoDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AnAnimalDeath> AnAnimalDeaths { get; set; } = null!;
        public virtual DbSet<AnAnimalDeathDetail> AnAnimalDeathDetails { get; set; } = null!;
        public virtual DbSet<AnAnimalMidicin> AnAnimalMidicins { get; set; } = null!;
        public virtual DbSet<AnAnimalType> AnAnimalTypes { get; set; } = null!;
        public virtual DbSet<AnAnimalWeightRate> AnAnimalWeightRates { get; set; } = null!;
        public virtual DbSet<AnAnimalWeightRateDetail> AnAnimalWeightRateDetails { get; set; } = null!;
        public virtual DbSet<AnMedicin> AnMedicins { get; set; } = null!;
        public virtual DbSet<AnNewBorn> AnNewBorns { get; set; } = null!;
        public virtual DbSet<AnNewBornDetail> AnNewBornDetails { get; set; } = null!;
        public virtual DbSet<AssetAssetAddDoc> AssetAssetAddDocs { get; set; } = null!;
        public virtual DbSet<AssetAssetAddDocDetail> AssetAssetAddDocDetails { get; set; } = null!;
        public virtual DbSet<AssetAssetCard> AssetAssetCards { get; set; } = null!;
        public virtual DbSet<AssetAssetCategory> AssetAssetCategories { get; set; } = null!;
        public virtual DbSet<AssetAssetContact> AssetAssetContacts { get; set; } = null!;
        public virtual DbSet<AssetAssetDeductDoc> AssetAssetDeductDocs { get; set; } = null!;
        public virtual DbSet<AssetAssetDeductDocDetail> AssetAssetDeductDocDetails { get; set; } = null!;
        public virtual DbSet<AssetAssetDeliverDoc> AssetAssetDeliverDocs { get; set; } = null!;
        public virtual DbSet<AssetAssetDeliverDocDetail> AssetAssetDeliverDocDetails { get; set; } = null!;
        public virtual DbSet<AssetAssetFixDoc> AssetAssetFixDocs { get; set; } = null!;
        public virtual DbSet<AssetAssetFixDocDetail> AssetAssetFixDocDetails { get; set; } = null!;
        public virtual DbSet<AssetAssetMoveDoc> AssetAssetMoveDocs { get; set; } = null!;
        public virtual DbSet<AssetAssetMoveDocDetail> AssetAssetMoveDocDetails { get; set; } = null!;
        public virtual DbSet<AssetAssetReceiveDoc> AssetAssetReceiveDocs { get; set; } = null!;
        public virtual DbSet<AssetAssetReceiveDocDetail> AssetAssetReceiveDocDetails { get; set; } = null!;
        public virtual DbSet<AssetAssetSetting> AssetAssetSettings { get; set; } = null!;
        public virtual DbSet<AssetAssetSettingDetail> AssetAssetSettingDetails { get; set; } = null!;
        public virtual DbSet<AssetDepreciationDoc> AssetDepreciationDocs { get; set; } = null!;
        public virtual DbSet<AssetDepreciationDocDetail> AssetDepreciationDocDetails { get; set; } = null!;
        public virtual DbSet<AssetTermination> AssetTerminations { get; set; } = null!;
        public virtual DbSet<BankAccountsView> BankAccountsViews { get; set; } = null!;
        public virtual DbSet<BnkBankNotice> BnkBankNotices { get; set; } = null!;
        public virtual DbSet<BnkBankNoticeDetail> BnkBankNoticeDetails { get; set; } = null!;
        public virtual DbSet<BoxTran> BoxTrans { get; set; } = null!;
        public virtual DbSet<CalAccChrtDailyAssist> CalAccChrtDailyAssists { get; set; } = null!;
        public virtual DbSet<CalAccountChart> CalAccountCharts { get; set; } = null!;
        public virtual DbSet<CalAccountClaasiJoin> CalAccountClaasiJoins { get; set; } = null!;
        public virtual DbSet<CalAccountUser> CalAccountUsers { get; set; } = null!;
        public virtual DbSet<CalAccountingFix> CalAccountingFixes { get; set; } = null!;
        public virtual DbSet<CalAssetAccount> CalAssetAccounts { get; set; } = null!;
        public virtual DbSet<CalBudget> CalBudgets { get; set; } = null!;
        public virtual DbSet<CalBudgetDetail> CalBudgetDetails { get; set; } = null!;
        public virtual DbSet<CalBusinessPartnerAccount> CalBusinessPartnerAccounts { get; set; } = null!;
        public virtual DbSet<CalCostCenter> CalCostCenters { get; set; } = null!;
        public virtual DbSet<CalCostCenterAccount> CalCostCenterAccounts { get; set; } = null!;
        public virtual DbSet<CalCustAccount> CalCustAccounts { get; set; } = null!;
        public virtual DbSet<CalEmpAccount> CalEmpAccounts { get; set; } = null!;
        public virtual DbSet<CalJurnalDetail> CalJurnalDetails { get; set; } = null!;
        public virtual DbSet<CalJurnalEntry> CalJurnalEntries { get; set; } = null!;
        public virtual DbSet<CalPostOrder> CalPostOrders { get; set; } = null!;
        public virtual DbSet<CalQueueOrder> CalQueueOrders { get; set; } = null!;
        public virtual DbSet<CalVendAccount> CalVendAccounts { get; set; } = null!;
        public virtual DbSet<CodAccountCategory> CodAccountCategories { get; set; } = null!;
        public virtual DbSet<CodAccountClassification> CodAccountClassifications { get; set; } = null!;
        public virtual DbSet<CodBuildOccupType> CodBuildOccupTypes { get; set; } = null!;
        public virtual DbSet<CodBuildPermitActiv> CodBuildPermitActivs { get; set; } = null!;
        public virtual DbSet<CodBuildPerspective> CodBuildPerspectives { get; set; } = null!;
        public virtual DbSet<CodBuildingDegree> CodBuildingDegrees { get; set; } = null!;
        public virtual DbSet<CodBuildingExploitation> CodBuildingExploitations { get; set; } = null!;
        public virtual DbSet<CodBuildingFinishingLevel> CodBuildingFinishingLevels { get; set; } = null!;
        public virtual DbSet<CodBuildingInsuranceStatus> CodBuildingInsuranceStatuses { get; set; } = null!;
        public virtual DbSet<CodBuildingStatus> CodBuildingStatuses { get; set; } = null!;
        public virtual DbSet<CodBuildingType> CodBuildingTypes { get; set; } = null!;
        public virtual DbSet<CodCity> CodCities { get; set; } = null!;
        public virtual DbSet<CodColor> CodColors { get; set; } = null!;
        public virtual DbSet<CodContractType> CodContractTypes { get; set; } = null!;
        public virtual DbSet<CodCountry> CodCountries { get; set; } = null!;
        public virtual DbSet<CodDailyAssistance> CodDailyAssistances { get; set; } = null!;
        public virtual DbSet<CodElectInsurStatus> CodElectInsurStatuses { get; set; } = null!;
        public virtual DbSet<CodExplanation> CodExplanations { get; set; } = null!;
        public virtual DbSet<CodFurnitAndEqupmnt> CodFurnitAndEqupmnts { get; set; } = null!;
        public virtual DbSet<CodInstallmentTemp> CodInstallmentTemps { get; set; } = null!;
        public virtual DbSet<CodInstallmentTempsDetail> CodInstallmentTempsDetails { get; set; } = null!;
        public virtual DbSet<CodInsurCovType> CodInsurCovTypes { get; set; } = null!;
        public virtual DbSet<CodInsuranceCase> CodInsuranceCases { get; set; } = null!;
        public virtual DbSet<CodLand> CodLands { get; set; } = null!;
        public virtual DbSet<CodLandPermitActivJoin> CodLandPermitActivJoins { get; set; } = null!;
        public virtual DbSet<CodLandPermtActiv> CodLandPermtActivs { get; set; } = null!;
        public virtual DbSet<CodLandPosJoin> CodLandPosJoins { get; set; } = null!;
        public virtual DbSet<CodLandPosition> CodLandPositions { get; set; } = null!;
        public virtual DbSet<CodLandRetainResJoin> CodLandRetainResJoins { get; set; } = null!;
        public virtual DbSet<CodLandRetainRson> CodLandRetainRsons { get; set; } = null!;
        public virtual DbSet<CodLandStatus> CodLandStatuses { get; set; } = null!;
        public virtual DbSet<CodLandType> CodLandTypes { get; set; } = null!;
        public virtual DbSet<CodMaintenanceType> CodMaintenanceTypes { get; set; } = null!;
        public virtual DbSet<CodNonRenewalReason> CodNonRenewalReasons { get; set; } = null!;
        public virtual DbSet<CodOperatingOrder> CodOperatingOrders { get; set; } = null!;
        public virtual DbSet<CodOwnershipBond> CodOwnershipBonds { get; set; } = null!;
        public virtual DbSet<CodPackingSize> CodPackingSizes { get; set; } = null!;
        public virtual DbSet<CodParking> CodParkings { get; set; } = null!;
        public virtual DbSet<CodPaymentTerm> CodPaymentTerms { get; set; } = null!;
        public virtual DbSet<CodPaymentType> CodPaymentTypes { get; set; } = null!;
        public virtual DbSet<CodPostalCode> CodPostalCodes { get; set; } = null!;
        public virtual DbSet<CodRegion> CodRegions { get; set; } = null!;
        public virtual DbSet<CodRentCase> CodRentCases { get; set; } = null!;
        public virtual DbSet<CodSavingFile> CodSavingFiles { get; set; } = null!;
        public virtual DbSet<CodService> CodServices { get; set; } = null!;
        public virtual DbSet<CodShelf> CodShelves { get; set; } = null!;
        public virtual DbSet<CodSubRegion> CodSubRegions { get; set; } = null!;
        public virtual DbSet<CodTaskType> CodTaskTypes { get; set; } = null!;
        public virtual DbSet<CodTrmsModifiRson> CodTrmsModifiRsons { get; set; } = null!;
        public virtual DbSet<CodUnitDegree> CodUnitDegrees { get; set; } = null!;
        public virtual DbSet<CodUnitExploitation> CodUnitExploitations { get; set; } = null!;
        public virtual DbSet<CodUnitFinishingLevel> CodUnitFinishingLevels { get; set; } = null!;
        public virtual DbSet<CodUnitInsuranceStatus> CodUnitInsuranceStatuses { get; set; } = null!;
        public virtual DbSet<CodUnitOccupancyType> CodUnitOccupancyTypes { get; set; } = null!;
        public virtual DbSet<CodUnitPermittedActivity> CodUnitPermittedActivities { get; set; } = null!;
        public virtual DbSet<CodUnitPerspective> CodUnitPerspectives { get; set; } = null!;
        public virtual DbSet<CodUnitService> CodUnitServices { get; set; } = null!;
        public virtual DbSet<CodUnitStatus> CodUnitStatuses { get; set; } = null!;
        public virtual DbSet<CodUnitType> CodUnitTypes { get; set; } = null!;
        public virtual DbSet<CodUntMntanItmBylndownrTnant> CodUntMntanItmBylndownrTnants { get; set; } = null!;
        public virtual DbSet<CodeSubUnitType> CodeSubUnitTypes { get; set; } = null!;
        public virtual DbSet<ContrInstallMent> ContrInstallMents { get; set; } = null!;
        public virtual DbSet<ContrInstallMentDetail> ContrInstallMentDetails { get; set; } = null!;
        public virtual DbSet<CrmLead> CrmLeads { get; set; } = null!;
        public virtual DbSet<CrmLeadType> CrmLeadTypes { get; set; } = null!;
        public virtual DbSet<CrmLeadsMember> CrmLeadsMembers { get; set; } = null!;
        public virtual DbSet<CrmLeadsMembersDetail> CrmLeadsMembersDetails { get; set; } = null!;
        public virtual DbSet<CrmLeadsMembersJoin> CrmLeadsMembersJoins { get; set; } = null!;
        public virtual DbSet<CrmMarketChannel> CrmMarketChannels { get; set; } = null!;
        public virtual DbSet<CrmSalesPlan> CrmSalesPlans { get; set; } = null!;
        public virtual DbSet<CrmSalesPlanDetail> CrmSalesPlanDetails { get; set; } = null!;
        public virtual DbSet<CrmSurvey> CrmSurveys { get; set; } = null!;
        public virtual DbSet<CrmSurveyMemberJoin> CrmSurveyMemberJoins { get; set; } = null!;
        public virtual DbSet<CrmTeam> CrmTeams { get; set; } = null!;
        public virtual DbSet<CrmTeamMember> CrmTeamMembers { get; set; } = null!;
        public virtual DbSet<CrmVisit> CrmVisits { get; set; } = null!;
        public virtual DbSet<CrmVisitSurvey> CrmVisitSurveys { get; set; } = null!;
        public virtual DbSet<CrmVisitType> CrmVisitTypes { get; set; } = null!;
        public virtual DbSet<DeliverCustSearch> DeliverCustSearches { get; set; } = null!;
        public virtual DbSet<DeliverSearch> DeliverSearches { get; set; } = null!;
        public virtual DbSet<GPrintLog> GPrintLogs { get; set; } = null!;
        public virtual DbSet<GUser> GUsers { get; set; } = null!;
        public virtual DbSet<GUserGroup> GUserGroups { get; set; } = null!;
        public virtual DbSet<GUserModule> GUserModules { get; set; } = null!;
        public virtual DbSet<GUserRole> GUserRoles { get; set; } = null!;
        public virtual DbSet<GUserRolePermission> GUserRolePermissions { get; set; } = null!;
        public virtual DbSet<GUserScreenField> GUserScreenFields { get; set; } = null!;
        public virtual DbSet<HrActivityDetailElement> HrActivityDetailElements { get; set; } = null!;
        public virtual DbSet<HrAttend> HrAttends { get; set; } = null!;
        public virtual DbSet<HrAttendDocDetail> HrAttendDocDetails { get; set; } = null!;
        public virtual DbSet<HrAttendDocFactElement> HrAttendDocFactElements { get; set; } = null!;
        public virtual DbSet<HrAttendElementTran> HrAttendElementTrans { get; set; } = null!;
        public virtual DbSet<HrAttendanceDoc> HrAttendanceDocs { get; set; } = null!;
        public virtual DbSet<HrAttendanceElement> HrAttendanceElements { get; set; } = null!;
        public virtual DbSet<HrAttendrole> HrAttendroles { get; set; } = null!;
        public virtual DbSet<HrDepartment> HrDepartments { get; set; } = null!;
        public virtual DbSet<HrDevicesCon> HrDevicesCons { get; set; } = null!;
        public virtual DbSet<HrEducation> HrEducations { get; set; } = null!;
        public virtual DbSet<HrEmpActivity> HrEmpActivities { get; set; } = null!;
        public virtual DbSet<HrEmpActivityDetail> HrEmpActivityDetails { get; set; } = null!;
        public virtual DbSet<HrEmpDocType> HrEmpDocTypes { get; set; } = null!;
        public virtual DbSet<HrEmpDocument> HrEmpDocuments { get; set; } = null!;
        public virtual DbSet<HrEmpElementPeriodBalance> HrEmpElementPeriodBalances { get; set; } = null!;
        public virtual DbSet<HrEmpGroup> HrEmpGroups { get; set; } = null!;
        public virtual DbSet<HrEmpLoan> HrEmpLoans { get; set; } = null!;
        public virtual DbSet<HrEmpLoanRequest> HrEmpLoanRequests { get; set; } = null!;
        public virtual DbSet<HrEmpMovePromotDetail> HrEmpMovePromotDetails { get; set; } = null!;
        public virtual DbSet<HrEmpMovePromotion> HrEmpMovePromotions { get; set; } = null!;
        public virtual DbSet<HrEmpSalaryDistribution> HrEmpSalaryDistributions { get; set; } = null!;
        public virtual DbSet<HrEmpSalaryType> HrEmpSalaryTypes { get; set; } = null!;
        public virtual DbSet<HrEmpVacation> HrEmpVacations { get; set; } = null!;
        public virtual DbSet<HrEmpVacationsDetail> HrEmpVacationsDetails { get; set; } = null!;
        public virtual DbSet<HrEmployee> HrEmployees { get; set; } = null!;
        public virtual DbSet<HrEmpsSalaryTemp> HrEmpsSalaryTemps { get; set; } = null!;
        public virtual DbSet<HrJob> HrJobs { get; set; } = null!;
        public virtual DbSet<HrKpi> HrKpis { get; set; } = null!;
        public virtual DbSet<HrLeavPermissionRequest> HrLeavPermissionRequests { get; set; } = null!;
        public virtual DbSet<HrLeavePermision> HrLeavePermisions { get; set; } = null!;
        public virtual DbSet<HrMobileSetting> HrMobileSettings { get; set; } = null!;
        public virtual DbSet<HrPeriodTableDetail> HrPeriodTableDetails { get; set; } = null!;
        public virtual DbSet<HrPeriodTablePolicy> HrPeriodTablePolicies { get; set; } = null!;
        public virtual DbSet<HrPeriodTableVacation> HrPeriodTableVacations { get; set; } = null!;
        public virtual DbSet<HrPeriodsTable> HrPeriodsTables { get; set; } = null!;
        public virtual DbSet<HrRewardAndPenalty> HrRewardAndPenalties { get; set; } = null!;
        public virtual DbSet<HrSalaryCalcMethod> HrSalaryCalcMethods { get; set; } = null!;
        public virtual DbSet<HrSalaryIssueDetail> HrSalaryIssueDetails { get; set; } = null!;
        public virtual DbSet<HrSalaryIssueDistribution> HrSalaryIssueDistributions { get; set; } = null!;
        public virtual DbSet<HrSalaryIssueDoc> HrSalaryIssueDocs { get; set; } = null!;
        public virtual DbSet<HrSalaryType> HrSalaryTypes { get; set; } = null!;
        public virtual DbSet<HrSegment> HrSegments { get; set; } = null!;
        public virtual DbSet<HrShift> HrShifts { get; set; } = null!;
        public virtual DbSet<HrTermination> HrTerminations { get; set; } = null!;
        public virtual DbSet<HrVacationDoc> HrVacationDocs { get; set; } = null!;
        public virtual DbSet<HrVacationEdit> HrVacationEdits { get; set; } = null!;
        public virtual DbSet<HrVacationRequest> HrVacationRequests { get; set; } = null!;
        public virtual DbSet<LaLand> LaLands { get; set; } = null!;
        public virtual DbSet<LaPropSerial> LaPropSerials { get; set; } = null!;
        public virtual DbSet<MsAdjustMent> MsAdjustMents { get; set; } = null!;
        public virtual DbSet<MsAttachment> MsAttachments { get; set; } = null!;
        public virtual DbSet<MsBankAccount> MsBankAccounts { get; set; } = null!;
        public virtual DbSet<MsBoxBank> MsBoxBanks { get; set; } = null!;
        public virtual DbSet<MsBoxCurrency> MsBoxCurrencies { get; set; } = null!;
        public virtual DbSet<MsBoxTransferDetail> MsBoxTransferDetails { get; set; } = null!;
        public virtual DbSet<MsBoxTransferNote> MsBoxTransferNotes { get; set; } = null!;
        public virtual DbSet<MsBoxUser> MsBoxUsers { get; set; } = null!;
        public virtual DbSet<MsBusinessPartner> MsBusinessPartners { get; set; } = null!;
        public virtual DbSet<MsBusinessPartnerCategory> MsBusinessPartnerCategories { get; set; } = null!;
        public virtual DbSet<MsBusinessPartnerType> MsBusinessPartnerTypes { get; set; } = null!;
        public virtual DbSet<MsCashTransactionDetail> MsCashTransactionDetails { get; set; } = null!;
        public virtual DbSet<MsCheqBook> MsCheqBooks { get; set; } = null!;
        public virtual DbSet<MsChequeTransfer> MsChequeTransfers { get; set; } = null!;
        public virtual DbSet<MsChequeTransferDetail> MsChequeTransferDetails { get; set; } = null!;
        public virtual DbSet<MsChequesOpenning> MsChequesOpennings { get; set; } = null!;
        public virtual DbSet<MsCommission> MsCommissions { get; set; } = null!;
        public virtual DbSet<MsCompany> MsCompanies { get; set; } = null!;
        public virtual DbSet<MsCurrency> MsCurrencies { get; set; } = null!;
        public virtual DbSet<MsCurrencyCategory> MsCurrencyCategories { get; set; } = null!;
        public virtual DbSet<MsCurrencyCategoryJoin> MsCurrencyCategoryJoins { get; set; } = null!;
        public virtual DbSet<MsCurrencyDailyRateChange> MsCurrencyDailyRateChanges { get; set; } = null!;
        public virtual DbSet<MsCurrencyRate> MsCurrencyRates { get; set; } = null!;
        public virtual DbSet<MsCusromerUser> MsCusromerUsers { get; set; } = null!;
        public virtual DbSet<MsCustImg> MsCustImgs { get; set; } = null!;
        public virtual DbSet<MsCustomer> MsCustomers { get; set; } = null!;
        public virtual DbSet<MsCustomerBranch> MsCustomerBranches { get; set; } = null!;
        public virtual DbSet<MsCustomerCategory> MsCustomerCategories { get; set; } = null!;
        public virtual DbSet<MsCustomerContact> MsCustomerContacts { get; set; } = null!;
        public virtual DbSet<MsCustomerFollowUpType> MsCustomerFollowUpTypes { get; set; } = null!;
        public virtual DbSet<MsCustomerType> MsCustomerTypes { get; set; } = null!;
        public virtual DbSet<MsCustomersFollowUp> MsCustomersFollowUps { get; set; } = null!;
        public virtual DbSet<MsDeliverItemCard> MsDeliverItemCards { get; set; } = null!;
        public virtual DbSet<MsDeliverSalesInvoice> MsDeliverSalesInvoices { get; set; } = null!;
        public virtual DbSet<MsDeliverSalesInvoiceExpense> MsDeliverSalesInvoiceExpenses { get; set; } = null!;
        public virtual DbSet<MsDeliverSalesInvoiceMultiAccount> MsDeliverSalesInvoiceMultiAccounts { get; set; } = null!;
        public virtual DbSet<MsDescription> MsDescriptions { get; set; } = null!;
        public virtual DbSet<MsExpense> MsExpenses { get; set; } = null!;
        public virtual DbSet<MsGaCapacity> MsGaCapacities { get; set; } = null!;
        public virtual DbSet<MsGaLetterExport> MsGaLetterExports { get; set; } = null!;
        public virtual DbSet<MsGaLetterExportDetail> MsGaLetterExportDetails { get; set; } = null!;
        public virtual DbSet<MsGaLetterFayum> MsGaLetterFayums { get; set; } = null!;
        public virtual DbSet<MsGaLetterFayumDetail> MsGaLetterFayumDetails { get; set; } = null!;
        public virtual DbSet<MsGaLetterNormal> MsGaLetterNormals { get; set; } = null!;
        public virtual DbSet<MsGaLetterNormalDetail> MsGaLetterNormalDetails { get; set; } = null!;
        public virtual DbSet<MsGaLetterQuery> MsGaLetterQueries { get; set; } = null!;
        public virtual DbSet<MsGaLetterTax> MsGaLetterTaxes { get; set; } = null!;
        public virtual DbSet<MsGaLetterTempTax> MsGaLetterTempTaxes { get; set; } = null!;
        public virtual DbSet<MsGaMachineType> MsGaMachineTypes { get; set; } = null!;
        public virtual DbSet<MsGaMoror> MsGaMorors { get; set; } = null!;
        public virtual DbSet<MsGaMotorSn> MsGaMotorSns { get; set; } = null!;
        public virtual DbSet<MsGaMotorSndetail> MsGaMotorSndetails { get; set; } = null!;
        public virtual DbSet<MsGaPeriodicBook> MsGaPeriodicBooks { get; set; } = null!;
        public virtual DbSet<MsGaPeriodicBookDetail> MsGaPeriodicBookDetails { get; set; } = null!;
        public virtual DbSet<MsGaShipment> MsGaShipments { get; set; } = null!;
        public virtual DbSet<MsGaShipmentDetail> MsGaShipmentDetails { get; set; } = null!;
        public virtual DbSet<MsItemAlternative> MsItemAlternatives { get; set; } = null!;
        public virtual DbSet<MsItemCard> MsItemCards { get; set; } = null!;
        public virtual DbSet<MsItemCardOffer> MsItemCardOffers { get; set; } = null!;
        public virtual DbSet<MsItemCardVendor> MsItemCardVendors { get; set; } = null!;
        public virtual DbSet<MsItemCategory> MsItemCategories { get; set; } = null!;
        public virtual DbSet<MsItemCollection> MsItemCollections { get; set; } = null!;
        public virtual DbSet<MsItemCostHistory> MsItemCostHistories { get; set; } = null!;
        public virtual DbSet<MsItemImage> MsItemImages { get; set; } = null!;
        public virtual DbSet<MsItemPartition> MsItemPartitions { get; set; } = null!;
        public virtual DbSet<MsItemSerial> MsItemSerials { get; set; } = null!;
        public virtual DbSet<MsItemSerialsTransaction> MsItemSerialsTransactions { get; set; } = null!;
        public virtual DbSet<MsItemShortage> MsItemShortages { get; set; } = null!;
        public virtual DbSet<MsItemStartQty> MsItemStartQties { get; set; } = null!;
        public virtual DbSet<MsItemStockAdjustment> MsItemStockAdjustments { get; set; } = null!;
        public virtual DbSet<MsItemStockAdjustmentDetail> MsItemStockAdjustmentDetails { get; set; } = null!;
        public virtual DbSet<MsItemUnit> MsItemUnits { get; set; } = null!;
        public virtual DbSet<MsItemUnitPackingJoin> MsItemUnitPackingJoins { get; set; } = null!;
        public virtual DbSet<MsItemVendor> MsItemVendors { get; set; } = null!;
        public virtual DbSet<MsJewelryPricing> MsJewelryPricings { get; set; } = null!;
        public virtual DbSet<MsKeeperBank> MsKeeperBanks { get; set; } = null!;
        public virtual DbSet<MsKeeperBankDetail> MsKeeperBankDetails { get; set; } = null!;
        public virtual DbSet<MsLetterOfGuarantee> MsLetterOfGuarantees { get; set; } = null!;
        public virtual DbSet<MsLetterOfGuaranteeCategory> MsLetterOfGuaranteeCategories { get; set; } = null!;
        public virtual DbSet<MsLetterOfGuaranteeStatus> MsLetterOfGuaranteeStatuses { get; set; } = null!;
        public virtual DbSet<MsLetterOfGuaranteeTran> MsLetterOfGuaranteeTrans { get; set; } = null!;
        public virtual DbSet<MsLetterOfGuaranteeType> MsLetterOfGuaranteeTypes { get; set; } = null!;
        public virtual DbSet<MsLotNumberConfiguration> MsLotNumberConfigurations { get; set; } = null!;
        public virtual DbSet<MsLotNumberExpiry> MsLotNumberExpiries { get; set; } = null!;
        public virtual DbSet<MsMobSetting> MsMobSettings { get; set; } = null!;
        public virtual DbSet<MsPartition> MsPartitions { get; set; } = null!;
        public virtual DbSet<MsPaymentNote> MsPaymentNotes { get; set; } = null!;
        public virtual DbSet<MsPaymentNoteCurrency> MsPaymentNoteCurrencies { get; set; } = null!;
        public virtual DbSet<MsPaymentNoteItem> MsPaymentNoteItems { get; set; } = null!;
        public virtual DbSet<MsPettyCashDetail> MsPettyCashDetails { get; set; } = null!;
        public virtual DbSet<MsPettyPaymentJoin> MsPettyPaymentJoins { get; set; } = null!;
        public virtual DbSet<MsPettycash> MsPettycashes { get; set; } = null!;
        public virtual DbSet<MsPosItemCategory> MsPosItemCategories { get; set; } = null!;
        public virtual DbSet<MsPosPaymentMethod> MsPosPaymentMethods { get; set; } = null!;
        public virtual DbSet<MsPosShift> MsPosShifts { get; set; } = null!;
        public virtual DbSet<MsPosSpecialItem> MsPosSpecialItems { get; set; } = null!;
        public virtual DbSet<MsPossetting> MsPossettings { get; set; } = null!;
        public virtual DbSet<MsPurchInvVehicleJobOrderJoin> MsPurchInvVehicleJobOrderJoins { get; set; } = null!;
        public virtual DbSet<MsPurchOrderDetail> MsPurchOrderDetails { get; set; } = null!;
        public virtual DbSet<MsPurchOrderReqDetail> MsPurchOrderReqDetails { get; set; } = null!;
        public virtual DbSet<MsPurchasInvoice> MsPurchasInvoices { get; set; } = null!;
        public virtual DbSet<MsPurchasInvoiceCurrency> MsPurchasInvoiceCurrencies { get; set; } = null!;
        public virtual DbSet<MsPurchasInvoiceMultiAccount> MsPurchasInvoiceMultiAccounts { get; set; } = null!;
        public virtual DbSet<MsPurchasOrder> MsPurchasOrders { get; set; } = null!;
        public virtual DbSet<MsPurchasOrderRequest> MsPurchasOrderRequests { get; set; } = null!;
        public virtual DbSet<MsPurchaseInvoiceCostReceived> MsPurchaseInvoiceCostReceiveds { get; set; } = null!;
        public virtual DbSet<MsPurchaseInvoiceExpense> MsPurchaseInvoiceExpenses { get; set; } = null!;
        public virtual DbSet<MsPurchaseInvoiceItemCard> MsPurchaseInvoiceItemCards { get; set; } = null!;
        public virtual DbSet<MsRecPayDocJoin> MsRecPayDocJoins { get; set; } = null!;
        public virtual DbSet<MsReceiptNote> MsReceiptNotes { get; set; } = null!;
        public virtual DbSet<MsReceiptNoteCurrency> MsReceiptNoteCurrencies { get; set; } = null!;
        public virtual DbSet<MsReturnPurchase> MsReturnPurchases { get; set; } = null!;
        public virtual DbSet<MsReturnPurchaseCurrency> MsReturnPurchaseCurrencies { get; set; } = null!;
        public virtual DbSet<MsReturnPurchaseExpense> MsReturnPurchaseExpenses { get; set; } = null!;
        public virtual DbSet<MsReturnPurchaseItem> MsReturnPurchaseItems { get; set; } = null!;
        public virtual DbSet<MsReturnPurchaseMultiAccount> MsReturnPurchaseMultiAccounts { get; set; } = null!;
        public virtual DbSet<MsReturnSale> MsReturnSales { get; set; } = null!;
        public virtual DbSet<MsReturnSalesCurrency> MsReturnSalesCurrencies { get; set; } = null!;
        public virtual DbSet<MsReturnSalesExpense> MsReturnSalesExpenses { get; set; } = null!;
        public virtual DbSet<MsReturnSalesItemCard> MsReturnSalesItemCards { get; set; } = null!;
        public virtual DbSet<MsReturnSalesMultiAccount> MsReturnSalesMultiAccounts { get; set; } = null!;
        public virtual DbSet<MsSalesInvJobOrderJoin> MsSalesInvJobOrderJoins { get; set; } = null!;
        public virtual DbSet<MsSalesInvVehiclJobOrderJoin> MsSalesInvVehiclJobOrderJoins { get; set; } = null!;
        public virtual DbSet<MsSalesInvoice> MsSalesInvoices { get; set; } = null!;
        public virtual DbSet<MsSalesInvoiceCostDeliver> MsSalesInvoiceCostDelivers { get; set; } = null!;
        public virtual DbSet<MsSalesInvoiceCurrency> MsSalesInvoiceCurrencies { get; set; } = null!;
        public virtual DbSet<MsSalesInvoiceExpense> MsSalesInvoiceExpenses { get; set; } = null!;
        public virtual DbSet<MsSalesInvoiceItemCard> MsSalesInvoiceItemCards { get; set; } = null!;
        public virtual DbSet<MsSalesInvoiceItemCardDeleted> MsSalesInvoiceItemCardDeleteds { get; set; } = null!;
        public virtual DbSet<MsSalesInvoiceMultiAccount> MsSalesInvoiceMultiAccounts { get; set; } = null!;
        public virtual DbSet<MsSalesInvoiceQualityDeliveryDoc> MsSalesInvoiceQualityDeliveryDocs { get; set; } = null!;
        public virtual DbSet<MsSalesInvoiceQualityMissedItem> MsSalesInvoiceQualityMissedItems { get; set; } = null!;
        public virtual DbSet<MsSalesItemsOffer> MsSalesItemsOffers { get; set; } = null!;
        public virtual DbSet<MsSalesItemsOffersDetail> MsSalesItemsOffersDetails { get; set; } = null!;
        public virtual DbSet<MsSalesOffer> MsSalesOffers { get; set; } = null!;
        public virtual DbSet<MsSalesOfferItemCard> MsSalesOfferItemCards { get; set; } = null!;
        public virtual DbSet<MsSalesOfferItemRequest> MsSalesOfferItemRequests { get; set; } = null!;
        public virtual DbSet<MsSalesOfferRequest> MsSalesOfferRequests { get; set; } = null!;
        public virtual DbSet<MsSalesOrder> MsSalesOrders { get; set; } = null!;
        public virtual DbSet<MsSalesOrderItemCard> MsSalesOrderItemCards { get; set; } = null!;
        public virtual DbSet<MsSetting> MsSettings { get; set; } = null!;
        public virtual DbSet<MsStockReceiptItemCard> MsStockReceiptItemCards { get; set; } = null!;
        public virtual DbSet<MsStockRecript> MsStockRecripts { get; set; } = null!;
        public virtual DbSet<MsStockRecriptExpense> MsStockRecriptExpenses { get; set; } = null!;
        public virtual DbSet<MsStockRecriptMultiAccount> MsStockRecriptMultiAccounts { get; set; } = null!;
        public virtual DbSet<MsStockTranItemCard> MsStockTranItemCards { get; set; } = null!;
        public virtual DbSet<MsStockTranItemCardReq> MsStockTranItemCardReqs { get; set; } = null!;
        public virtual DbSet<MsStockTransferNote> MsStockTransferNotes { get; set; } = null!;
        public virtual DbSet<MsStockTransferNoteRequest> MsStockTransferNoteRequests { get; set; } = null!;
        public virtual DbSet<MsStore> MsStores { get; set; } = null!;
        public virtual DbSet<MsTaxis> MsTaxes { get; set; } = null!;
        public virtual DbSet<MsTerm> MsTerms { get; set; } = null!;
        public virtual DbSet<MsTermsCostCenter> MsTermsCostCenters { get; set; } = null!;
        public virtual DbSet<MsTermsDetail> MsTermsDetails { get; set; } = null!;
        public virtual DbSet<MsUpdateReplication> MsUpdateReplications { get; set; } = null!;
        public virtual DbSet<MsUserAuthentication> MsUserAuthentications { get; set; } = null!;
        public virtual DbSet<MsVendImg> MsVendImgs { get; set; } = null!;
        public virtual DbSet<MsVendor> MsVendors { get; set; } = null!;
        public virtual DbSet<MsVendorBranch> MsVendorBranches { get; set; } = null!;
        public virtual DbSet<MsVendorCategory> MsVendorCategories { get; set; } = null!;
        public virtual DbSet<MsVendorContact> MsVendorContacts { get; set; } = null!;
        public virtual DbSet<MsVendorType> MsVendorTypes { get; set; } = null!;
        public virtual DbSet<MsVendorUser> MsVendorUsers { get; set; } = null!;
        public virtual DbSet<MsVwAssetExcelExport> MsVwAssetExcelExports { get; set; } = null!;
        public virtual DbSet<MsVwBankTran> MsVwBankTrans { get; set; } = null!;
        public virtual DbSet<MsVwCustomerExcelExport> MsVwCustomerExcelExports { get; set; } = null!;
        public virtual DbSet<MsVwItemBatchStore> MsVwItemBatchStores { get; set; } = null!;
        public virtual DbSet<MsVwItemBatchesQtyInStore> MsVwItemBatchesQtyInStores { get; set; } = null!;
        public virtual DbSet<MsVwItemCardExcelExport> MsVwItemCardExcelExports { get; set; } = null!;
        public virtual DbSet<MsVwItemStore> MsVwItemStores { get; set; } = null!;
        public virtual DbSet<MsVwLetterDocSearch> MsVwLetterDocSearches { get; set; } = null!;
        public virtual DbSet<MsVwLetterSearchresult> MsVwLetterSearchresults { get; set; } = null!;
        public virtual DbSet<MsVwLetterTaxSearch> MsVwLetterTaxSearches { get; set; } = null!;
        public virtual DbSet<MsVwQtyInStore> MsVwQtyInStores { get; set; } = null!;
        public virtual DbSet<MsVwVendorExcelExport> MsVwVendorExcelExports { get; set; } = null!;
        public virtual DbSet<MsWeightCard> MsWeightCards { get; set; } = null!;
        public virtual DbSet<MsWeightcardItem> MsWeightcardItems { get; set; } = null!;
        public virtual DbSet<MsgaCity> MsgaCities { get; set; } = null!;
        public virtual DbSet<Name> Names { get; set; } = null!;
        public virtual DbSet<PayNoteSearch> PayNoteSearches { get; set; } = null!;
        public virtual DbSet<PrintBoxType> PrintBoxTypes { get; set; } = null!;
        public virtual DbSet<PrintBreakType> PrintBreakTypes { get; set; } = null!;
        public virtual DbSet<PrintClosing> PrintClosings { get; set; } = null!;
        public virtual DbSet<PrintConnectionType> PrintConnectionTypes { get; set; } = null!;
        public virtual DbSet<PrintCoverType> PrintCoverTypes { get; set; } = null!;
        public virtual DbSet<PrintCutterTypeId> PrintCutterTypeIds { get; set; } = null!;
        public virtual DbSet<PrintDistribution> PrintDistributions { get; set; } = null!;
        public virtual DbSet<PrintEditType> PrintEditTypes { get; set; } = null!;
        public virtual DbSet<PrintFaceType> PrintFaceTypes { get; set; } = null!;
        public virtual DbSet<PrintGofferType> PrintGofferTypes { get; set; } = null!;
        public virtual DbSet<PrintGradeType> PrintGradeTypes { get; set; } = null!;
        public virtual DbSet<PrintGramType> PrintGramTypes { get; set; } = null!;
        public virtual DbSet<PrintIndustry> PrintIndustries { get; set; } = null!;
        public virtual DbSet<PrintJobOrderCreationType> PrintJobOrderCreationTypes { get; set; } = null!;
        public virtual DbSet<PrintPadingType> PrintPadingTypes { get; set; } = null!;
        public virtual DbSet<PrintPricing> PrintPricings { get; set; } = null!;
        public virtual DbSet<PrintPricingDetail> PrintPricingDetails { get; set; } = null!;
        public virtual DbSet<PrintQoutation> PrintQoutations { get; set; } = null!;
        public virtual DbSet<PrintQoutationDetail> PrintQoutationDetails { get; set; } = null!;
        public virtual DbSet<PrintQoutationDetailsItem> PrintQoutationDetailsItems { get; set; } = null!;
        public virtual DbSet<PrintSector> PrintSectors { get; set; } = null!;
        public virtual DbSet<PrintSizeType> PrintSizeTypes { get; set; } = null!;
        public virtual DbSet<PrintStickyType> PrintStickyTypes { get; set; } = null!;
        public virtual DbSet<PrintStocking> PrintStockings { get; set; } = null!;
        public virtual DbSet<ProdAttributeValue> ProdAttributeValues { get; set; } = null!;
        public virtual DbSet<ProdBasicUnit> ProdBasicUnits { get; set; } = null!;
        public virtual DbSet<ProdBillOfMaterial> ProdBillOfMaterials { get; set; } = null!;
        public virtual DbSet<ProdBillOfMaterialItem> ProdBillOfMaterialItems { get; set; } = null!;
        public virtual DbSet<ProdBillOfMaterialSecondaryItem> ProdBillOfMaterialSecondaryItems { get; set; } = null!;
        public virtual DbSet<ProdEmpEquipDistrib> ProdEmpEquipDistribs { get; set; } = null!;
        public virtual DbSet<ProdEmpEquipDistribDetail> ProdEmpEquipDistribDetails { get; set; } = null!;
        public virtual DbSet<ProdEmpJobOrderDistrib> ProdEmpJobOrderDistribs { get; set; } = null!;
        public virtual DbSet<ProdEmpJobOrderDistribDetail> ProdEmpJobOrderDistribDetails { get; set; } = null!;
        public virtual DbSet<ProdEquipProfile> ProdEquipProfiles { get; set; } = null!;
        public virtual DbSet<ProdEquipment> ProdEquipments { get; set; } = null!;
        public virtual DbSet<ProdItemAttribute> ProdItemAttributes { get; set; } = null!;
        public virtual DbSet<ProdItemAttributesBatche> ProdItemAttributesBatches { get; set; } = null!;
        public virtual DbSet<ProdItemAttributesBatchesDetail> ProdItemAttributesBatchesDetails { get; set; } = null!;
        public virtual DbSet<ProdItemAttributsJoin> ProdItemAttributsJoins { get; set; } = null!;
        public virtual DbSet<ProdItemBatchPartition> ProdItemBatchPartitions { get; set; } = null!;
        public virtual DbSet<ProdItemcardExpense> ProdItemcardExpenses { get; set; } = null!;
        public virtual DbSet<ProdJobOrder> ProdJobOrders { get; set; } = null!;
        public virtual DbSet<ProdJobOrderClosing> ProdJobOrderClosings { get; set; } = null!;
        public virtual DbSet<ProdJobOrderEmpCostDoc> ProdJobOrderEmpCostDocs { get; set; } = null!;
        public virtual DbSet<ProdJobOrderEmpCostDocDetail> ProdJobOrderEmpCostDocDetails { get; set; } = null!;
        public virtual DbSet<ProdJobOrderEquipCostDoc> ProdJobOrderEquipCostDocs { get; set; } = null!;
        public virtual DbSet<ProdJobOrderEquipCostDocDetail> ProdJobOrderEquipCostDocDetails { get; set; } = null!;
        public virtual DbSet<ProdJobOrderEquipment> ProdJobOrderEquipments { get; set; } = null!;
        public virtual DbSet<ProdJobOrderExpense> ProdJobOrderExpenses { get; set; } = null!;
        public virtual DbSet<ProdJobOrderGoStock> ProdJobOrderGoStocks { get; set; } = null!;
        public virtual DbSet<ProdJobOrderJob> ProdJobOrderJobs { get; set; } = null!;
        public virtual DbSet<ProdJobOrderMaterial> ProdJobOrderMaterials { get; set; } = null!;
        public virtual DbSet<ProdJobOrderProduct> ProdJobOrderProducts { get; set; } = null!;
        public virtual DbSet<ProdJobOrderPurchaseInvoice> ProdJobOrderPurchaseInvoices { get; set; } = null!;
        public virtual DbSet<ProdJobOrderScrap> ProdJobOrderScraps { get; set; } = null!;
        public virtual DbSet<ProdJobOrderService> ProdJobOrderServices { get; set; } = null!;
        public virtual DbSet<ProdJobOrderTask> ProdJobOrderTasks { get; set; } = null!;
        public virtual DbSet<ProdJobOrderType> ProdJobOrderTypes { get; set; } = null!;
        public virtual DbSet<ProdJobOrderWorkFlow> ProdJobOrderWorkFlows { get; set; } = null!;
        public virtual DbSet<ProdJoinTaskEquipment> ProdJoinTaskEquipments { get; set; } = null!;
        public virtual DbSet<ProdJoinTaskJob> ProdJoinTaskJobs { get; set; } = null!;
        public virtual DbSet<ProdProductionLine> ProdProductionLines { get; set; } = null!;
        public virtual DbSet<ProdProductionLineDetail> ProdProductionLineDetails { get; set; } = null!;
        public virtual DbSet<ProdProductionOrder> ProdProductionOrders { get; set; } = null!;
        public virtual DbSet<ProdProductionOrderDetail> ProdProductionOrderDetails { get; set; } = null!;
        public virtual DbSet<ProdRecipe> ProdRecipes { get; set; } = null!;
        public virtual DbSet<ProdRecipeDetail> ProdRecipeDetails { get; set; } = null!;
        public virtual DbSet<ProdSetting> ProdSettings { get; set; } = null!;
        public virtual DbSet<ProdTask> ProdTasks { get; set; } = null!;
        public virtual DbSet<ProdWorkOrder> ProdWorkOrders { get; set; } = null!;
        public virtual DbSet<ProdWorkOrderEquipment> ProdWorkOrderEquipments { get; set; } = null!;
        public virtual DbSet<ProdWorkOrderExpense> ProdWorkOrderExpenses { get; set; } = null!;
        public virtual DbSet<ProdWorkOrderItemRecQualityDoc> ProdWorkOrderItemRecQualityDocs { get; set; } = null!;
        public virtual DbSet<ProdWorkOrderMaterial> ProdWorkOrderMaterials { get; set; } = null!;
        public virtual DbSet<ProdWorkOrderProdItem> ProdWorkOrderProdItems { get; set; } = null!;
        public virtual DbSet<ProdWorkOrderScrap> ProdWorkOrderScraps { get; set; } = null!;
        public virtual DbSet<ProdWorkOrderService> ProdWorkOrderServices { get; set; } = null!;
        public virtual DbSet<ProjAccount> ProjAccounts { get; set; } = null!;
        public virtual DbSet<ProjEstimateItem> ProjEstimateItems { get; set; } = null!;
        public virtual DbSet<ProjExpense> ProjExpenses { get; set; } = null!;
        public virtual DbSet<ProjFund> ProjFunds { get; set; } = null!;
        public virtual DbSet<ProjProjDocument> ProjProjDocuments { get; set; } = null!;
        public virtual DbSet<ProjProjExploitJoin> ProjProjExploitJoins { get; set; } = null!;
        public virtual DbSet<ProjProjInsurance> ProjProjInsurances { get; set; } = null!;
        public virtual DbSet<ProjProjInsuranceUnit> ProjProjInsuranceUnits { get; set; } = null!;
        public virtual DbSet<ProjProjItemEmpTaskJoin> ProjProjItemEmpTaskJoins { get; set; } = null!;
        public virtual DbSet<ProjProjOccupTypeJoin> ProjProjOccupTypeJoins { get; set; } = null!;
        public virtual DbSet<ProjProjOwnerJoin> ProjProjOwnerJoins { get; set; } = null!;
        public virtual DbSet<ProjProjParkingJoin> ProjProjParkingJoins { get; set; } = null!;
        public virtual DbSet<ProjProjPermitActivityJoin> ProjProjPermitActivityJoins { get; set; } = null!;
        public virtual DbSet<ProjProjPerspectiveJoin> ProjProjPerspectiveJoins { get; set; } = null!;
        public virtual DbSet<ProjProjPicture> ProjProjPictures { get; set; } = null!;
        public virtual DbSet<ProjProjUnit> ProjProjUnits { get; set; } = null!;
        public virtual DbSet<ProjProjUnitDocument> ProjProjUnitDocuments { get; set; } = null!;
        public virtual DbSet<ProjProjUnitExploitJoin> ProjProjUnitExploitJoins { get; set; } = null!;
        public virtual DbSet<ProjProjUnitInstallTemp> ProjProjUnitInstallTemps { get; set; } = null!;
        public virtual DbSet<ProjProjUnitOccupTypeJoin> ProjProjUnitOccupTypeJoins { get; set; } = null!;
        public virtual DbSet<ProjProjUnitOwnerJoin> ProjProjUnitOwnerJoins { get; set; } = null!;
        public virtual DbSet<ProjProjUnitPermitActivityJoin> ProjProjUnitPermitActivityJoins { get; set; } = null!;
        public virtual DbSet<ProjProjUnitPerspectiveJoin> ProjProjUnitPerspectiveJoins { get; set; } = null!;
        public virtual DbSet<ProjProjUnitPicture> ProjProjUnitPictures { get; set; } = null!;
        public virtual DbSet<ProjProjUnitService> ProjProjUnitServices { get; set; } = null!;
        public virtual DbSet<ProjProjUnitSubUnit> ProjProjUnitSubUnits { get; set; } = null!;
        public virtual DbSet<ProjProject> ProjProjects { get; set; } = null!;
        public virtual DbSet<ProjProjectItem> ProjProjectItems { get; set; } = null!;
        public virtual DbSet<ProjProjectItemEmpJoin> ProjProjectItemEmpJoins { get; set; } = null!;
        public virtual DbSet<ProjProjectItemsJoin> ProjProjectItemsJoins { get; set; } = null!;
        public virtual DbSet<ProjProjectItemsVendor> ProjProjectItemsVendors { get; set; } = null!;
        public virtual DbSet<ProjReInstallment> ProjReInstallments { get; set; } = null!;
        public virtual DbSet<ProjRealItem> ProjRealItems { get; set; } = null!;
        public virtual DbSet<ProjReservInstallment> ProjReservInstallments { get; set; } = null!;
        public virtual DbSet<ProjReserveUnitDocument> ProjReserveUnitDocuments { get; set; } = null!;
        public virtual DbSet<ProjReserveUnitOwner> ProjReserveUnitOwners { get; set; } = null!;
        public virtual DbSet<ProjReserveUnitSeller> ProjReserveUnitSellers { get; set; } = null!;
        public virtual DbSet<ProjTender> ProjTenders { get; set; } = null!;
        public virtual DbSet<ProjTenderContract> ProjTenderContracts { get; set; } = null!;
        public virtual DbSet<ProjTenderContractAdd> ProjTenderContractAdds { get; set; } = null!;
        public virtual DbSet<ProjTenderContractDetail> ProjTenderContractDetails { get; set; } = null!;
        public virtual DbSet<ProjTenderContractDiscount> ProjTenderContractDiscounts { get; set; } = null!;
        public virtual DbSet<ProjTenderContractorContract> ProjTenderContractorContracts { get; set; } = null!;
        public virtual DbSet<ProjTenderContractorContractAdd> ProjTenderContractorContractAdds { get; set; } = null!;
        public virtual DbSet<ProjTenderContractorContractDetail> ProjTenderContractorContractDetails { get; set; } = null!;
        public virtual DbSet<ProjTenderContractorContractDiscount> ProjTenderContractorContractDiscounts { get; set; } = null!;
        public virtual DbSet<ProjTenderContractorExitract> ProjTenderContractorExitracts { get; set; } = null!;
        public virtual DbSet<ProjTenderContractorExitractAdd> ProjTenderContractorExitractAdds { get; set; } = null!;
        public virtual DbSet<ProjTenderContractorExitractDetail> ProjTenderContractorExitractDetails { get; set; } = null!;
        public virtual DbSet<ProjTenderContractorExitractDiscount> ProjTenderContractorExitractDiscounts { get; set; } = null!;
        public virtual DbSet<ProjTenderExecutionExitract> ProjTenderExecutionExitracts { get; set; } = null!;
        public virtual DbSet<ProjTenderExecutionExitractDetail> ProjTenderExecutionExitractDetails { get; set; } = null!;
        public virtual DbSet<ProjTenderItem> ProjTenderItems { get; set; } = null!;
        public virtual DbSet<ProjTenderItemsCategory> ProjTenderItemsCategories { get; set; } = null!;
        public virtual DbSet<ProjTenderOffer> ProjTenderOffers { get; set; } = null!;
        public virtual DbSet<ProjTenderOfferDetail> ProjTenderOfferDetails { get; set; } = null!;
        public virtual DbSet<ProjTenderOwnerExitract> ProjTenderOwnerExitracts { get; set; } = null!;
        public virtual DbSet<ProjTenderOwnerExitractAdd> ProjTenderOwnerExitractAdds { get; set; } = null!;
        public virtual DbSet<ProjTenderOwnerExitractDetail> ProjTenderOwnerExitractDetails { get; set; } = null!;
        public virtual DbSet<ProjTenderOwnerExitractDiscount> ProjTenderOwnerExitractDiscounts { get; set; } = null!;
        public virtual DbSet<ProjTenderPlan> ProjTenderPlans { get; set; } = null!;
        public virtual DbSet<ProjTenderPlanDetail> ProjTenderPlanDetails { get; set; } = null!;
        public virtual DbSet<ProjTenderPlanDistribution> ProjTenderPlanDistributions { get; set; } = null!;
        public virtual DbSet<ProjTenderPlanDistributionDetail> ProjTenderPlanDistributionDetails { get; set; } = null!;
        public virtual DbSet<ProjTenderQoutation> ProjTenderQoutations { get; set; } = null!;
        public virtual DbSet<ProjTenderQoutationDetail> ProjTenderQoutationDetails { get; set; } = null!;
        public virtual DbSet<ProjTendersDetail> ProjTendersDetails { get; set; } = null!;
        public virtual DbSet<ProjTendersReviewReason> ProjTendersReviewReasons { get; set; } = null!;
        public virtual DbSet<ProjUnitConcession> ProjUnitConcessions { get; set; } = null!;
        public virtual DbSet<ProjUnitHistoryLog> ProjUnitHistoryLogs { get; set; } = null!;
        public virtual DbSet<ProjUnitReplacement> ProjUnitReplacements { get; set; } = null!;
        public virtual DbSet<ProjUnitReservation> ProjUnitReservations { get; set; } = null!;
        public virtual DbSet<ProjUnitReservationGuarantor> ProjUnitReservationGuarantors { get; set; } = null!;
        public virtual DbSet<PurInvVendSearch> PurInvVendSearches { get; set; } = null!;
        public virtual DbSet<PurOrderVendor> PurOrderVendors { get; set; } = null!;
        public virtual DbSet<PurRequestVendor> PurRequestVendors { get; set; } = null!;
        public virtual DbSet<QualityCategory> QualityCategories { get; set; } = null!;
        public virtual DbSet<QualityItemDeliverDetail> QualityItemDeliverDetails { get; set; } = null!;
        public virtual DbSet<QualityItemDelivery> QualityItemDeliveries { get; set; } = null!;
        public virtual DbSet<QualityItemDeliveryPackage> QualityItemDeliveryPackages { get; set; } = null!;
        public virtual DbSet<QualityItemRecCheck> QualityItemRecChecks { get; set; } = null!;
        public virtual DbSet<QualityItemRecCheckDetail> QualityItemRecCheckDetails { get; set; } = null!;
        public virtual DbSet<QualityItemRecPackage> QualityItemRecPackages { get; set; } = null!;
        public virtual DbSet<QualityItemReceivType> QualityItemReceivTypes { get; set; } = null!;
        public virtual DbSet<QualityItemRecieve> QualityItemRecieves { get; set; } = null!;
        public virtual DbSet<QualityItemRecieveDetail> QualityItemRecieveDetails { get; set; } = null!;
        public virtual DbSet<ReciNotSearch> ReciNotSearches { get; set; } = null!;
        public virtual DbSet<RepairJobOrder> RepairJobOrders { get; set; } = null!;
        public virtual DbSet<RepairJobOrderComment> RepairJobOrderComments { get; set; } = null!;
        public virtual DbSet<RepairJobOrderEmp> RepairJobOrderEmps { get; set; } = null!;
        public virtual DbSet<RepairJobOrderItem> RepairJobOrderItems { get; set; } = null!;
        public virtual DbSet<RepairJobOrderScrapItem> RepairJobOrderScrapItems { get; set; } = null!;
        public virtual DbSet<RepairJobOrederExpense> RepairJobOrederExpenses { get; set; } = null!;
        public virtual DbSet<RetPurVendSearch> RetPurVendSearches { get; set; } = null!;
        public virtual DbSet<RetSaleSearch> RetSaleSearches { get; set; } = null!;
        public virtual DbSet<SalesInvCustSearch> SalesInvCustSearches { get; set; } = null!;
        public virtual DbSet<SalesOfferCust> SalesOfferCusts { get; set; } = null!;
        public virtual DbSet<SalesOrderCust> SalesOrderCusts { get; set; } = null!;
        public virtual DbSet<SearchAdjustMent> SearchAdjustMents { get; set; } = null!;
        public virtual DbSet<SearchAssetSetting> SearchAssetSettings { get; set; } = null!;
        public virtual DbSet<SearchAssetTermination> SearchAssetTerminations { get; set; } = null!;
        public virtual DbSet<SearchAttendanceDoc> SearchAttendanceDocs { get; set; } = null!;
        public virtual DbSet<SearchBankNotice> SearchBankNotices { get; set; } = null!;
        public virtual DbSet<SearchBoxTransferNote> SearchBoxTransferNotes { get; set; } = null!;
        public virtual DbSet<SearchDeliveRetVend> SearchDeliveRetVends { get; set; } = null!;
        public virtual DbSet<SearchDepreciationDoc> SearchDepreciationDocs { get; set; } = null!;
        public virtual DbSet<SearchEmpActivity> SearchEmpActivities { get; set; } = null!;
        public virtual DbSet<SearchEmpDocument> SearchEmpDocuments { get; set; } = null!;
        public virtual DbSet<SearchEmpLoanRequest> SearchEmpLoanRequests { get; set; } = null!;
        public virtual DbSet<SearchEmpMovePromotion> SearchEmpMovePromotions { get; set; } = null!;
        public virtual DbSet<SearchEmpVacation> SearchEmpVacations { get; set; } = null!;
        public virtual DbSet<SearchItemStockAdjustment> SearchItemStockAdjustments { get; set; } = null!;
        public virtual DbSet<SearchJobOrderEmpCostDoc> SearchJobOrderEmpCostDocs { get; set; } = null!;
        public virtual DbSet<SearchJobOrderEquipCostDoc> SearchJobOrderEquipCostDocs { get; set; } = null!;
        public virtual DbSet<SearchJurnalEntry> SearchJurnalEntries { get; set; } = null!;
        public virtual DbSet<SearchKeeper> SearchKeepers { get; set; } = null!;
        public virtual DbSet<SearchLeavPermissionRequest> SearchLeavPermissionRequests { get; set; } = null!;
        public virtual DbSet<SearchLeavePermision> SearchLeavePermisions { get; set; } = null!;
        public virtual DbSet<SearchPassPort> SearchPassPorts { get; set; } = null!;
        public virtual DbSet<SearchPettycash> SearchPettycashes { get; set; } = null!;
        public virtual DbSet<SearchPrintPricing> SearchPrintPricings { get; set; } = null!;
        public virtual DbSet<SearchPrintQoutation> SearchPrintQoutations { get; set; } = null!;
        public virtual DbSet<SearchProductionOrder> SearchProductionOrders { get; set; } = null!;
        public virtual DbSet<SearchReqOfQoutation> SearchReqOfQoutations { get; set; } = null!;
        public virtual DbSet<SearchRewardAndPenalty> SearchRewardAndPenalties { get; set; } = null!;
        public virtual DbSet<SearchSalaryIssueDoc> SearchSalaryIssueDocs { get; set; } = null!;
        public virtual DbSet<SearchSalesOfferRequest> SearchSalesOfferRequests { get; set; } = null!;
        public virtual DbSet<SearchServiceRequest> SearchServiceRequests { get; set; } = null!;
        public virtual DbSet<SearchShippingDeclaration> SearchShippingDeclarations { get; set; } = null!;
        public virtual DbSet<SearchStockTransferNote> SearchStockTransferNotes { get; set; } = null!;
        public virtual DbSet<SearchStockTransferNoteRequest> SearchStockTransferNoteRequests { get; set; } = null!;
        public virtual DbSet<SearchTermination> SearchTerminations { get; set; } = null!;
        public virtual DbSet<SearchTrip> SearchTrips { get; set; } = null!;
        public virtual DbSet<SearchVacationDoc> SearchVacationDocs { get; set; } = null!;
        public virtual DbSet<SearchVacationEdit> SearchVacationEdits { get; set; } = null!;
        public virtual DbSet<SearchVacationRequest> SearchVacationRequests { get; set; } = null!;
        public virtual DbSet<SearchVehicleJobOrder> SearchVehicleJobOrders { get; set; } = null!;
        public virtual DbSet<SearchVehicleMovement> SearchVehicleMovements { get; set; } = null!;
        public virtual DbSet<SearchVehicleRenalContract> SearchVehicleRenalContracts { get; set; } = null!;
        public virtual DbSet<SearchWeightCard> SearchWeightCards { get; set; } = null!;
        public virtual DbSet<SrAccomodation> SrAccomodations { get; set; } = null!;
        public virtual DbSet<SrBrand> SrBrands { get; set; } = null!;
        public virtual DbSet<SrComplaint> SrComplaints { get; set; } = null!;
        public virtual DbSet<SrContainerType> SrContainerTypes { get; set; } = null!;
        public virtual DbSet<SrDriver> SrDrivers { get; set; } = null!;
        public virtual DbSet<SrEmpServicType> SrEmpServicTypes { get; set; } = null!;
        public virtual DbSet<SrExtension> SrExtensions { get; set; } = null!;
        public virtual DbSet<SrFlateRate> SrFlateRates { get; set; } = null!;
        public virtual DbSet<SrFlight> SrFlights { get; set; } = null!;
        public virtual DbSet<SrGarage> SrGarages { get; set; } = null!;
        public virtual DbSet<SrHarbor> SrHarbors { get; set; } = null!;
        public virtual DbSet<SrHotel> SrHotels { get; set; } = null!;
        public virtual DbSet<SrJobAdditionalCost> SrJobAdditionalCosts { get; set; } = null!;
        public virtual DbSet<SrJobComment> SrJobComments { get; set; } = null!;
        public virtual DbSet<SrJobExtrnalExpen> SrJobExtrnalExpens { get; set; } = null!;
        public virtual DbSet<SrJobFile> SrJobFiles { get; set; } = null!;
        public virtual DbSet<SrJobOrder> SrJobOrders { get; set; } = null!;
        public virtual DbSet<SrJobSpart> SrJobSparts { get; set; } = null!;
        public virtual DbSet<SrJobSwage> SrJobSwages { get; set; } = null!;
        public virtual DbSet<SrMalfunction> SrMalfunctions { get; set; } = null!;
        public virtual DbSet<SrProductsType> SrProductsTypes { get; set; } = null!;
        public virtual DbSet<SrProgram> SrPrograms { get; set; } = null!;
        public virtual DbSet<SrReceptionImage> SrReceptionImages { get; set; } = null!;
        public virtual DbSet<SrReciption> SrReciptions { get; set; } = null!;
        public virtual DbSet<SrReciptionDetail> SrReciptionDetails { get; set; } = null!;
        public virtual DbSet<SrReqOfQoutation> SrReqOfQoutations { get; set; } = null!;
        public virtual DbSet<SrServiceDistribution> SrServiceDistributions { get; set; } = null!;
        public virtual DbSet<SrServiceDistributionDetail> SrServiceDistributionDetails { get; set; } = null!;
        public virtual DbSet<SrServiceRequest> SrServiceRequests { get; set; } = null!;
        public virtual DbSet<SrServiceRequestResource> SrServiceRequestResources { get; set; } = null!;
        public virtual DbSet<SrServiceType> SrServiceTypes { get; set; } = null!;
        public virtual DbSet<SrShippingDeclaration> SrShippingDeclarations { get; set; } = null!;
        public virtual DbSet<SrTask> SrTasks { get; set; } = null!;
        public virtual DbSet<SrTaskEmp> SrTaskEmps { get; set; } = null!;
        public virtual DbSet<SrTaskItem> SrTaskItems { get; set; } = null!;
        public virtual DbSet<SrTrafficLine> SrTrafficLines { get; set; } = null!;
        public virtual DbSet<SrTrafficLinePriceList> SrTrafficLinePriceLists { get; set; } = null!;
        public virtual DbSet<SrTransportation> SrTransportations { get; set; } = null!;
        public virtual DbSet<SrTrip> SrTrips { get; set; } = null!;
        public virtual DbSet<SrTripAccomDetail> SrTripAccomDetails { get; set; } = null!;
        public virtual DbSet<SrTripProgramJoin> SrTripProgramJoins { get; set; } = null!;
        public virtual DbSet<SrVehicle> SrVehicles { get; set; } = null!;
        public virtual DbSet<SrVehicleItemCard> SrVehicleItemCards { get; set; } = null!;
        public virtual DbSet<SrVehicleJobOrder> SrVehicleJobOrders { get; set; } = null!;
        public virtual DbSet<SrVehicleJobOrderDetail> SrVehicleJobOrderDetails { get; set; } = null!;
        public virtual DbSet<SrVehicleMovement> SrVehicleMovements { get; set; } = null!;
        public virtual DbSet<SrVehicleMovementDetail> SrVehicleMovementDetails { get; set; } = null!;
        public virtual DbSet<SrVehicleRenalContract> SrVehicleRenalContracts { get; set; } = null!;
        public virtual DbSet<SrVehicleRentPayJoin> SrVehicleRentPayJoins { get; set; } = null!;
        public virtual DbSet<SrVehicleRentPurchJoin> SrVehicleRentPurchJoins { get; set; } = null!;
        public virtual DbSet<SrVehicleRentRecJoin> SrVehicleRentRecJoins { get; set; } = null!;
        public virtual DbSet<SrVehicleRentSalesInvJoin> SrVehicleRentSalesInvJoins { get; set; } = null!;
        public virtual DbSet<SrVehicleShape> SrVehicleShapes { get; set; } = null!;
        public virtual DbSet<SrVehicleType> SrVehicleTypes { get; set; } = null!;
        public virtual DbSet<SrVheicleJobOrderType> SrVheicleJobOrderTypes { get; set; } = null!;
        public virtual DbSet<SrWarranty> SrWarranties { get; set; } = null!;
        public virtual DbSet<StockArchive> StockArchives { get; set; } = null!;
        public virtual DbSet<StockBroker> StockBrokers { get; set; } = null!;
        public virtual DbSet<StockCapitalUpdate> StockCapitalUpdates { get; set; } = null!;
        public virtual DbSet<StockCashTransfer> StockCashTransfers { get; set; } = null!;
        public virtual DbSet<StockCashWithdrawalReason> StockCashWithdrawalReasons { get; set; } = null!;
        public virtual DbSet<StockCategory> StockCategories { get; set; } = null!;
        public virtual DbSet<StockDealer> StockDealers { get; set; } = null!;
        public virtual DbSet<StockMarket> StockMarkets { get; set; } = null!;
        public virtual DbSet<StockOpenningBalance> StockOpenningBalances { get; set; } = null!;
        public virtual DbSet<StockOpenningBalanceDetail> StockOpenningBalanceDetails { get; set; } = null!;
        public virtual DbSet<StockPortfolio> StockPortfolios { get; set; } = null!;
        public virtual DbSet<StockPortfolioAccount> StockPortfolioAccounts { get; set; } = null!;
        public virtual DbSet<StockPortfolioStock> StockPortfolioStocks { get; set; } = null!;
        public virtual DbSet<StockPortfolioStockArchive> StockPortfolioStockArchives { get; set; } = null!;
        public virtual DbSet<StockRecCustSearch> StockRecCustSearches { get; set; } = null!;
        public virtual DbSet<StockRecSearch> StockRecSearches { get; set; } = null!;
        public virtual DbSet<StockRecVendSearch> StockRecVendSearches { get; set; } = null!;
        public virtual DbSet<StockSalesPurchase> StockSalesPurchases { get; set; } = null!;
        public virtual DbSet<StockSalesPurchaseDetail> StockSalesPurchaseDetails { get; set; } = null!;
        public virtual DbSet<StockSector> StockSectors { get; set; } = null!;
        public virtual DbSet<StockShareholdersName> StockShareholdersNames { get; set; } = null!;
        public virtual DbSet<StockStock> StockStocks { get; set; } = null!;
        public virtual DbSet<StockTranType> StockTranTypes { get; set; } = null!;
        public virtual DbSet<StockTransfer> StockTransfers { get; set; } = null!;
        public virtual DbSet<StockTransferDetail> StockTransferDetails { get; set; } = null!;
        public virtual DbSet<SysAnalyticalCode> SysAnalyticalCodes { get; set; } = null!;
        public virtual DbSet<SysAnalyticalCodeProccess> SysAnalyticalCodeProccesses { get; set; } = null!;
        public virtual DbSet<SysAnalyticalCodeUpdate> SysAnalyticalCodeUpdates { get; set; } = null!;
        public virtual DbSet<SysAnalyticalCodeUpdateType> SysAnalyticalCodeUpdateTypes { get; set; } = null!;
        public virtual DbSet<SysBasket> SysBaskets { get; set; } = null!;
        public virtual DbSet<SysBook> SysBooks { get; set; } = null!;
        public virtual DbSet<SysCity> SysCities { get; set; } = null!;
        public virtual DbSet<SysConfigsm> SysConfigsms { get; set; } = null!;
        public virtual DbSet<SysCounter> SysCounters { get; set; } = null!;
        public virtual DbSet<SysCountry> SysCountries { get; set; } = null!;
        public virtual DbSet<SysFinancialInterval> SysFinancialIntervals { get; set; } = null!;
        public virtual DbSet<SysFinancialYear> SysFinancialYears { get; set; } = null!;
        public virtual DbSet<SysFinancialYearsClosing> SysFinancialYearsClosings { get; set; } = null!;
        public virtual DbSet<SysFlexList> SysFlexLists { get; set; } = null!;
        public virtual DbSet<SysLog> SysLogs { get; set; } = null!;
        public virtual DbSet<SysNaming> SysNamings { get; set; } = null!;
        public virtual DbSet<SysNotification> SysNotifications { get; set; } = null!;
        public virtual DbSet<SysNotificationType> SysNotificationTypes { get; set; } = null!;
        public virtual DbSet<SysRemotBranchesLog> SysRemotBranchesLogs { get; set; } = null!;
        public virtual DbSet<SysRemotLogDetail> SysRemotLogDetails { get; set; } = null!;
        public virtual DbSet<SysRemotTranLog> SysRemotTranLogs { get; set; } = null!;
        public virtual DbSet<SysRemoteBranchesLogDetaile> SysRemoteBranchesLogDetailes { get; set; } = null!;
        public virtual DbSet<TrOpenningBalance> TrOpenningBalances { get; set; } = null!;
        public virtual DbSet<TrOpenningBalanceDetail> TrOpenningBalanceDetails { get; set; } = null!;
        public virtual DbSet<VdeliverSalesInvfilter> VdeliverSalesInvfilters { get; set; } = null!;
        public virtual DbSet<VwAccountClassification> VwAccountClassifications { get; set; } = null!;
        public virtual DbSet<VwAllAccountsTransaction> VwAllAccountsTransactions { get; set; } = null!;
        public virtual DbSet<VwAllAnalyticalCodTransaction> VwAllAnalyticalCodTransactions { get; set; } = null!;
        public virtual DbSet<VwAllAnalyticalCodTransactionsDetail> VwAllAnalyticalCodTransactionsDetails { get; set; } = null!;
        public virtual DbSet<VwAllCostCenterTransaction> VwAllCostCenterTransactions { get; set; } = null!;
        public virtual DbSet<VwAllJobOrder> VwAllJobOrders { get; set; } = null!;
        public virtual DbSet<VwAllJobOrderDocument> VwAllJobOrderDocuments { get; set; } = null!;
        public virtual DbSet<VwAllLetOfGtransaction> VwAllLetOfGtransactions { get; set; } = null!;
        public virtual DbSet<VwAllRepairOrder> VwAllRepairOrders { get; set; } = null!;
        public virtual DbSet<VwAllSrJobOrderMotor> VwAllSrJobOrderMotors { get; set; } = null!;
        public virtual DbSet<VwAllVehicleJobOrdersDoc> VwAllVehicleJobOrdersDocs { get; set; } = null!;
        public virtual DbSet<VwAttendTime> VwAttendTimes { get; set; } = null!;
        public virtual DbSet<VwCustomerCategory> VwCustomerCategories { get; set; } = null!;
        public virtual DbSet<VwDailyTransaction> VwDailyTransactions { get; set; } = null!;
        public virtual DbSet<VwEmpAttendanceTran> VwEmpAttendanceTrans { get; set; } = null!;
        public virtual DbSet<VwGetAdjustMentsByCust> VwGetAdjustMentsByCusts { get; set; } = null!;
        public virtual DbSet<VwGetAdjustMentsByVend> VwGetAdjustMentsByVends { get; set; } = null!;
        public virtual DbSet<VwGetAdjustMentsRank> VwGetAdjustMentsRanks { get; set; } = null!;
        public virtual DbSet<VwGetAllBatch> VwGetAllBatches { get; set; } = null!;
        public virtual DbSet<VwGetAnalyticalCodeRank> VwGetAnalyticalCodeRanks { get; set; } = null!;
        public virtual DbSet<VwGetAssetRank> VwGetAssetRanks { get; set; } = null!;
        public virtual DbSet<VwGetAssetSettingsRank> VwGetAssetSettingsRanks { get; set; } = null!;
        public virtual DbSet<VwGetAssetTerminationRank> VwGetAssetTerminationRanks { get; set; } = null!;
        public virtual DbSet<VwGetAttendanceDocRank> VwGetAttendanceDocRanks { get; set; } = null!;
        public virtual DbSet<VwGetBankNoticeRank> VwGetBankNoticeRanks { get; set; } = null!;
        public virtual DbSet<VwGetBomrank> VwGetBomranks { get; set; } = null!;
        public virtual DbSet<VwGetBoxTransferNoteRank> VwGetBoxTransferNoteRanks { get; set; } = null!;
        public virtual DbSet<VwGetCurrencyRank> VwGetCurrencyRanks { get; set; } = null!;
        public virtual DbSet<VwGetCustomersRank> VwGetCustomersRanks { get; set; } = null!;
        public virtual DbSet<VwGetDeliverSalesInvoiceByCust> VwGetDeliverSalesInvoiceByCusts { get; set; } = null!;
        public virtual DbSet<VwGetDeliverSalesInvoiceByVend> VwGetDeliverSalesInvoiceByVends { get; set; } = null!;
        public virtual DbSet<VwGetDeliverSalesInvoiceRank> VwGetDeliverSalesInvoiceRanks { get; set; } = null!;
        public virtual DbSet<VwGetDepreciationDocRank> VwGetDepreciationDocRanks { get; set; } = null!;
        public virtual DbSet<VwGetEmpActivityRank> VwGetEmpActivityRanks { get; set; } = null!;
        public virtual DbSet<VwGetEmpLoanRequestRank> VwGetEmpLoanRequestRanks { get; set; } = null!;
        public virtual DbSet<VwGetEmpMovePromotionRank> VwGetEmpMovePromotionRanks { get; set; } = null!;
        public virtual DbSet<VwGetEmpVacationRank> VwGetEmpVacationRanks { get; set; } = null!;
        public virtual DbSet<VwGetGawabRecordRank> VwGetGawabRecordRanks { get; set; } = null!;
        public virtual DbSet<VwGetHrTerminationRank> VwGetHrTerminationRanks { get; set; } = null!;
        public virtual DbSet<VwGetItemAlter> VwGetItemAlters { get; set; } = null!;
        public virtual DbSet<VwGetItemCardRank> VwGetItemCardRanks { get; set; } = null!;
        public virtual DbSet<VwGetItemStockAdjustmentRank> VwGetItemStockAdjustmentRanks { get; set; } = null!;
        public virtual DbSet<VwGetJobOrderByCust> VwGetJobOrderByCusts { get; set; } = null!;
        public virtual DbSet<VwGetJobOrderRank> VwGetJobOrderRanks { get; set; } = null!;
        public virtual DbSet<VwGetJournalEntryRank> VwGetJournalEntryRanks { get; set; } = null!;
        public virtual DbSet<VwGetKeeperBankRank> VwGetKeeperBankRanks { get; set; } = null!;
        public virtual DbSet<VwGetLeavPermissionRequestRank> VwGetLeavPermissionRequestRanks { get; set; } = null!;
        public virtual DbSet<VwGetLeavePermisionRank> VwGetLeavePermisionRanks { get; set; } = null!;
        public virtual DbSet<VwGetNotification> VwGetNotifications { get; set; } = null!;
        public virtual DbSet<VwGetPassPortRank> VwGetPassPortRanks { get; set; } = null!;
        public virtual DbSet<VwGetPaymentNoteByCust> VwGetPaymentNoteByCusts { get; set; } = null!;
        public virtual DbSet<VwGetPaymentNoteByVend> VwGetPaymentNoteByVends { get; set; } = null!;
        public virtual DbSet<VwGetPaymentNoteRank> VwGetPaymentNoteRanks { get; set; } = null!;
        public virtual DbSet<VwGetPettycashRank> VwGetPettycashRanks { get; set; } = null!;
        public virtual DbSet<VwGetPettycashSearch> VwGetPettycashSearches { get; set; } = null!;
        public virtual DbSet<VwGetProductionOrdeRank> VwGetProductionOrdeRanks { get; set; } = null!;
        public virtual DbSet<VwGetPurchasInvoiceByVend> VwGetPurchasInvoiceByVends { get; set; } = null!;
        public virtual DbSet<VwGetPurchasInvoiceRank> VwGetPurchasInvoiceRanks { get; set; } = null!;
        public virtual DbSet<VwGetPurchasOrderByVend> VwGetPurchasOrderByVends { get; set; } = null!;
        public virtual DbSet<VwGetPurchasOrderRank> VwGetPurchasOrderRanks { get; set; } = null!;
        public virtual DbSet<VwGetPurchasOrderRequestRank> VwGetPurchasOrderRequestRanks { get; set; } = null!;
        public virtual DbSet<VwGetReceiptNoteByCust> VwGetReceiptNoteByCusts { get; set; } = null!;
        public virtual DbSet<VwGetReceiptNoteByVend> VwGetReceiptNoteByVends { get; set; } = null!;
        public virtual DbSet<VwGetReceiptNoteRank> VwGetReceiptNoteRanks { get; set; } = null!;
        public virtual DbSet<VwGetRecipeRank> VwGetRecipeRanks { get; set; } = null!;
        public virtual DbSet<VwGetReturnPurchaseByVend> VwGetReturnPurchaseByVends { get; set; } = null!;
        public virtual DbSet<VwGetReturnPurchaseRank> VwGetReturnPurchaseRanks { get; set; } = null!;
        public virtual DbSet<VwGetReturnSalesByCust> VwGetReturnSalesByCusts { get; set; } = null!;
        public virtual DbSet<VwGetReturnSalesRank> VwGetReturnSalesRanks { get; set; } = null!;
        public virtual DbSet<VwGetRewardAndPenaltyRank> VwGetRewardAndPenaltyRanks { get; set; } = null!;
        public virtual DbSet<VwGetSalaryIssueDocRank> VwGetSalaryIssueDocRanks { get; set; } = null!;
        public virtual DbSet<VwGetSalesInvByCust> VwGetSalesInvByCusts { get; set; } = null!;
        public virtual DbSet<VwGetSalesInvoiceRank> VwGetSalesInvoiceRanks { get; set; } = null!;
        public virtual DbSet<VwGetSalesOfferByCust> VwGetSalesOfferByCusts { get; set; } = null!;
        public virtual DbSet<VwGetSalesOfferRank> VwGetSalesOfferRanks { get; set; } = null!;
        public virtual DbSet<VwGetSalesOfferRequestByCust> VwGetSalesOfferRequestByCusts { get; set; } = null!;
        public virtual DbSet<VwGetSalesOfferRequestRank> VwGetSalesOfferRequestRanks { get; set; } = null!;
        public virtual DbSet<VwGetSalesOrderByCust> VwGetSalesOrderByCusts { get; set; } = null!;
        public virtual DbSet<VwGetSalesOrderRank> VwGetSalesOrderRanks { get; set; } = null!;
        public virtual DbSet<VwGetStockRecriptByCust> VwGetStockRecriptByCusts { get; set; } = null!;
        public virtual DbSet<VwGetStockRecriptByVend> VwGetStockRecriptByVends { get; set; } = null!;
        public virtual DbSet<VwGetStockRecriptRank> VwGetStockRecriptRanks { get; set; } = null!;
        public virtual DbSet<VwGetStockTransferNoteRank> VwGetStockTransferNoteRanks { get; set; } = null!;
        public virtual DbSet<VwGetTripsRank> VwGetTripsRanks { get; set; } = null!;
        public virtual DbSet<VwGetVacationDocRank> VwGetVacationDocRanks { get; set; } = null!;
        public virtual DbSet<VwGetVacationEditRank> VwGetVacationEditRanks { get; set; } = null!;
        public virtual DbSet<VwGetVacationRequestRank> VwGetVacationRequestRanks { get; set; } = null!;
        public virtual DbSet<VwGetVehicleJobOrderRank> VwGetVehicleJobOrderRanks { get; set; } = null!;
        public virtual DbSet<VwGetVehicleRenalContractRank> VwGetVehicleRenalContractRanks { get; set; } = null!;
        public virtual DbSet<VwGetVendorsRank> VwGetVendorsRanks { get; set; } = null!;
        public virtual DbSet<VwGetWeightCardRank> VwGetWeightCardRanks { get; set; } = null!;
        public virtual DbSet<VwGlclassification> VwGlclassifications { get; set; } = null!;
        public virtual DbSet<VwHelpingAccountsSearch> VwHelpingAccountsSearches { get; set; } = null!;
        public virtual DbSet<VwItemCard> VwItemCards { get; set; } = null!;
        public virtual DbSet<VwItemUnitGrand> VwItemUnitGrands { get; set; } = null!;
        public virtual DbSet<VwItemUnitGrandAttribute> VwItemUnitGrandAttributes { get; set; } = null!;
        public virtual DbSet<VwItemUnitSummary> VwItemUnitSummaries { get; set; } = null!;
        public virtual DbSet<VwJobOrder> VwJobOrders { get; set; } = null!;
        public virtual DbSet<VwLotNumberExpiryPartition> VwLotNumberExpiryPartitions { get; set; } = null!;
        public virtual DbSet<VwProdItemAttribute> VwProdItemAttributes { get; set; } = null!;
        public virtual DbSet<VwProdItemUnit> VwProdItemUnits { get; set; } = null!;
        public virtual DbSet<VwProdWorkOrderSearch> VwProdWorkOrderSearches { get; set; } = null!;
        public virtual DbSet<VwQualityItemDeliverySearch> VwQualityItemDeliverySearches { get; set; } = null!;
        public virtual DbSet<VwQualityItemRecCheckSearch> VwQualityItemRecCheckSearches { get; set; } = null!;
        public virtual DbSet<VwQualityItemRecieveSearch> VwQualityItemRecieveSearches { get; set; } = null!;
        public virtual DbSet<VwReservedQty> VwReservedQties { get; set; } = null!;
        public virtual DbSet<VwSearchAllAccount> VwSearchAllAccounts { get; set; } = null!;
        public virtual DbSet<VwSearchInstallment> VwSearchInstallments { get; set; } = null!;
        public virtual DbSet<VwSearchRealStatUnit> VwSearchRealStatUnits { get; set; } = null!;
        public virtual DbSet<VwSearchUnitReservation> VwSearchUnitReservations { get; set; } = null!;
        public virtual DbSet<VwVendorCategory> VwVendorCategories { get; set; } = null!;
        public virtual DbSet<VwWeightCard> VwWeightCards { get; set; } = null!;
        public virtual DbSet<VwWorkForcExecluded> VwWorkForcExecludeds { get; set; } = null!;
        public virtual DbSet<VwWorkForcTemplate> VwWorkForcTemplates { get; set; } = null!;
        public virtual DbSet<VwWorkForcTestResult> VwWorkForcTestResults { get; set; } = null!;
        public virtual DbSet<VwsimpleAllTransaction> VwsimpleAllTransactions { get; set; } = null!;
        public virtual DbSet<WorForcFirm> WorForcFirms { get; set; } = null!;
        public virtual DbSet<WorkForcActionType> WorkForcActionTypes { get; set; } = null!;
        public virtual DbSet<WorkForcBloodExeclude> WorkForcBloodExecludes { get; set; } = null!;
        public virtual DbSet<WorkForcBloodExecludeDetail> WorkForcBloodExecludeDetails { get; set; } = null!;
        public virtual DbSet<WorkForcFirstCustExeclude> WorkForcFirstCustExecludes { get; set; } = null!;
        public virtual DbSet<WorkForcFirstCustExecludeDetail> WorkForcFirstCustExecludeDetails { get; set; } = null!;
        public virtual DbSet<WorkForcPassPort> WorkForcPassPorts { get; set; } = null!;
        public virtual DbSet<WorkForcPassPortsArchive> WorkForcPassPortsArchives { get; set; } = null!;
        public virtual DbSet<WorkForcProblem> WorkForcProblems { get; set; } = null!;
        public virtual DbSet<WorkForcSeason> WorkForcSeasons { get; set; } = null!;
        public virtual DbSet<WorkForcSecondCustExeclude> WorkForcSecondCustExecludes { get; set; } = null!;
        public virtual DbSet<WorkForcSecondCustExecludeDetail> WorkForcSecondCustExecludeDetails { get; set; } = null!;
        public virtual DbSet<WorkForcTempId> WorkForcTempIds { get; set; } = null!;
        public virtual DbSet<WorkForcTemplate> WorkForcTemplates { get; set; } = null!;
        public virtual DbSet<WorkForcTemplatesDetail> WorkForcTemplatesDetails { get; set; } = null!;
        public virtual DbSet<WorkForcTestResult> WorkForcTestResults { get; set; } = null!;
        public virtual DbSet<WorkForcTestResultsDetail> WorkForcTestResultsDetails { get; set; } = null!;
        public virtual DbSet<YearMonthe> YearMonthes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer(Smtp.SmtpConfig.GetConnectionString());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnAnimalDeath>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<AnAnimalDeathDetail>(entity =>
            {
                entity.Property(e => e.DbtableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.LastUpdateTime)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.QtyIunit2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.AnDeath)
                    .WithMany(p => p.AnAnimalDeathDetails)
                    .HasForeignKey(d => d.AnDeathId)
                    .HasConstraintName("FK_An_AnimalDeathDetail_An_AnimalDeath");
            });

            modelBuilder.Entity<AnAnimalMidicin>(entity =>
            {
                entity.Property(e => e.AnimalAge).HasComment("Days");

                entity.HasOne(d => d.AnMidicin)
                    .WithMany(p => p.AnAnimalMidicins)
                    .HasForeignKey(d => d.AnMidicinId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_An_ANimalMidicin_An_Medicin");

                entity.HasOne(d => d.AnType)
                    .WithMany(p => p.AnAnimalMidicins)
                    .HasForeignKey(d => d.AnTypeId)
                    .HasConstraintName("FK_An_ANimalMidicin_An_AnimalType");
            });

            modelBuilder.Entity<AnAnimalType>(entity =>
            {
                entity.Property(e => e.Code).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<AnAnimalWeightRate>(entity =>
            {
                entity.Property(e => e.Code).IsFixedLength();

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<AnAnimalWeightRateDetail>(entity =>
            {
                entity.HasOne(d => d.AnWeightRate)
                    .WithMany(p => p.AnAnimalWeightRateDetails)
                    .HasForeignKey(d => d.AnWeightRateId)
                    .HasConstraintName("FK_An_AnimalWeightRateDetail_An_AnimalWeightRate");
            });

            modelBuilder.Entity<AnMedicin>(entity =>
            {
                entity.Property(e => e.AnimalAge).HasComment("Days");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<AnNewBorn>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<AnNewBornDetail>(entity =>
            {
                entity.Property(e => e.DbtableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.LastUpdateTime)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.QtyIunit2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.AnBorn)
                    .WithMany(p => p.AnNewBornDetails)
                    .HasForeignKey(d => d.AnBornId)
                    .HasConstraintName("FK_An_NewBornDetail_An_NewBorn");
            });

            modelBuilder.Entity<AssetAssetAddDoc>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<AssetAssetAddDocDetail>(entity =>
            {
                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.AssetAdd)
                    .WithMany(p => p.AssetAssetAddDocDetails)
                    .HasForeignKey(d => d.AssetAddId)
                    .HasConstraintName("FK_Asset_AssetAddDocDetail_Asset_AssetAddDoc");
            });

            modelBuilder.Entity<AssetAssetCard>(entity =>
            {
                entity.Property(e => e.Address1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Address2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Address3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email4).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.EtaxCustType).HasComment("Business  tax Reg Required,Person   NationalID not required,Foreigner  Name and ID  required");

                entity.Property(e => e.Fax).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Tel).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Tel2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel3).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel4).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel5).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.AssetCat)
                    .WithMany(p => p.AssetAssetCards)
                    .HasForeignKey(d => d.AssetCatId)
                    .HasConstraintName("FK_Asset_AssetCard_Asset_AssetCategory");
            });

            modelBuilder.Entity<AssetAssetCategory>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.ParentAssetCat)
                    .WithMany(p => p.InverseParentAssetCat)
                    .HasForeignKey(d => d.ParentAssetCatId)
                    .HasConstraintName("FK_Asset_AssetCategory_Asset_AssetCategory");
            });

            modelBuilder.Entity<AssetAssetContact>(entity =>
            {
                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.AssetAssetContacts)
                    .HasForeignKey(d => d.AssetId)
                    .HasConstraintName("FK_Asset_AssetContacts_Asset_AssetCard");
            });

            modelBuilder.Entity<AssetAssetDeductDoc>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<AssetAssetDeductDocDetail>(entity =>
            {
                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.AssetDeduct)
                    .WithMany(p => p.AssetAssetDeductDocDetails)
                    .HasForeignKey(d => d.AssetDeductId)
                    .HasConstraintName("FK_Asset_AssetDeductDocDetail_Asset_AssetDeductDoc");
            });

            modelBuilder.Entity<AssetAssetDeliverDoc>(entity =>
            {
                entity.HasKey(e => e.DeliverAssetId)
                    .HasName("PK_Asset_AssetCustodyDoc");

                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<AssetAssetDeliverDocDetail>(entity =>
            {
                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.DeliverAsset)
                    .WithMany(p => p.AssetAssetDeliverDocDetails)
                    .HasForeignKey(d => d.DeliverAssetId)
                    .HasConstraintName("FK_Asset_AssetDeliverDocDetail_Asset_AssetDeliverDoc");
            });

            modelBuilder.Entity<AssetAssetFixDoc>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<AssetAssetFixDocDetail>(entity =>
            {
                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.FixAsset)
                    .WithMany(p => p.AssetAssetFixDocDetails)
                    .HasForeignKey(d => d.FixAssetId)
                    .HasConstraintName("FK_Asset_AssetFixDocDetail_Asset_AssetFixDoc");
            });

            modelBuilder.Entity<AssetAssetMoveDoc>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<AssetAssetMoveDocDetail>(entity =>
            {
                entity.HasOne(d => d.AssetMov)
                    .WithMany(p => p.AssetAssetMoveDocDetails)
                    .HasForeignKey(d => d.AssetMovId)
                    .HasConstraintName("FK_Asset_AssetMoveDocDetail_Asset_AssetMoveDoc");
            });

            modelBuilder.Entity<AssetAssetReceiveDoc>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<AssetAssetReceiveDocDetail>(entity =>
            {
                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.ReceiveAsset)
                    .WithMany(p => p.AssetAssetReceiveDocDetails)
                    .HasForeignKey(d => d.ReceiveAssetId)
                    .HasConstraintName("FK_Asset_AssetReceiveDocDetail_Asset_AssetReceiveDoc");
            });

            modelBuilder.Entity<AssetAssetSetting>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<AssetAssetSettingDetail>(entity =>
            {
                entity.HasOne(d => d.AssetSet)
                    .WithMany(p => p.AssetAssetSettingDetails)
                    .HasForeignKey(d => d.AssetSetId)
                    .HasConstraintName("FK_Asset_AssetSettingDetails_Asset_AssetSettings");
            });

            modelBuilder.Entity<AssetDepreciationDoc>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<AssetDepreciationDocDetail>(entity =>
            {
                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.DeprDoc)
                    .WithMany(p => p.AssetDepreciationDocDetails)
                    .HasForeignKey(d => d.DeprDocId)
                    .HasConstraintName("FK_Asset_DepreciationDocDetail_Asset_DepreciationDoc");
            });

            modelBuilder.Entity<AssetTermination>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<BankAccountsView>(entity =>
            {
                entity.ToView("BankAccountsView");

                entity.Property(e => e.AcounntNameA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.AcountCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.BoxCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Desca).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<BnkBankNotice>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<BnkBankNoticeDetail>(entity =>
            {
                entity.HasOne(d => d.BankNotic)
                    .WithMany(p => p.BnkBankNoticeDetails)
                    .HasForeignKey(d => d.BankNoticId)
                    .HasConstraintName("FK_BNK_BankNoticeDetail_BNk_BankNotice");
            });

            modelBuilder.Entity<BoxTran>(entity =>
            {
                entity.ToView("BoxTran");

                entity.Property(e => e.BoxFrom).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BoxTo).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Desca).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Desce).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<CalAccChrtDailyAssist>(entity =>
            {
                entity.HasOne(d => d.Account)
                    .WithMany(p => p.CalAccChrtDailyAssists)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_Cal_AccChrtDailyAssist_Cal_AccountChart");
            });

            modelBuilder.Entity<CalAccountChart>(entity =>
            {
                entity.Property(e => e.AccCurrTrancCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccCurrTrancCreditCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccCurrTrancDepit).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccCurrTrancDepitCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccTotaCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccTotaCreditCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccTotalDebit).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccTotalDebitCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccountNameA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.AccountNameE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.BalanceCreditCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.BalanceCreditLocal).HasDefaultValueSql("((0))");

                entity.Property(e => e.BalanceDebitCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.BalanceDebitLocal).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.LastUpdateTime)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.OpenningBalanceCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.OpenningBalanceCreditCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.OpenningBalanceDepit).HasDefaultValueSql("((0))");

                entity.Property(e => e.OpenningBalanceDepitCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.AidNavigation)
                    .WithMany(p => p.CalAccountCharts)
                    .HasForeignKey(d => d.Aid)
                    .HasConstraintName("FK_Cal_AccountChart_Sys_AnalyticalCodes");
            });

            modelBuilder.Entity<CalAccountClaasiJoin>(entity =>
            {
                entity.HasOne(d => d.Account)
                    .WithMany(p => p.CalAccountClaasiJoins)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_Cal_AccountClaasiJoin_Cal_AccountChart");
            });

            modelBuilder.Entity<CalAccountUser>(entity =>
            {
                entity.HasOne(d => d.Account)
                    .WithMany(p => p.CalAccountUsers)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_Cal_AccountUsers_Cal_AccountChart");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CalAccountUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Cal_AccountUsers_G_Users");
            });

            modelBuilder.Entity<CalAssetAccount>(entity =>
            {
                entity.Property(e => e.AccCurrTrancCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccCurrTrancCreditCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccCurrTrancDepit).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccCurrTrancDepitCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccTotaCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccTotaCreditCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccTotalDebit).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccTotalDebitCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccountCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.AccountModel)
                    .HasComment("discount, tax, master ...etc")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.AccountNameA).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.AccountNameE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.BalanceCreditCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.BalanceCreditLocal).HasDefaultValueSql("((0))");

                entity.Property(e => e.BalanceDebitCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.BalanceDebitLocal).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.OpenningBalanceCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.OpenningBalanceCreditCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.OpenningBalanceDepit).HasDefaultValueSql("((0))");

                entity.Property(e => e.OpenningBalanceDepitCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.CalAssetAccounts)
                    .HasForeignKey(d => d.AssetId)
                    .HasConstraintName("FK_Cal_AssetAccounts_Asset_AssetCard");
            });

            modelBuilder.Entity<CalBudget>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CalBudgetDetail>(entity =>
            {
                entity.HasOne(d => d.Budget)
                    .WithMany(p => p.CalBudgetDetails)
                    .HasForeignKey(d => d.BudgetId)
                    .HasConstraintName("FK_Cal_BudgetDetails_Cal_Budget");
            });

            modelBuilder.Entity<CalBusinessPartnerAccount>(entity =>
            {
                entity.Property(e => e.AccCurrTrancCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccCurrTrancCreditCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccCurrTrancDepit).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccCurrTrancDepitCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccTotaCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccTotaCreditCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccTotalDebit).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccTotalDebitCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccountCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.AccountModel)
                    .HasComment("discount, tax, master ...etc")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.AccountNameA).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.AccountNameE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.BalanceCreditCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.BalanceCreditLocal).HasDefaultValueSql("((0))");

                entity.Property(e => e.BalanceDebitCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.BalanceDebitLocal).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.EtaxCustType).HasComment("Business  tax Reg Required,Person   NationalID not required,Foreigner  Name and ID  required");

                entity.Property(e => e.OpenningBalanceCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.OpenningBalanceCreditCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.OpenningBalanceDepit).HasDefaultValueSql("((0))");

                entity.Property(e => e.OpenningBalanceDepitCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.Bspartner)
                    .WithMany(p => p.CalBusinessPartnerAccounts)
                    .HasForeignKey(d => d.BspartnerId)
                    .HasConstraintName("FK_Cal_BusinessPartnerAccounts_Ms_BusinessPartners");
            });

            modelBuilder.Entity<CalCostCenter>(entity =>
            {
                entity.HasKey(e => e.CostCenterId)
                    .HasName("PK_Cal_CostCenter");

                entity.Property(e => e.BalanceCreditCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.BalanceCreditLocal).HasDefaultValueSql("((0))");

                entity.Property(e => e.BalanceDebitCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.BalanceDebitLocal).HasDefaultValueSql("((0))");

                entity.Property(e => e.CostCenterCurrTrancCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.CostCenterCurrTrancCreditCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.CostCenterCurrTrancDepit).HasDefaultValueSql("((0))");

                entity.Property(e => e.CostCenterCurrTrancDepitCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.CostCenterLevel).HasDefaultValueSql("((1))");

                entity.Property(e => e.CostCenterNameA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CostCenterNameE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CostCenterTotaCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.CostCenterTotaCreditCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.CostCenterTotalDebit).HasDefaultValueSql("((0))");

                entity.Property(e => e.CostCenterTotalDebitCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FunctionDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FunctionDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.OpenningBalanceCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.OpenningBalanceCreditCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.OpenningBalanceDepit).HasDefaultValueSql("((0))");

                entity.Property(e => e.OpenningBalanceDepitCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CalCostCenterAccount>(entity =>
            {
                entity.Property(e => e.AccCurrTrancCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccCurrTrancCreditCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccCurrTrancDepit).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccCurrTrancDepitCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccTotaCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccTotaCreditCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccTotalDebit).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccTotalDebitCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccountPercent).HasDefaultValueSql("((0))");

                entity.Property(e => e.BalanceCreditCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.BalanceCreditLocal).HasDefaultValueSql("((0))");

                entity.Property(e => e.BalanceDebitCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.BalanceDebitLocal).HasDefaultValueSql("((0))");

                entity.Property(e => e.OpenningBalanceCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.OpenningBalanceCreditCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.OpenningBalanceDepit).HasDefaultValueSql("((0))");

                entity.Property(e => e.OpenningBalanceDepitCurncy).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.CalCostCenterAccounts)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_Cal_CostCenterAccount_Cal_AccountChart");

                entity.HasOne(d => d.CostCenter)
                    .WithMany(p => p.CalCostCenterAccounts)
                    .HasForeignKey(d => d.CostCenterId)
                    .HasConstraintName("FK_Cal_CostCenterAccount_Cal_CostCenters");
            });

            modelBuilder.Entity<CalCustAccount>(entity =>
            {
                entity.Property(e => e.AccCurrTrancCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccCurrTrancCreditCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccCurrTrancDepit).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccCurrTrancDepitCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccTotaCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccTotaCreditCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccTotalDebit).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccTotalDebitCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccountCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.AccountModel).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.AccountNameA).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.AccountNameE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.BalanceCreditCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.BalanceCreditLocal).HasDefaultValueSql("((0))");

                entity.Property(e => e.BalanceDebitCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.BalanceDebitLocal).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.LastUpdateTime)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.OpenningBalanceCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.OpenningBalanceCreditCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.OpenningBalanceDepit).HasDefaultValueSql("((0))");

                entity.Property(e => e.OpenningBalanceDepitCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CalCustAccounts)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Cal_CustAccounts_MS_Customer");
            });

            modelBuilder.Entity<CalEmpAccount>(entity =>
            {
                entity.Property(e => e.AccCurrTrancCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccCurrTrancCreditCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccCurrTrancDepit).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccCurrTrancDepitCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccTotaCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccTotaCreditCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccTotalDebit).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccTotalDebitCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccountCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.AccountModel)
                    .HasComment("discount, tax, master ...etc")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.AccountNameA).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.AccountNameE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.BalanceCreditCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.BalanceCreditLocal).HasDefaultValueSql("((0))");

                entity.Property(e => e.BalanceDebitCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.BalanceDebitLocal).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.LastUpdateTime)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.OpenningBalanceCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.OpenningBalanceCreditCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.OpenningBalanceDepit).HasDefaultValueSql("((0))");

                entity.Property(e => e.OpenningBalanceDepitCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.CalEmpAccounts)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_Cal_EmpAccounts_Cal_AccountChart");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.CalEmpAccounts)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_Cal_EmpAccounts_Hr_Employees");
            });

            modelBuilder.Entity<CalJurnalDetail>(entity =>
            {
                entity.Property(e => e.JurDesc).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.CalJurnalDetails)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_Cal_JurnalDetail_MS_Currency");

                entity.HasOne(d => d.Jurnal)
                    .WithMany(p => p.CalJurnalDetails)
                    .HasForeignKey(d => d.JurnalId)
                    .HasConstraintName("FK_Cal_JurnalDetail_Cal_JurnalEntry");
            });

            modelBuilder.Entity<CalJurnalEntry>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsManual).HasDefaultValueSql("((0))");

                entity.Property(e => e.JurnalDesc).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.AidNavigation)
                    .WithMany(p => p.CalJurnalEntries)
                    .HasForeignKey(d => d.Aid)
                    .HasConstraintName("FK_Cal_JurnalEntry_Sys_AnalyticalCodes");

                entity.HasOne(d => d.Stor)
                    .WithMany(p => p.CalJurnalEntries)
                    .HasForeignKey(d => d.StorId)
                    .HasConstraintName("FK_Cal_JurnalEntry_MS_Stores");
            });

            modelBuilder.Entity<CalPostOrder>(entity =>
            {
                entity.Property(e => e.HelpAccType).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.HelpCostCenterType).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.OpenBalancCredCostCentr).HasDefaultValueSql("((0))");

                entity.Property(e => e.OpenBalancCredCrncyCostCentr).HasDefaultValueSql("((0))");

                entity.Property(e => e.OpenBalancDepCostCentr).HasDefaultValueSql("((0))");

                entity.Property(e => e.OpenBalancDepCrncyCostCentr).HasDefaultValueSql("((0))");

                entity.Property(e => e.OpenningBalanceCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.OpenningBalanceCreditCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.OpenningBalanceDepit).HasDefaultValueSql("((0))");

                entity.Property(e => e.OpenningBalanceDepitCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.TableCode).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<CalQueueOrder>(entity =>
            {
                entity.Property(e => e.TableCode).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<CalVendAccount>(entity =>
            {
                entity.Property(e => e.AccCurrTrancCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccCurrTrancCreditCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccCurrTrancDepit).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccCurrTrancDepitCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccTotaCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccTotaCreditCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccTotalDebit).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccTotalDebitCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccountCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.AccountModel)
                    .HasComment("discount, tax, master ...etc")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.AccountNameA).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.AccountNameE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.BalanceCreditCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.BalanceCreditLocal).HasDefaultValueSql("((0))");

                entity.Property(e => e.BalanceDebitCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.BalanceDebitLocal).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.LastUpdateTime)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.OpenningBalanceCredit).HasDefaultValueSql("((0))");

                entity.Property(e => e.OpenningBalanceCreditCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.OpenningBalanceDepit).HasDefaultValueSql("((0))");

                entity.Property(e => e.OpenningBalanceDepitCurncy).HasDefaultValueSql("((0))");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.CalVendAccounts)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_Cal_VendAccounts_MS_Vendor");
            });

            modelBuilder.Entity<CodAccountCategory>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.AidNavigation)
                    .WithMany(p => p.CodAccountCategories)
                    .HasForeignKey(d => d.Aid)
                    .HasConstraintName("FK_Cod_AccountCategories_Sys_AnalyticalCodes");
            });

            modelBuilder.Entity<CodAccountClassification>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.AccountCat)
                    .WithMany(p => p.CodAccountClassifications)
                    .HasForeignKey(d => d.AccountCatId)
                    .HasConstraintName("FK_Cod_AccountClassification_Cod_AccountCategories");
            });

            modelBuilder.Entity<CodBuildOccupType>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodBuildPermitActiv>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodBuildPerspective>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodBuildingDegree>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodBuildingExploitation>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodBuildingFinishingLevel>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodBuildingInsuranceStatus>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodBuildingStatus>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodBuildingType>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodCity>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_BIN");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_BIN");

                entity.Property(e => e.Lat).UseCollation("Arabic_BIN");

                entity.Property(e => e.Lng).UseCollation("Arabic_BIN");

                entity.Property(e => e.NameA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.NameE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RmarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("Arabic_BIN");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.CodCities)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("FK_Cod_City_Cod_Region");

                entity.HasOne(d => d.SysCity)
                    .WithMany(p => p.CodCities)
                    .HasForeignKey(d => d.SysCityId)
                    .HasConstraintName("FK_Cod_City_Sys_City");
            });

            modelBuilder.Entity<CodColor>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodContractType>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodCountry>(entity =>
            {
                entity.Property(e => e.CountryCode).UseCollation("Arabic_BIN");

                entity.Property(e => e.CreatedBy).UseCollation("Arabic_BIN");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_BIN");

                entity.Property(e => e.Lat).UseCollation("Arabic_BIN");

                entity.Property(e => e.Lng).UseCollation("Arabic_BIN");

                entity.Property(e => e.NameA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.NameE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("Arabic_BIN");

                entity.HasOne(d => d.CountryCodeNavigation)
                    .WithMany(p => p.CodCountries)
                    .HasForeignKey(d => d.CountryCode)
                    .HasConstraintName("FK_Cod_Country_Sys_Countries");
            });

            modelBuilder.Entity<CodDailyAssistance>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.CodDailyAssistances)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_Cod_DailyAssistance_Cal_AccountChart");

                entity.HasOne(d => d.AidNavigation)
                    .WithMany(p => p.CodDailyAssistances)
                    .HasForeignKey(d => d.Aid)
                    .HasConstraintName("FK_Cod_DailyAssistance_Sys_AnalyticalCodes");
            });

            modelBuilder.Entity<CodElectInsurStatus>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodExplanation>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodFurnitAndEqupmnt>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodInstallmentTemp>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodInstallmentTempsDetail>(entity =>
            {
                entity.HasOne(d => d.InstallTemp)
                    .WithMany(p => p.CodInstallmentTempsDetails)
                    .HasForeignKey(d => d.InstallTempId)
                    .HasConstraintName("FK_Cod_InstallmentTempsDetail_Cod_InstallmentTemps");
            });

            modelBuilder.Entity<CodInsurCovType>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodInsuranceCase>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodLand>(entity =>
            {
                entity.HasKey(e => e.LandId)
                    .HasName("PK_Code_Lands");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodLandPermitActivJoin>(entity =>
            {
                entity.HasOne(d => d.Land)
                    .WithMany(p => p.CodLandPermitActivJoins)
                    .HasForeignKey(d => d.LandId)
                    .HasConstraintName("FK_Cod_LandPermitActivJoin_Cod_Lands");

                entity.HasOne(d => d.LandPermitActiv)
                    .WithMany(p => p.CodLandPermitActivJoins)
                    .HasForeignKey(d => d.LandPermitActivId)
                    .HasConstraintName("FK_Cod_LandPermitActivJoin_Cod_LandPermtActiv");
            });

            modelBuilder.Entity<CodLandPermtActiv>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodLandPosJoin>(entity =>
            {
                entity.HasOne(d => d.Land)
                    .WithMany(p => p.CodLandPosJoins)
                    .HasForeignKey(d => d.LandId)
                    .HasConstraintName("FK_Cod_LandPosJoin_Cod_Lands");

                entity.HasOne(d => d.LandPos)
                    .WithMany(p => p.CodLandPosJoins)
                    .HasForeignKey(d => d.LandPosId)
                    .HasConstraintName("FK_Cod_LandPosJoin_Cod_LandPositions");
            });

            modelBuilder.Entity<CodLandPosition>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodLandRetainResJoin>(entity =>
            {
                entity.HasOne(d => d.Land)
                    .WithMany(p => p.CodLandRetainResJoins)
                    .HasForeignKey(d => d.LandId)
                    .HasConstraintName("FK_Cod_LandRetainResJoin_Cod_Lands");

                entity.HasOne(d => d.LandRetainRes)
                    .WithMany(p => p.CodLandRetainResJoins)
                    .HasForeignKey(d => d.LandRetainResId)
                    .HasConstraintName("FK_Cod_LandRetainResJoin_Cod_LandRetainRsons");
            });

            modelBuilder.Entity<CodLandRetainRson>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodLandStatus>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodLandType>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodMaintenanceType>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodNonRenewalReason>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodOperatingOrder>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodOwnershipBond>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodPackingSize>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodParking>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodPaymentTerm>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodPaymentType>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodPostalCode>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodRegion>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_BIN");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_BIN");

                entity.Property(e => e.Lat).UseCollation("Arabic_BIN");

                entity.Property(e => e.Lng).UseCollation("Arabic_BIN");

                entity.Property(e => e.NameA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.NameE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("Arabic_BIN");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CodRegions)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Cod_Region_Cod_Country");
            });

            modelBuilder.Entity<CodRentCase>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodSavingFile>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodService>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodShelf>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodSubRegion>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_BIN");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_BIN");

                entity.Property(e => e.Lat).UseCollation("Arabic_BIN");

                entity.Property(e => e.Lng).UseCollation("Arabic_BIN");

                entity.Property(e => e.NameA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.NameE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("Arabic_BIN");
            });

            modelBuilder.Entity<CodTaskType>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodTrmsModifiRson>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodUnitDegree>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodUnitExploitation>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodUnitFinishingLevel>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodUnitInsuranceStatus>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodUnitOccupancyType>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodUnitPermittedActivity>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodUnitPerspective>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodUnitService>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodUnitStatus>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodUnitType>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodUntMntanItmBylndownrTnant>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CodeSubUnitType>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<ContrInstallMent>(entity =>
            {
                entity.Property(e => e.AccountId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.AccountTableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DbtableId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.OtherSource).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<ContrInstallMentDetail>(entity =>
            {
                entity.HasOne(d => d.Install)
                    .WithMany(p => p.ContrInstallMentDetails)
                    .HasForeignKey(d => d.InstallId)
                    .HasConstraintName("FK_Contr_InstallMentDetail_Contr_InstallMent");
            });

            modelBuilder.Entity<CrmLead>(entity =>
            {
                entity.Property(e => e.Address).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Address1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Address2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Address3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Company).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustId).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CustJob).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email4).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Fax).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.LeadCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.LeadName1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.LeadName2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PeriodType).HasComment("1 day, 2 month, 3 year");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Tel).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Tel2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel3).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel4).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel5).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.LeadType)
                    .WithMany(p => p.CrmLeads)
                    .HasForeignKey(d => d.LeadTypeId)
                    .HasConstraintName("FK_CRM_Leads_CRM_LeadTypes");

                entity.HasOne(d => d.MarketChannel)
                    .WithMany(p => p.CrmLeads)
                    .HasForeignKey(d => d.MarketChannelId)
                    .HasConstraintName("FK_CRM_Leads_CRM_MarketChannels");
            });

            modelBuilder.Entity<CrmLeadType>(entity =>
            {
                entity.Property(e => e.CreayedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.LeadTypeDes).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.LeadTypeName1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.LeadTypeName2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CrmLeadsMember>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CrmLeadsMembersDetail>(entity =>
            {
                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.LeadMember)
                    .WithMany(p => p.CrmLeadsMembersDetails)
                    .HasForeignKey(d => d.LeadMemberId)
                    .HasConstraintName("FK_CRM_LeadsMembersDetails_CRM_LeadsMembers");
            });

            modelBuilder.Entity<CrmLeadsMembersJoin>(entity =>
            {
                entity.Property(e => e.LeadMemberJoin).ValueGeneratedNever();

                entity.HasOne(d => d.Lead)
                    .WithMany(p => p.CrmLeadsMembersJoins)
                    .HasForeignKey(d => d.LeadId)
                    .HasConstraintName("FK_CRM_LeadsMembersJoin_CRM_Leads");

                entity.HasOne(d => d.LeadMember)
                    .WithMany(p => p.CrmLeadsMembersJoins)
                    .HasForeignKey(d => d.LeadMemberId)
                    .HasConstraintName("FK_CRM_LeadsMembersJoin_CRM_LeadsMembers");
            });

            modelBuilder.Entity<CrmMarketChannel>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CrmSalesPlan>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PlanName1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PlanName2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CrmSalesPlanDetail>(entity =>
            {
                entity.HasOne(d => d.SalesPlan)
                    .WithMany(p => p.CrmSalesPlanDetails)
                    .HasForeignKey(d => d.SalesPlanId)
                    .HasConstraintName("FK_CRM_SalesPlanDetail_CRM_SalesPlan");
            });

            modelBuilder.Entity<CrmSurvey>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.VisitCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.VisitName1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.VisitName2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.VisitType)
                    .WithMany(p => p.CrmSurveys)
                    .HasForeignKey(d => d.VisitTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CRM_Survey_CRM_VisitTypes");
            });

            modelBuilder.Entity<CrmTeam>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TeamCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TeamName1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TeamName2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<CrmTeamMember>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.MemberCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.MemberName1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.MemberName2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.CrmTeamMembers)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("FK_CRM_TeamMembers_CRM_Teams");
            });

            modelBuilder.Entity<CrmVisit>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.VisitType)
                    .WithMany(p => p.CrmVisits)
                    .HasForeignKey(d => d.VisitTypeId)
                    .HasConstraintName("FK_CRM_Visits_CRM_VisitTypes");
            });

            modelBuilder.Entity<CrmVisitSurvey>(entity =>
            {
                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.CrmVisitSurveys)
                    .HasForeignKey(d => d.VisitId)
                    .HasConstraintName("FK_CRM_VisitSurveys_CRM_Visits");
            });

            modelBuilder.Entity<CrmVisitType>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.VisitCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.VisitName1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.VisitName2).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<DeliverCustSearch>(entity =>
            {
                entity.ToView("DeliverCustSearch");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<DeliverSearch>(entity =>
            {
                entity.ToView("DeliverSearch");

                entity.Property(e => e.CustomerCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CustomerDescA).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<GPrintLog>(entity =>
            {
                entity.Property(e => e.AddField1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.AddField2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DocName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<GUser>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Custom1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Custom2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Custom3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Custom4).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Custom5).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FirstName).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.LastName).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Password).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UserCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UserName).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UserType).HasComment("0 User , 1 superUser , 2 admin");

                entity.HasOne(d => d.UserRole)
                    .WithMany(p => p.GUsers)
                    .HasForeignKey(d => d.UserRoleId)
                    .HasConstraintName("FK_G_Users_G_UserRole");
            });

            modelBuilder.Entity<GUserGroup>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<GUserModule>(entity =>
            {
                entity.Property(e => e.ModuleCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ModuleDescA).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.GUserModules)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_G_USER_MODULE_G_Users");
            });

            modelBuilder.Entity<GUserRole>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<GUserRolePermission>(entity =>
            {
                entity.Property(e => e.ModuleCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ModuleDescA).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ModuleType).HasComment("1 screen, 2 TabPage,3 Label");

                entity.HasOne(d => d.UserRole)
                    .WithMany(p => p.GUserRolePermissions)
                    .HasForeignKey(d => d.UserRoleId)
                    .HasConstraintName("FK_G_UserRolePermissions_G_UserRole");
            });

            modelBuilder.Entity<HrActivityDetailElement>(entity =>
            {
                entity.HasOne(d => d.EmpActivityDetail)
                    .WithMany(p => p.HrActivityDetailElements)
                    .HasForeignKey(d => d.EmpActivityDetailId)
                    .HasConstraintName("FK_Hr_ActivityDetailElements_Hr_EmpActivityDetail");
            });

            modelBuilder.Entity<HrAttendDocDetail>(entity =>
            {
                entity.HasOne(d => d.AttendDoc)
                    .WithMany(p => p.HrAttendDocDetails)
                    .HasForeignKey(d => d.AttendDocId)
                    .HasConstraintName("FK_Hr_AttendDocDetails_Hr_AttendanceDoc");
            });

            modelBuilder.Entity<HrAttendDocFactElement>(entity =>
            {
                entity.HasOne(d => d.AttendDoc)
                    .WithMany(p => p.HrAttendDocFactElements)
                    .HasForeignKey(d => d.AttendDocId)
                    .HasConstraintName("FK_Hr_AttendDocFactElements_Hr_AttendanceDoc");
            });

            modelBuilder.Entity<HrAttendElementTran>(entity =>
            {
                entity.Property(e => e.TimeUnit).HasComment("1 number,2 minutes,3 hours,4 days");
            });

            modelBuilder.Entity<HrAttendanceDoc>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<HrAttendanceElement>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ElementCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<HrDepartment>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DepartCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DepartName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DepartName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DepartTask).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Hr_Departments_Hr_Departments");
            });

            modelBuilder.Entity<HrEducation>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EducationCode).IsFixedLength();

                entity.Property(e => e.EducationDesc).IsFixedLength();

                entity.Property(e => e.EducationName1).IsFixedLength();

                entity.Property(e => e.EducationName2).IsFixedLength();

                entity.Property(e => e.Qualification).IsFixedLength();

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<HrEmpActivity>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<HrEmpActivityDetail>(entity =>
            {
                entity.HasOne(d => d.EmpActivity)
                    .WithMany(p => p.HrEmpActivityDetails)
                    .HasForeignKey(d => d.EmpActivityId)
                    .HasConstraintName("FK_Hr_EmpActivityDetail_Hr_EmpActivity");
            });

            modelBuilder.Entity<HrEmpDocType>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<HrEmpDocument>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.EmpDocTyp)
                    .WithMany(p => p.HrEmpDocuments)
                    .HasForeignKey(d => d.EmpDocTypId)
                    .HasConstraintName("FK_Hr_EmpDocuments_Hr_EmpDocTypes");
            });

            modelBuilder.Entity<HrEmpElementPeriodBalance>(entity =>
            {
                entity.Property(e => e.TimeUnit).HasComment("1 minute,2 hour,3 day, 4 number");
            });

            modelBuilder.Entity<HrEmpGroup>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.GroupCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Hr_EmpGroups_Hr_EmpGroups");
            });

            modelBuilder.Entity<HrEmpLoan>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<HrEmpLoanRequest>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<HrEmpMovePromotDetail>(entity =>
            {
                entity.HasOne(d => d.EmpMove)
                    .WithMany(p => p.HrEmpMovePromotDetails)
                    .HasForeignKey(d => d.EmpMoveId)
                    .HasConstraintName("FK_Hr_EmpMovePromotDetail_Hr_EmpMovePromotion");
            });

            modelBuilder.Entity<HrEmpMovePromotion>(entity =>
            {
                entity.HasKey(e => e.EmpMoveId)
                    .HasName("PK_Hr_MoveAndPromotion");

                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<HrEmpSalaryType>(entity =>
            {
                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.HrEmpSalaryTypes)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_Hr_EmpSalaryTypes_Hr_Employees");

                entity.HasOne(d => d.SalaryTyp)
                    .WithMany(p => p.HrEmpSalaryTypes)
                    .HasForeignKey(d => d.SalaryTypId)
                    .HasConstraintName("FK_Hr_EmpSalaryTypes_Hr_SalaryTypes");
            });

            modelBuilder.Entity<HrEmpVacation>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<HrEmpVacationsDetail>(entity =>
            {
                entity.HasKey(e => e.EmpVacDetailId)
                    .HasName("PK_EmpVacationsDetails");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.EmpVac)
                    .WithMany(p => p.HrEmpVacationsDetails)
                    .HasForeignKey(d => d.EmpVacId)
                    .HasConstraintName("FK_Hr_EmpVacationsDetails_Hr_EmpVacation");
            });

            modelBuilder.Entity<HrEmployee>(entity =>
            {
                entity.Property(e => e.Address1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Address2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Attendance).HasComment("true full Time,false Part time");

                entity.Property(e => e.BankAccNo).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BankName).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Car).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ContractType).HasComment("true limited, false unlimited");

                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DrivingLicense).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Email).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EmpCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EtaxCustType).HasComment("Business  tax Reg Required,Person   NationalID not required,Foreigner  Name and ID  required");

                entity.Property(e => e.HealthInsId).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Idno).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MaritalStatus).HasComment("0 single,1 married,2 married and have kids");

                entity.Property(e => e.Name1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.PassportNo).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Phone1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Phone2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Phone3).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Qualification).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.SocialSecurityId).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Syndicate).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.SyndicateId).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.DepartMent)
                    .WithMany(p => p.HrEmployees)
                    .HasForeignKey(d => d.DepartMentId)
                    .HasConstraintName("FK_Hr_Employees_Hr_Departments");

                entity.HasOne(d => d.HrempGroup)
                    .WithMany(p => p.HrEmployees)
                    .HasForeignKey(d => d.HrempGroupId)
                    .HasConstraintName("FK_Hr_Employees_Hr_EmpGroups");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.HrEmployees)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_Hr_Employees_Hr_Jobs");

                entity.HasOne(d => d.PeriodTable)
                    .WithMany(p => p.HrEmployees)
                    .HasForeignKey(d => d.PeriodTableId)
                    .HasConstraintName("FK_Hr_Employees_Hr_PeriodsTables");

                entity.HasOne(d => d.Shift)
                    .WithMany(p => p.HrEmployees)
                    .HasForeignKey(d => d.ShiftId)
                    .HasConstraintName("FK_Hr_Employees_Hr_Shifts");
            });

            modelBuilder.Entity<HrEmpsSalaryTemp>(entity =>
            {
                entity.HasOne(d => d.SalaryTyp)
                    .WithMany(p => p.HrEmpsSalaryTemps)
                    .HasForeignKey(d => d.SalaryTypId)
                    .HasConstraintName("FK_Hr_EmpsSalaryTemp_Hr_SalaryTypes");
            });

            modelBuilder.Entity<HrJob>(entity =>
            {
                entity.Property(e => e.Add1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jcode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jdesc).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jduties).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jname1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jname2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jqualifications).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jresponsibilities).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<HrKpi>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<HrLeavPermissionRequest>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<HrLeavePermision>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<HrPeriodTableDetail>(entity =>
            {
                entity.Property(e => e.Name1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.SubPeriodCode).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.PeriodTable)
                    .WithMany(p => p.HrPeriodTableDetails)
                    .HasForeignKey(d => d.PeriodTableId)
                    .HasConstraintName("FK_Hr_PeriodTableDetail_Hr_PeriodsTables");
            });

            modelBuilder.Entity<HrPeriodTablePolicy>(entity =>
            {
                entity.HasOne(d => d.PeriodTable)
                    .WithMany(p => p.HrPeriodTablePolicies)
                    .HasForeignKey(d => d.PeriodTableId)
                    .HasConstraintName("FK_Hr_PeriodTablePolicy_Hr_PeriodsTables");
            });

            modelBuilder.Entity<HrPeriodTableVacation>(entity =>
            {
                entity.HasOne(d => d.PeriodTable)
                    .WithMany(p => p.HrPeriodTableVacations)
                    .HasForeignKey(d => d.PeriodTableId)
                    .HasConstraintName("FK_Hr_PeriodTableVacations_Hr_PeriodsTables");
            });

            modelBuilder.Entity<HrPeriodsTable>(entity =>
            {
                entity.Property(e => e.AcceptShftBeforDismis).HasComment("احتساب الورديه فى حالة خروج الموظف و رجوعه قبل ميعاد الانصراف مع تجاهل عدد الساعات المحققه");

                entity.Property(e => e.AcceptShiftHours).HasComment("اعتبار تحقيق الورديه بمجرد تحقيق عدد ساعات الورديه بغض النظر عن توقيت الحضور و الانصراف");

                entity.Property(e => e.AcceptShiftVacs).HasComment("قبول تعويض الورديات فى أيام الأجازات");

                entity.Property(e => e.CancelEarlyLeave).HasComment("الغاء الانصراف المبكر فى حالة تسجيل حضور ثانى فى نفس اليوم");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CutLateTimFromOverTime).HasComment("خصم التأخير و الانصراف المبكر من الوقت الاضافى لنفس اليوم");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Name1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.PeriodCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ShiftNotAcheived).HasComment("عدم احتساب الورديه فى حالة خروج الموظف فى منتصف اليوم قبل ميعاد الانصراف");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<HrRewardAndPenalty>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<HrSalaryCalcMethod>(entity =>
            {
                entity.Property(e => e.CalcMethodCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<HrSalaryIssueDetail>(entity =>
            {
                entity.HasOne(d => d.SalaryIssuDoc)
                    .WithMany(p => p.HrSalaryIssueDetails)
                    .HasForeignKey(d => d.SalaryIssuDocId)
                    .HasConstraintName("FK_Hr_SalaryIssueDetails_Hr_SalaryIssueDoc");
            });

            modelBuilder.Entity<HrSalaryIssueDistribution>(entity =>
            {
                entity.HasOne(d => d.SalaryIssuDoc)
                    .WithMany(p => p.HrSalaryIssueDistributions)
                    .HasForeignKey(d => d.SalaryIssuDocId)
                    .HasConstraintName("FK_Hr_SalaryIssueDistribution_Hr_SalaryIssueDoc");
            });

            modelBuilder.Entity<HrSalaryIssueDoc>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<HrSalaryType>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Name1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.SalaryCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<HrSegment>(entity =>
            {
                entity.HasOne(d => d.SalaryTyp)
                    .WithMany(p => p.HrSegments)
                    .HasForeignKey(d => d.SalaryTypId)
                    .HasConstraintName("FK_Hr_Segments_Hr_SalaryTypes");
            });

            modelBuilder.Entity<HrShift>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Day1Name1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Day1Name2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Day2Name1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Day2Name2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Day3Name1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Day3Name2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Day4Name1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Day4Name2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Day5Name1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Day5Name2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Day6Name1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Day6Name2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Day7Name1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Day7Name2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Name1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ShiftCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<HrTermination>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<HrVacationDoc>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<HrVacationEdit>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<HrVacationRequest>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<LaLand>(entity =>
            {
                entity.Property(e => e.BasicMemeber).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.LaLands)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_La_Lands_MS_Customer");
            });

            modelBuilder.Entity<LaPropSerial>(entity =>
            {
                entity.HasOne(d => d.CustMainNavigation)
                    .WithMany(p => p.LaPropSerials)
                    .HasForeignKey(d => d.CustMain)
                    .HasConstraintName("FK_La_PropSerial_MS_Customer");
            });

            modelBuilder.Entity<MsAdjustMent>(entity =>
            {
                entity.Property(e => e.AdjSourcType).HasComment("1 customer, 2 vendor");

                entity.Property(e => e.AdjSourcTypeId).HasComment("customer or vendor id");

                entity.Property(e => e.AdjType).HasComment("1 debit, 2 credit");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsBankAccount>(entity =>
            {
                entity.Property(e => e.AcounntNameA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.AcounntNameE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.AcountCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsBoxBank>(entity =>
            {
                entity.Property(e => e.BoxId).HasComment("0 Box ,1  Bank");

                entity.Property(e => e.BankFax).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BankMobile).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BankResposableName).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BankTel).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BoxCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Desca).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Desce).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsBank).HasComment("0 Box ; 1 Bank");

                entity.Property(e => e.KeeperName).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsBoxCurrency>(entity =>
            {
                entity.HasOne(d => d.Account)
                    .WithMany(p => p.MsBoxCurrencies)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_MS_BoxCurrency_Ms_BankAccount");

                entity.HasOne(d => d.Box)
                    .WithMany(p => p.MsBoxCurrencies)
                    .HasForeignKey(d => d.BoxId)
                    .HasConstraintName("FK_MS_BoxCurrency_MS_BoxBank");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.MsBoxCurrencies)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_MS_BoxCurrency_MS_Currency");
            });

            modelBuilder.Entity<MsBoxTransferDetail>(entity =>
            {
                entity.HasKey(e => e.BoxTranDetailId)
                    .HasName("PK_BoxTransferDetail");

                entity.HasOne(d => d.BoxTran)
                    .WithMany(p => p.MsBoxTransferDetails)
                    .HasForeignKey(d => d.BoxTranId)
                    .HasConstraintName("FK_MS_BoxTransferDetail_MS_BoxTransferNote");
            });

            modelBuilder.Entity<MsBoxTransferNote>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.StrCustm1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StrCustm2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StrCustm3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsBoxUser>(entity =>
            {
                entity.HasOne(d => d.Box)
                    .WithMany(p => p.MsBoxUsers)
                    .HasForeignKey(d => d.BoxId)
                    .HasConstraintName("FK_Ms_BoxUsers_MS_BoxBank");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MsBoxUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Ms_BoxUsers_G_Users");
            });

            modelBuilder.Entity<MsBusinessPartner>(entity =>
            {
                entity.Property(e => e.Address).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Address1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Address2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Address3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Company).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustId).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CustJob).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email4).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Fax).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PartnerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PartnerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PartnerDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PeriodType).HasComment("1 day, 2 month, 3 year");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Tel).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Tel2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel3).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel4).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel5).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.BsPartnerCat)
                    .WithMany(p => p.MsBusinessPartners)
                    .HasForeignKey(d => d.BsPartnerCatId)
                    .HasConstraintName("FK_Ms_BusinessPartners_Ms_BusinessPartnerCategory");

                entity.HasOne(d => d.BsPartnerType)
                    .WithMany(p => p.MsBusinessPartners)
                    .HasForeignKey(d => d.BsPartnerTypeId)
                    .HasConstraintName("FK_Ms_BusinessPartners_Ms_BusinessPartnerType");
            });

            modelBuilder.Entity<MsBusinessPartnerCategory>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PartnerCatCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PartnerCatDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PartnerCatDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsBusinessPartnerType>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PartnerTypeCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PartnerTypeDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PartnerTypeDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsCashTransactionDetail>(entity =>
            {
                entity.HasOne(d => d.Adjust)
                    .WithMany(p => p.MsCashTransactionDetails)
                    .HasForeignKey(d => d.AdjustId)
                    .HasConstraintName("FK_MS_CashTransactionDetail_Ms_AdjustMents");

                entity.HasOne(d => d.Jurnal)
                    .WithMany(p => p.MsCashTransactionDetails)
                    .HasForeignKey(d => d.JurnalId)
                    .HasConstraintName("FK_MS_CashTransactionDetail_Cal_JurnalEntry");

                entity.HasOne(d => d.Pay)
                    .WithMany(p => p.MsCashTransactionDetails)
                    .HasForeignKey(d => d.PayId)
                    .HasConstraintName("FK_MS_CashTransactionDetail_MS_PaymentNote");

                entity.HasOne(d => d.Rect)
                    .WithMany(p => p.MsCashTransactionDetails)
                    .HasForeignKey(d => d.RectId)
                    .HasConstraintName("FK_MS_CashTransactionDetail_Ms_ReceiptNote");
            });

            modelBuilder.Entity<MsCheqBook>(entity =>
            {
                entity.HasKey(e => e.CheqBookId)
                    .HasName("PK_Ms_Books");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.MsCheqBooks)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_Ms_Books_Hr_Employees");
            });

            modelBuilder.Entity<MsChequeTransfer>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<MsChequesOpenning>(entity =>
            {
                entity.Property(e => e.BoxCurrencyId).HasComment("if Paper In [bank account and chartof account], if PaperOut [should be from book] and book is related to bank account which is related to account in chart of accounts");

                entity.Property(e => e.ChequeNumber).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.HelpTableName).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsCompany>(entity =>
            {
                entity.HasKey(e => e.CompanyId)
                    .HasName("PK_Cal_Company");

                entity.Property(e => e.Address).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CompNameA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CompNameE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Fax1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Fax2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Fax3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Fax4).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.MailBox).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Mobile).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Mobile1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Mobile2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Mobile3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.OwnerName).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PostalCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Tel1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Tel2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Tel3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Tel4).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Website).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Website1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Website2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Website3).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsCurrency>(entity =>
            {
                entity.Property(e => e.CollectionCurrencyFractionName).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CollectionCurrencyName).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CollectionCurrencyTempName).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrancyNameFractionOverthree).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrancyNameOverthree).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrancyNameTempOver3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrenctType).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencyCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencyDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencyDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencySymbol).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DefualtCurrency).HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DoubleCurencyFractionname).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DoubleCurencyTempname).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DoubleCurencyname).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FractionalUnit).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.SingleCurencyFractionname).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.SingleCurencyTempname).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.SingleCurencyname).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsCurrencyCategory>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencyCategoryNameA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencyCategoryNameE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsCurrencyCategoryJoin>(entity =>
            {
                entity.HasOne(d => d.CurrencyCategory)
                    .WithMany(p => p.MsCurrencyCategoryJoins)
                    .HasForeignKey(d => d.CurrencyCategoryId)
                    .HasConstraintName("FK_Ms_CurrencyCategoryJoin_MS_CurrencyCategory");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.MsCurrencyCategoryJoins)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_Ms_CurrencyCategoryJoin_MS_Currency");
            });

            modelBuilder.Entity<MsCurrencyDailyRateChange>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsCurrencyRate>(entity =>
            {
                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.MsCurrencyRates)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_Ms_CurrencyRate_MS_Currency");
            });

            modelBuilder.Entity<MsCusromerUser>(entity =>
            {
                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.MsCusromerUsers)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Ms_CusromerUsers_MS_Customer");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MsCusromerUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Ms_CusromerUsers_G_Users");
            });

            modelBuilder.Entity<MsCustImg>(entity =>
            {
                entity.HasKey(e => e.CustImgId)
                    .HasName("PK_CustImgs");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.MsCustImgs)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Ms_CustImgs_MS_Customer");
            });

            modelBuilder.Entity<MsCustomer>(entity =>
            {
                entity.Property(e => e.Address).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Address1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Address2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Address3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Company).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustId).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CustJob).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email4).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.EtaxCustType).HasComment("Business  tax Reg Required,Person   NationalID not required,Foreigner  Name and ID  required");

                entity.Property(e => e.Fax).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.LastUpdateTime)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.PeriodType).HasComment("1 day, 2 month, 3 year");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Tel).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Tel2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel3).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel4).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel5).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.MsCustomers)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_MS_Customer_MS_Currency");

                entity.HasOne(d => d.CustomerCat)
                    .WithMany(p => p.MsCustomers)
                    .HasForeignKey(d => d.CustomerCatId)
                    .HasConstraintName("FK_MS_Customer_MS_CustomerCategory");

                entity.HasOne(d => d.CustomerType)
                    .WithMany(p => p.MsCustomers)
                    .HasForeignKey(d => d.CustomerTypeId)
                    .HasConstraintName("FK_MS_Customer_Ms_CustomerTypes");
            });

            modelBuilder.Entity<MsCustomerBranch>(entity =>
            {
                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.MsCustomerBranches)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Ms_CustomerBranches_MS_Customer");
            });

            modelBuilder.Entity<MsCustomerCategory>(entity =>
            {
                entity.Property(e => e.CatCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CatDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CatDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsCustomerContact>(entity =>
            {
                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.MsCustomerContacts)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Ms_CustomerContacts_MS_Customer");
            });

            modelBuilder.Entity<MsCustomerFollowUpType>(entity =>
            {
                entity.HasKey(e => e.FollowUpTypeId)
                    .HasName("PK_Ms_CustomerFollowUp");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsCustomerType>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerTypeCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerTypeDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerTypeDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsCustomersFollowUp>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.MsCustomersFollowUps)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Ms_CustomersFollowUp_MS_Customer");
            });

            modelBuilder.Entity<MsDeliverItemCard>(entity =>
            {
                entity.HasKey(e => e.DelivItemCardId)
                    .HasName("PK_DeliverItemCard");

                entity.Property(e => e.AccountId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.AccountTableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.IsBonus).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastUpdateTime)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.QtyIunit2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.Deliver)
                    .WithMany(p => p.MsDeliverItemCards)
                    .HasForeignKey(d => d.DeliverId)
                    .HasConstraintName("FK_Ms_DeliverItemCard_Ms_DeliverSalesInvoice");

                entity.HasOne(d => d.ItemCard)
                    .WithMany(p => p.MsDeliverItemCards)
                    .HasForeignKey(d => d.ItemCardId)
                    .HasConstraintName("FK_Ms_DeliverItemCard_MS_ItemCard");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.MsDeliverItemCards)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_Ms_DeliverItemCard_Ms_ItemUnit");
            });

            modelBuilder.Entity<MsDeliverSalesInvoice>(entity =>
            {
                entity.Property(e => e.AccountId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.AccountTableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DbtableId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsClosed).HasComment("True Closed ;  False  Not Closed");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Status).HasComment("0 Invoice ; 1 Customer ; 2 Return");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsDeliverSalesInvoiceExpense>(entity =>
            {
                entity.HasOne(d => d.Deliver)
                    .WithMany(p => p.MsDeliverSalesInvoiceExpenses)
                    .HasForeignKey(d => d.DeliverId)
                    .HasConstraintName("FK_Ms_DeliverSalesInvoiceExpenses_Ms_DeliverSalesInvoice");
            });

            modelBuilder.Entity<MsDeliverSalesInvoiceMultiAccount>(entity =>
            {
                entity.Property(e => e.AccountId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.AccountTableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableName).HasComment("to attach any document in database to receiptnote");

                entity.HasOne(d => d.Deliver)
                    .WithMany(p => p.MsDeliverSalesInvoiceMultiAccounts)
                    .HasForeignKey(d => d.DeliverId)
                    .HasConstraintName("FK_Ms_DeliverSalesInvoiceMultiAccounts_Ms_DeliverSalesInvoice");
            });

            modelBuilder.Entity<MsDescription>(entity =>
            {
                entity.Property(e => e.Name1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name2).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<MsExpense>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ExpensesCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ExpensesDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ExpensesDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ExpensesType).HasComment("0 Sales , 1 Purchase , 2 Others");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsGaCapacity>(entity =>
            {
                entity.HasKey(e => e.CapcityId)
                    .HasName("PK_Ms_Capacity");
            });

            modelBuilder.Entity<MsGaLetterExportDetail>(entity =>
            {
                entity.HasOne(d => d.LetterExport)
                    .WithMany(p => p.MsGaLetterExportDetails)
                    .HasForeignKey(d => d.LetterExportId)
                    .HasConstraintName("FK_MsGA_LetterExportDetail_MsGA_LetterExport");
            });

            modelBuilder.Entity<MsGaLetterFayumDetail>(entity =>
            {
                entity.HasOne(d => d.LetterFayum)
                    .WithMany(p => p.MsGaLetterFayumDetails)
                    .HasForeignKey(d => d.LetterFayumId)
                    .HasConstraintName("FK_MsGA_LetterFayumDetail_MsGA_LetterFayum");
            });

            modelBuilder.Entity<MsGaLetterNormalDetail>(entity =>
            {
                entity.HasOne(d => d.LetterNorm)
                    .WithMany(p => p.MsGaLetterNormalDetails)
                    .HasForeignKey(d => d.LetterNormId)
                    .HasConstraintName("FK_MsGA_LetterNormalDetail_MsGA_LetterNormal");
            });

            modelBuilder.Entity<MsGaMachineType>(entity =>
            {
                entity.HasKey(e => e.MachineId)
                    .HasName("PK_Ms_type");
            });

            modelBuilder.Entity<MsGaMoror>(entity =>
            {
                entity.HasKey(e => e.MororId)
                    .HasName("PK_GAV_Moror");
            });

            modelBuilder.Entity<MsGaMotorSndetail>(entity =>
            {
                entity.HasKey(e => e.MotorSearialId)
                    .HasName("PK_Ms_MotorSearial");

                entity.Property(e => e.BasicSaleType)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 Cash ; 1 Installment");

                entity.HasOne(d => d.LetterFayum)
                    .WithMany(p => p.MsGaMotorSndetails)
                    .HasForeignKey(d => d.LetterFayumId)
                    .HasConstraintName("FK_MsGA_MotorSNDetail_MsGA_LetterFayum");

                entity.HasOne(d => d.LetterNorm)
                    .WithMany(p => p.MsGaMotorSndetails)
                    .HasForeignKey(d => d.LetterNormId)
                    .HasConstraintName("FK_MsGA_MotorSNDetail_MsGA_LetterNormal");

                entity.HasOne(d => d.MotorDoc)
                    .WithMany(p => p.MsGaMotorSndetails)
                    .HasForeignKey(d => d.MotorDocId)
                    .HasConstraintName("FK_MsGA_MotorSNDetail_MsGA_MotorSN");
            });

            modelBuilder.Entity<MsGaPeriodicBook>(entity =>
            {
                entity.Property(e => e.FirstLetter).IsFixedLength();

                entity.Property(e => e.LastLetter).IsFixedLength();

                entity.Property(e => e.PreFix).IsFixedLength();
            });

            modelBuilder.Entity<MsGaPeriodicBookDetail>(entity =>
            {
                entity.Property(e => e.BasicSaleType)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 Cash ; 1 Installment");

                entity.HasOne(d => d.LetterNorm)
                    .WithMany(p => p.MsGaPeriodicBookDetails)
                    .HasForeignKey(d => d.LetterNormId)
                    .HasConstraintName("FK_MsGA_PeriodicBookDetail_MsGA_LetterNormal");

                entity.HasOne(d => d.PeriodicBook)
                    .WithMany(p => p.MsGaPeriodicBookDetails)
                    .HasForeignKey(d => d.PeriodicBookId)
                    .HasConstraintName("FK_MsGA_PeriodicBookDetail_MsGA_PeriodicBook");
            });

            modelBuilder.Entity<MsGaShipmentDetail>(entity =>
            {
                entity.Property(e => e.BasicSaleType)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 Cash ; 1 Installment");

                entity.HasOne(d => d.LetterExport)
                    .WithMany(p => p.MsGaShipmentDetails)
                    .HasForeignKey(d => d.LetterExportId)
                    .HasConstraintName("FK_MsGA_ShipmentDetail_MsGA_LetterExport");

                entity.HasOne(d => d.ShipMent)
                    .WithMany(p => p.MsGaShipmentDetails)
                    .HasForeignKey(d => d.ShipMentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MsGA_ShipmentDetail_MsGA_Shipment");
            });

            modelBuilder.Entity<MsItemAlternative>(entity =>
            {
                entity.HasOne(d => d.ItemCard)
                    .WithMany(p => p.MsItemAlternatives)
                    .HasForeignKey(d => d.ItemCardId)
                    .HasConstraintName("FK_MS_ItemAlternatives_MS_ItemCard");
            });

            modelBuilder.Entity<MsItemCard>(entity =>
            {
                entity.Property(e => e.AnimalClass).HasComment("1 animal, 2 food, 3 medicin");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ItemType).HasComment("1  Finished product,2 Material,3 non stock Item,4 Manufactured,5 vehicle");

                entity.Property(e => e.LastUpdateTime)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.OfferDesc).HasComment("1 day, 2 month, 3 year");

                entity.Property(e => e.PeriodType).HasComment("1 day, 2 month, 3 year");

                entity.Property(e => e.QtyInNotebook).HasDefaultValueSql("((0))");

                entity.Property(e => e.QtyPartiation).HasDefaultValueSql("((0))");

                entity.Property(e => e.Separator).IsFixedLength();

                entity.Property(e => e.StrCustm5).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Tax1Style).HasComment("0 Percent , 1 value , 2 Without");

                entity.Property(e => e.Tax2Style).HasComment("0 Percent , 1 value , 2 Without");

                entity.Property(e => e.Tax3Style).HasComment("0 Percent , 1 value , 2 Without");

                entity.Property(e => e.WarantyPeriodType).HasComment("1 day,2 week, 3 month, 4 year");

                entity.HasOne(d => d.ItemCategory)
                    .WithMany(p => p.MsItemCards)
                    .HasForeignKey(d => d.ItemCategoryId)
                    .HasConstraintName("FK_MS_ItemCard_MS_ItemCategory");
            });

            modelBuilder.Entity<MsItemCardOffer>(entity =>
            {
                entity.HasOne(d => d.ItemCard)
                    .WithMany(p => p.MsItemCardOffers)
                    .HasForeignKey(d => d.ItemCardId)
                    .HasConstraintName("FK_Ms_ItemCardOffers_MS_ItemCard");
            });

            modelBuilder.Entity<MsItemCategory>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ItemCatCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ItemCatDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ItemCatDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsItemCollection>(entity =>
            {
                entity.HasOne(d => d.ItemCard)
                    .WithMany(p => p.MsItemCollections)
                    .HasForeignKey(d => d.ItemCardId)
                    .HasConstraintName("FK_Ms_ItemCollection_MS_ItemCard");
            });

            modelBuilder.Entity<MsItemCostHistory>(entity =>
            {
                entity.HasKey(e => e.ItemCostId)
                    .HasName("PK_MS_ItemCostLog");
            });

            modelBuilder.Entity<MsItemImage>(entity =>
            {
                entity.HasOne(d => d.ItemCard)
                    .WithMany(p => p.MsItemImages)
                    .HasForeignKey(d => d.ItemCardId)
                    .HasConstraintName("FK_MS_ItemImages_MS_ItemCard");
            });

            modelBuilder.Entity<MsItemPartition>(entity =>
            {
                entity.Property(e => e.QtyInNotebook).HasDefaultValueSql("((0))");

                entity.Property(e => e.QtyIunit2Notebook).HasDefaultValueSql("((0))");

                entity.Property(e => e.QtyIunit2Partiation).HasDefaultValueSql("((0))");

                entity.Property(e => e.QtyPartiation).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ttype)
                    .IsFixedLength()
                    .HasComment("i for inserted, u for updated")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tversion).HasComment("number of updates on the table");

                entity.HasOne(d => d.ItemCard)
                    .WithMany(p => p.MsItemPartitions)
                    .HasForeignKey(d => d.ItemCardId)
                    .HasConstraintName("FK_Ms_ItemPartition_MS_ItemCard");

                entity.HasOne(d => d.StorePart)
                    .WithMany(p => p.MsItemPartitions)
                    .HasForeignKey(d => d.StorePartId)
                    .HasConstraintName("FK_Ms_ItemPartition_MS_Partition");
            });

            modelBuilder.Entity<MsItemSerial>(entity =>
            {
                entity.HasKey(e => e.ItemSerialId)
                    .HasName("PK_MS_ItemSerials_1");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.DelivItemCard)
                    .WithMany(p => p.MsItemSerials)
                    .HasForeignKey(d => d.DelivItemCardId)
                    .HasConstraintName("FK_MS_ItemSerials_Ms_DeliverItemCard");

                entity.HasOne(d => d.InvItemCard)
                    .WithMany(p => p.MsItemSerials)
                    .HasForeignKey(d => d.InvItemCardId)
                    .HasConstraintName("FK_MS_ItemSerials_Ms_SalesInvoiceItemCard");

                entity.HasOne(d => d.OrderDetailItemCard)
                    .WithMany(p => p.MsItemSerials)
                    .HasForeignKey(d => d.OrderDetailItemCardId)
                    .HasConstraintName("FK_MS_ItemSerials_Ms_SalesOrderItemCard");

                entity.HasOne(d => d.PurInvItemCard)
                    .WithMany(p => p.MsItemSerials)
                    .HasForeignKey(d => d.PurInvItemCardId)
                    .HasConstraintName("FK_MS_ItemSerials_MS_PurchaseInvoiceItemCard");

                entity.HasOne(d => d.RetItemCard)
                    .WithMany(p => p.MsItemSerials)
                    .HasForeignKey(d => d.RetItemCardId)
                    .HasConstraintName("FK_MS_ItemSerials_MS_ReturnSalesItemCard");

                entity.HasOne(d => d.RetPurchItemCard)
                    .WithMany(p => p.MsItemSerials)
                    .HasForeignKey(d => d.RetPurchItemCardId)
                    .HasConstraintName("FK_MS_ItemSerials_MS_ReturnPurchaseItem");

                entity.HasOne(d => d.StockAdjustItem)
                    .WithMany(p => p.MsItemSerials)
                    .HasForeignKey(d => d.StockAdjustItemId)
                    .HasConstraintName("FK_MS_ItemSerials_Ms_ItemStockAdjustmentDetail");

                entity.HasOne(d => d.StockRecItemCard)
                    .WithMany(p => p.MsItemSerials)
                    .HasForeignKey(d => d.StockRecItemCardId)
                    .HasConstraintName("FK_MS_ItemSerials_MS_StockReceiptItemCard");

                entity.HasOne(d => d.TrItenCard)
                    .WithMany(p => p.MsItemSerials)
                    .HasForeignKey(d => d.TrItenCardId)
                    .HasConstraintName("FK_MS_ItemSerials_MS_StockTranItemCard");

                entity.HasOne(d => d.TranReqItemCard)
                    .WithMany(p => p.MsItemSerials)
                    .HasForeignKey(d => d.TranReqItemCardId)
                    .HasConstraintName("FK_MS_ItemSerials_Ms_StockTranItemCardReq");
            });

            modelBuilder.Entity<MsItemStartQty>(entity =>
            {
                entity.Property(e => e.QtyInNotebook).HasDefaultValueSql("((0))");

                entity.Property(e => e.QtyPartiation).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.ItemCard)
                    .WithMany(p => p.MsItemStartQties)
                    .HasForeignKey(d => d.ItemCardId)
                    .HasConstraintName("FK_Ms_ItemStartQty_MS_ItemCard");
            });

            modelBuilder.Entity<MsItemStockAdjustment>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Name2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsItemStockAdjustmentDetail>(entity =>
            {
                entity.Property(e => e.QtyIunit2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.ItemCard)
                    .WithMany(p => p.MsItemStockAdjustmentDetails)
                    .HasForeignKey(d => d.ItemCardId)
                    .HasConstraintName("FK_Ms_ItemStockAdjustmentDetail_MS_ItemCard");

                entity.HasOne(d => d.StockAdjust)
                    .WithMany(p => p.MsItemStockAdjustmentDetails)
                    .HasForeignKey(d => d.StockAdjustId)
                    .HasConstraintName("FK_Ms_ItemStockAdjustmentDetail_Ms_ItemStockAdjustment");
            });

            modelBuilder.Entity<MsItemUnit>(entity =>
            {
                entity.Property(e => e.BarCode1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode10).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode11).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode12).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode13).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode14).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode15).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode3).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode4).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode5).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode6).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode7).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode8).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode9).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.BasUnit)
                    .WithMany(p => p.MsItemUnits)
                    .HasForeignKey(d => d.BasUnitId)
                    .HasConstraintName("FK_Ms_ItemUnit_Prod_BasicUnits");

                entity.HasOne(d => d.ItemCard)
                    .WithMany(p => p.MsItemUnits)
                    .HasForeignKey(d => d.ItemCardId)
                    .HasConstraintName("FK_Ms_ItemUnit_MS_ItemCard");
            });

            modelBuilder.Entity<MsItemUnitPackingJoin>(entity =>
            {
                entity.HasOne(d => d.PackSize)
                    .WithMany(p => p.MsItemUnitPackingJoins)
                    .HasForeignKey(d => d.PackSizeId)
                    .HasConstraintName("FK_Ms_ItemUnitPackingJoin_Cod_PackingSize");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.MsItemUnitPackingJoins)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_Ms_ItemUnitPackingJoin_Ms_ItemUnit");
            });

            modelBuilder.Entity<MsItemVendor>(entity =>
            {
                entity.Property(e => e.Price1).IsFixedLength();

                entity.Property(e => e.Price10).IsFixedLength();

                entity.Property(e => e.Price2).IsFixedLength();

                entity.Property(e => e.Price3).IsFixedLength();

                entity.Property(e => e.Price4).IsFixedLength();

                entity.Property(e => e.Price5).IsFixedLength();

                entity.Property(e => e.Price6).IsFixedLength();

                entity.Property(e => e.Price7).IsFixedLength();

                entity.Property(e => e.Price8).IsFixedLength();

                entity.Property(e => e.Price9).IsFixedLength();

                entity.Property(e => e.Quantity1).IsFixedLength();

                entity.Property(e => e.Quantity10).IsFixedLength();

                entity.Property(e => e.Quantity2).IsFixedLength();

                entity.Property(e => e.Quantity3).IsFixedLength();

                entity.Property(e => e.Quantity4).IsFixedLength();

                entity.Property(e => e.Quantity5).IsFixedLength();

                entity.Property(e => e.Quantity6).IsFixedLength();

                entity.Property(e => e.Quantity7).IsFixedLength();

                entity.Property(e => e.Quantity8).IsFixedLength();

                entity.Property(e => e.Quantity9).IsFixedLength();

                entity.HasOne(d => d.ItemCard)
                    .WithMany(p => p.MsItemVendors)
                    .HasForeignKey(d => d.ItemCardId)
                    .HasConstraintName("FK_MS_ItemVendors_MS_ItemCard");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.MsItemVendors)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_MS_ItemVendors_MS_Vendor");
            });

            modelBuilder.Entity<MsJewelryPricing>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Kirat).HasComment("18,21,24");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsKeeperBank>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<MsKeeperBankDetail>(entity =>
            {
                entity.HasOne(d => d.Keeper)
                    .WithMany(p => p.MsKeeperBankDetails)
                    .HasForeignKey(d => d.KeeperId)
                    .HasConstraintName("FK_Ms_KeeperBankDetail_Ms_KeeperBank");
            });

            modelBuilder.Entity<MsLetterOfGuarantee>(entity =>
            {
                entity.Property(e => e.AccountId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.AccountTableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DbtableId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsLetterOfGuaranteeCategory>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsLetterOfGuaranteeStatus>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsLetterOfGuaranteeTran>(entity =>
            {
                entity.Property(e => e.AccountId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.AccountTableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DbtableId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ValuEffect).HasComment("1 Uprais,2 Decreas, else none");

                entity.HasOne(d => d.LetOfGrntee)
                    .WithMany(p => p.MsLetterOfGuaranteeTrans)
                    .HasForeignKey(d => d.LetOfGrnteeId)
                    .HasConstraintName("FK_Ms_LetterOfGuaranteeTrans_Ms_LetterOfGuarantee");
            });

            modelBuilder.Entity<MsLetterOfGuaranteeType>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsLotNumberConfiguration>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Part1DateType).HasComment("1 day,2 week,3 month,4 year");

                entity.Property(e => e.Part1type).HasComment("1 fixed,2 manual,3 date");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsLotNumberExpiry>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PeriodType).HasComment("1 day, 2 month, 3 year");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks4).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks5).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks6).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks7).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsPartition>(entity =>
            {
                entity.Property(e => e.Address).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Fax).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.PartCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PartDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PartDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreKeeper).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.StrCustm2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StrCustm3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StrCustm4).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StrCustm5).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StrCustm6).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Tel).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.MsPartitions)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_MS_Partition_MS_Stores");
            });

            modelBuilder.Entity<MsPaymentNote>(entity =>
            {
                entity.Property(e => e.BankAccNumber).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CheckNumber).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CheckType).HasComment("0 Paid ; 1 Back ; 2  Transfer;");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Equation).IsSparse();

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastUpdateTime)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.OtherSource).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RectSourceType).HasComment(" 1  Customer ; 2 vendor ; 3  Other");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TranType).HasComment("0  Cash ; 1  Check");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.Box)
                    .WithMany(p => p.MsPaymentNotes)
                    .HasForeignKey(d => d.BoxId)
                    .HasConstraintName("FK_MS_PaymentNote_MS_BoxBank");

                entity.HasOne(d => d.PurInv)
                    .WithMany(p => p.MsPaymentNotes)
                    .HasForeignKey(d => d.PurInvId)
                    .HasConstraintName("FK_MS_PaymentNote_MS_PurchasInvoice");

                entity.HasOne(d => d.RetSale)
                    .WithMany(p => p.MsPaymentNotes)
                    .HasForeignKey(d => d.RetSaleId)
                    .HasConstraintName("FK_MS_PaymentNote_MS_ReturnSales");
            });

            modelBuilder.Entity<MsPaymentNoteCurrency>(entity =>
            {
                entity.HasOne(d => d.Pay)
                    .WithMany(p => p.MsPaymentNoteCurrencies)
                    .HasForeignKey(d => d.PayId)
                    .HasConstraintName("FK_Ms_PaymentNoteCurrencies_MS_PaymentNote");
            });

            modelBuilder.Entity<MsPaymentNoteItem>(entity =>
            {
                entity.HasOne(d => d.Pay)
                    .WithMany(p => p.MsPaymentNoteItems)
                    .HasForeignKey(d => d.PayId)
                    .HasConstraintName("FK_Ms_PaymentNoteItems_MS_PaymentNote");
            });

            modelBuilder.Entity<MsPettyCashDetail>(entity =>
            {
                entity.Property(e => e.Remark1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remark2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remark3).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.Pettycash)
                    .WithMany(p => p.MsPettyCashDetails)
                    .HasForeignKey(d => d.PettycashId)
                    .HasConstraintName("FK_MS_PettyCashDetails_MS_Pettycash");
            });

            modelBuilder.Entity<MsPettyPaymentJoin>(entity =>
            {
                entity.HasOne(d => d.Pay)
                    .WithMany(p => p.MsPettyPaymentJoins)
                    .HasForeignKey(d => d.PayId)
                    .HasConstraintName("FK_Ms_PettyPaymentJoin_MS_PaymentNote");

                entity.HasOne(d => d.Pettycash)
                    .WithMany(p => p.MsPettyPaymentJoins)
                    .HasForeignKey(d => d.PettycashId)
                    .HasConstraintName("FK_Ms_PettyPaymentJoin_MS_Pettycash");
            });

            modelBuilder.Entity<MsPettycash>(entity =>
            {
                entity.Property(e => e.AccountId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.AccountTableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DbtableId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.RectSourceType).HasComment(" 1  Customer ; 2 vendor ; 3  Other");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsPosShift>(entity =>
            {
                entity.Property(e => e.PosShiftLogId).ValueGeneratedNever();

                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsPosSpecialItem>(entity =>
            {
                entity.Property(e => e.IsBonus).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsPurchInvVehicleJobOrderJoin>(entity =>
            {
                entity.HasOne(d => d.PurInv)
                    .WithMany(p => p.MsPurchInvVehicleJobOrderJoins)
                    .HasForeignKey(d => d.PurInvId)
                    .HasConstraintName("FK_Ms_PurchInvVehicleJobOrderJoin_MS_PurchasInvoice");

                entity.HasOne(d => d.Vjorder)
                    .WithMany(p => p.MsPurchInvVehicleJobOrderJoins)
                    .HasForeignKey(d => d.VjorderId)
                    .HasConstraintName("FK_Ms_PurchInvVehicleJobOrderJoin_Sr_VehicleJobOrder");
            });

            modelBuilder.Entity<MsPurchOrderDetail>(entity =>
            {
                entity.Property(e => e.QtyIunit2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.ItemCard)
                    .WithMany(p => p.MsPurchOrderDetails)
                    .HasForeignKey(d => d.ItemCardId)
                    .HasConstraintName("FK_MS_PurchOrderDetail_MS_ItemCard");

                entity.HasOne(d => d.PurOrder)
                    .WithMany(p => p.MsPurchOrderDetails)
                    .HasForeignKey(d => d.PurOrderId)
                    .HasConstraintName("FK_MS_PurchOrderDetail_Ms_PurchasOrder");
            });

            modelBuilder.Entity<MsPurchOrderReqDetail>(entity =>
            {
                entity.Property(e => e.QtyIunit2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.PurOrderReq)
                    .WithMany(p => p.MsPurchOrderReqDetails)
                    .HasForeignKey(d => d.PurOrderReqId)
                    .HasConstraintName("FK_MS_PurchOrderReqDetail_Ms_PurchasOrderRequest");
            });

            modelBuilder.Entity<MsPurchasInvoice>(entity =>
            {
                entity.Property(e => e.AccountId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.AccountTableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DbtableId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.InvDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.InvDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.InvoiceType).HasComment("0  Cash ; 1  Due ");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastUpdateTime)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.PurOrder)
                    .WithMany(p => p.MsPurchasInvoices)
                    .HasForeignKey(d => d.PurOrderId)
                    .HasConstraintName("FK_MS_PurchasInvoice_Ms_PurchasOrder");

                entity.HasOne(d => d.TaxesId1Navigation)
                    .WithMany(p => p.MsPurchasInvoices)
                    .HasForeignKey(d => d.TaxesId1)
                    .HasConstraintName("FK_MS_PurchasInvoice_MS_Taxes");
            });

            modelBuilder.Entity<MsPurchasInvoiceCurrency>(entity =>
            {
                entity.HasOne(d => d.PurInv)
                    .WithMany(p => p.MsPurchasInvoiceCurrencies)
                    .HasForeignKey(d => d.PurInvId)
                    .HasConstraintName("FK_MS_PurchasInvoiceCurrencies_MS_PurchasInvoice");
            });

            modelBuilder.Entity<MsPurchasInvoiceMultiAccount>(entity =>
            {
                entity.Property(e => e.AccountId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.AccountTableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableName).HasComment("to attach any document in database to receiptnote");

                entity.HasOne(d => d.PurInv)
                    .WithMany(p => p.MsPurchasInvoiceMultiAccounts)
                    .HasForeignKey(d => d.PurInvId)
                    .HasConstraintName("FK_MS_PurchasInvoiceMultiAccounts_MS_PurchasInvoice");
            });

            modelBuilder.Entity<MsPurchasOrder>(entity =>
            {
                entity.Property(e => e.AccountId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.AccountTableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.DbtableId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.InvoiceType).HasComment("0  Cash ; 1  Due ");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MsPurchasOrderRequest>(entity =>
            {
                entity.Property(e => e.AccountId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.AccountTableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.DbtableId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.InvoiceType).HasComment("0  Cash ; 1  Due ");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MsPurchaseInvoiceCostReceived>(entity =>
            {
                entity.HasOne(d => d.PurInv)
                    .WithMany(p => p.MsPurchaseInvoiceCostReceiveds)
                    .HasForeignKey(d => d.PurInvId)
                    .HasConstraintName("FK_Ms_PurchaseInvoiceCostReceived_MS_PurchasInvoice");
            });

            modelBuilder.Entity<MsPurchaseInvoiceExpense>(entity =>
            {
                entity.HasOne(d => d.PurInv)
                    .WithMany(p => p.MsPurchaseInvoiceExpenses)
                    .HasForeignKey(d => d.PurInvId)
                    .HasConstraintName("FK_MS_PurchaseInvoiceExpenses_MS_PurchasInvoice");
            });

            modelBuilder.Entity<MsPurchaseInvoiceItemCard>(entity =>
            {
                entity.Property(e => e.AccountId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.AccountTableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.LastUpdateTime)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.QtyIunit2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.ItemCard)
                    .WithMany(p => p.MsPurchaseInvoiceItemCards)
                    .HasForeignKey(d => d.ItemCardId)
                    .HasConstraintName("FK_MS_PurchaseInvoiceItemCard_MS_ItemCard");

                entity.HasOne(d => d.PurInv)
                    .WithMany(p => p.MsPurchaseInvoiceItemCards)
                    .HasForeignKey(d => d.PurInvId)
                    .HasConstraintName("FK_MS_PurchaseInvoiceItemCard_MS_PurchasInvoice");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.MsPurchaseInvoiceItemCards)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_MS_PurchaseInvoiceItemCard_Ms_ItemUnit");
            });

            modelBuilder.Entity<MsReceiptNote>(entity =>
            {
                entity.Property(e => e.AccountId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.AccountTableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.BankAccNumber).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CheckNumber).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DbtableId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Equation).IsSparse();

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastUpdateTime)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.OtherSource).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StrCustm1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StrCustm2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.Box)
                    .WithMany(p => p.MsReceiptNotes)
                    .HasForeignKey(d => d.BoxId)
                    .HasConstraintName("FK_Ms_ReceiptNote_MS_BoxBank");

                entity.HasOne(d => d.Inv)
                    .WithMany(p => p.MsReceiptNotes)
                    .HasForeignKey(d => d.InvId)
                    .HasConstraintName("FK_Ms_ReceiptNote_Ms_SalesInvoice");

                entity.HasOne(d => d.RetPur)
                    .WithMany(p => p.MsReceiptNotes)
                    .HasForeignKey(d => d.RetPurId)
                    .HasConstraintName("FK_Ms_ReceiptNote_MS_ReturnPurchase");
            });

            modelBuilder.Entity<MsReceiptNoteCurrency>(entity =>
            {
                entity.HasOne(d => d.Rect)
                    .WithMany(p => p.MsReceiptNoteCurrencies)
                    .HasForeignKey(d => d.RectId)
                    .HasConstraintName("FK_Ms_ReceiptNoteCurrencies_Ms_ReceiptNote");
            });

            modelBuilder.Entity<MsReturnPurchase>(entity =>
            {
                entity.Property(e => e.AccountId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.AccountTableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DbtableId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.InvoiceType).HasComment("0 Cash ; 1 Due ;");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastUpdateTime)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RetDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RetDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ReturnType)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0  Invoice ; 1 customer");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsReturnPurchaseCurrency>(entity =>
            {
                entity.HasOne(d => d.RetPurch)
                    .WithMany(p => p.MsReturnPurchaseCurrencies)
                    .HasForeignKey(d => d.RetPurchId)
                    .HasConstraintName("FK_MS_ReturnPurchaseCurrencies_MS_ReturnPurchase");
            });

            modelBuilder.Entity<MsReturnPurchaseExpense>(entity =>
            {
                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.RetPurch)
                    .WithMany(p => p.MsReturnPurchaseExpenses)
                    .HasForeignKey(d => d.RetPurchId)
                    .HasConstraintName("FK_Ms_ReturnPurchaseExpenses_MS_ReturnPurchase");
            });

            modelBuilder.Entity<MsReturnPurchaseItem>(entity =>
            {
                entity.Property(e => e.AccountId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.AccountTableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.LastUpdateTime)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.QtyIunit2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.ItemCard)
                    .WithMany(p => p.MsReturnPurchaseItems)
                    .HasForeignKey(d => d.ItemCardId)
                    .HasConstraintName("FK_MS_ReturnPurchaseItem_MS_ItemCard");

                entity.HasOne(d => d.RetPurch)
                    .WithMany(p => p.MsReturnPurchaseItems)
                    .HasForeignKey(d => d.RetPurchId)
                    .HasConstraintName("FK_MS_ReturnPurchaseItem_MS_ReturnPurchase");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.MsReturnPurchaseItems)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_MS_ReturnPurchaseItem_Ms_ItemUnit");
            });

            modelBuilder.Entity<MsReturnPurchaseMultiAccount>(entity =>
            {
                entity.Property(e => e.AccountId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.AccountTableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableName).HasComment("to attach any document in database to receiptnote");

                entity.HasOne(d => d.RetPurch)
                    .WithMany(p => p.MsReturnPurchaseMultiAccounts)
                    .HasForeignKey(d => d.RetPurchId)
                    .HasConstraintName("FK_MS_ReturnPurchaseMultiAccounts_MS_ReturnPurchase");
            });

            modelBuilder.Entity<MsReturnSale>(entity =>
            {
                entity.Property(e => e.AccountId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.AccountTableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.Commision).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DbtableId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.InvoiceType).HasComment("0 Cash ; 1 Due ; Customer Account");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastUpdateTime)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RetDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RetDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ReturnType).HasComment("0  Invoice ; 1  Customer");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsReturnSalesCurrency>(entity =>
            {
                entity.HasOne(d => d.RetSale)
                    .WithMany(p => p.MsReturnSalesCurrencies)
                    .HasForeignKey(d => d.RetSaleId)
                    .HasConstraintName("FK_MS_ReturnSalesCurrencies_MS_ReturnSales");
            });

            modelBuilder.Entity<MsReturnSalesExpense>(entity =>
            {
                entity.HasOne(d => d.RetSale)
                    .WithMany(p => p.MsReturnSalesExpenses)
                    .HasForeignKey(d => d.RetSaleId)
                    .HasConstraintName("FK_Ms_ReturnSalesExpenses_MS_ReturnSales");
            });

            modelBuilder.Entity<MsReturnSalesItemCard>(entity =>
            {
                entity.Property(e => e.AccountId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.AccountTableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.IsBonus).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastUpdateTime)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.QtyIunit2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.ItemCard)
                    .WithMany(p => p.MsReturnSalesItemCards)
                    .HasForeignKey(d => d.ItemCardId)
                    .HasConstraintName("FK_MS_ReturnSalesItemCard_MS_ItemCard");

                entity.HasOne(d => d.RetSale)
                    .WithMany(p => p.MsReturnSalesItemCards)
                    .HasForeignKey(d => d.RetSaleId)
                    .HasConstraintName("FK_MS_ReturnSalesItemCard_MS_ReturnSales");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.MsReturnSalesItemCards)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_MS_ReturnSalesItemCard_Ms_ItemUnit");
            });

            modelBuilder.Entity<MsReturnSalesMultiAccount>(entity =>
            {
                entity.Property(e => e.AccountId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.AccountTableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableName).HasComment("to attach any document in database to receiptnote");

                entity.HasOne(d => d.RetSale)
                    .WithMany(p => p.MsReturnSalesMultiAccounts)
                    .HasForeignKey(d => d.RetSaleId)
                    .HasConstraintName("FK_MS_ReturnSalesMultiAccounts_MS_ReturnSales");
            });

            modelBuilder.Entity<MsSalesInvJobOrderJoin>(entity =>
            {
                entity.HasOne(d => d.Inv)
                    .WithMany(p => p.MsSalesInvJobOrderJoins)
                    .HasForeignKey(d => d.InvId)
                    .HasConstraintName("FK_Ms_SalesInvJobOrderJoin_Ms_SalesInvoice");

                entity.HasOne(d => d.JobOrder)
                    .WithMany(p => p.MsSalesInvJobOrderJoins)
                    .HasForeignKey(d => d.JobOrderId)
                    .HasConstraintName("FK_Ms_SalesInvJobOrderJoin_Prod_JobOrder");
            });

            modelBuilder.Entity<MsSalesInvVehiclJobOrderJoin>(entity =>
            {
                entity.HasOne(d => d.Inv)
                    .WithMany(p => p.MsSalesInvVehiclJobOrderJoins)
                    .HasForeignKey(d => d.InvId)
                    .HasConstraintName("FK_Ms_SalesInvVehiclJobOrderJoin_Ms_SalesInvoice");

                entity.HasOne(d => d.Vjorder)
                    .WithMany(p => p.MsSalesInvVehiclJobOrderJoins)
                    .HasForeignKey(d => d.VjorderId)
                    .HasConstraintName("FK_Ms_SalesInvVehiclJobOrderJoin_Sr_VehicleJobOrder");
            });

            modelBuilder.Entity<MsSalesInvoice>(entity =>
            {
                entity.Property(e => e.AccountId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.AccountTableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DbtableId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.InvDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.InvDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.InvoiceType).HasComment("0  Cash ; 1  Due ");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastUpdateTime)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.SalesOffer)
                    .WithMany(p => p.MsSalesInvoices)
                    .HasForeignKey(d => d.SalesOfferId)
                    .HasConstraintName("FK_Ms_SalesInvoice_Ms_SalesOffer");
            });

            modelBuilder.Entity<MsSalesInvoiceCostDeliver>(entity =>
            {
                entity.HasOne(d => d.Inv)
                    .WithMany(p => p.MsSalesInvoiceCostDelivers)
                    .HasForeignKey(d => d.InvId)
                    .HasConstraintName("FK_Ms_SalesInvoiceCostDeliver_Ms_SalesInvoice");
            });

            modelBuilder.Entity<MsSalesInvoiceCurrency>(entity =>
            {
                entity.HasOne(d => d.Inv)
                    .WithMany(p => p.MsSalesInvoiceCurrencies)
                    .HasForeignKey(d => d.InvId)
                    .HasConstraintName("FK_Ms_SalesInvoiceCurrencies_Ms_SalesInvoice");
            });

            modelBuilder.Entity<MsSalesInvoiceExpense>(entity =>
            {
                entity.HasOne(d => d.Inv)
                    .WithMany(p => p.MsSalesInvoiceExpenses)
                    .HasForeignKey(d => d.InvId)
                    .HasConstraintName("FK_Ms_SalesInvoiceExpenses_Ms_SalesInvoice");
            });

            modelBuilder.Entity<MsSalesInvoiceItemCard>(entity =>
            {
                entity.HasKey(e => e.InvItemCardId)
                    .HasName("PK_InvoiceItemCard");

                entity.Property(e => e.AccountId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.AccountTableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.IsBonus).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastUpdateTime)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.QtyIunit2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.Inv)
                    .WithMany(p => p.MsSalesInvoiceItemCards)
                    .HasForeignKey(d => d.InvId)
                    .HasConstraintName("FK_InvoiceItemCard_Ms_SalesInvoice");

                entity.HasOne(d => d.ItemCard)
                    .WithMany(p => p.MsSalesInvoiceItemCards)
                    .HasForeignKey(d => d.ItemCardId)
                    .HasConstraintName("FK_InvoiceItemCard_MS_ItemCard");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.MsSalesInvoiceItemCards)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_Ms_SalesInvoiceItemCard_Ms_ItemUnit");
            });

            modelBuilder.Entity<MsSalesInvoiceItemCardDeleted>(entity =>
            {
                entity.Property(e => e.AddOrEditMode).HasComment("1 Add, 0 Edit");

                entity.Property(e => e.DeletedOrChanged).HasComment("1Deleted,0 changed");

                entity.Property(e => e.IsBonus).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsSalesInvoiceMultiAccount>(entity =>
            {
                entity.Property(e => e.AccountId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.AccountTableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableName).HasComment("to attach any document in database to receiptnote");

                entity.HasOne(d => d.Inv)
                    .WithMany(p => p.MsSalesInvoiceMultiAccounts)
                    .HasForeignKey(d => d.InvId)
                    .HasConstraintName("FK_Ms_SalesInvoiceMultiAccounts_Ms_SalesInvoice");
            });

            modelBuilder.Entity<MsSalesInvoiceQualityDeliveryDoc>(entity =>
            {
                entity.HasOne(d => d.Inv)
                    .WithMany(p => p.MsSalesInvoiceQualityDeliveryDocs)
                    .HasForeignKey(d => d.InvId)
                    .HasConstraintName("FK_Ms_SalesInvoiceQualityDeliveryDocs_Ms_SalesInvoice");
            });

            modelBuilder.Entity<MsSalesInvoiceQualityMissedItem>(entity =>
            {
                entity.Property(e => e.EmpId).IsFixedLength();

                entity.HasOne(d => d.Inv)
                    .WithMany(p => p.MsSalesInvoiceQualityMissedItems)
                    .HasForeignKey(d => d.InvId)
                    .HasConstraintName("FK_Ms_SalesInvoiceQualityMissedItems_Ms_SalesInvoice");
            });

            modelBuilder.Entity<MsSalesItemsOffer>(entity =>
            {
                entity.HasKey(e => e.PromoOfferId)
                    .HasName("PK_Ms_SalesItemsOffers_1");
            });

            modelBuilder.Entity<MsSalesItemsOffersDetail>(entity =>
            {
                entity.HasKey(e => e.ItemOfferId)
                    .HasName("PK_Ms_SalesItemsOffers");

                entity.HasOne(d => d.PromoOffer)
                    .WithMany(p => p.MsSalesItemsOffersDetails)
                    .HasForeignKey(d => d.PromoOfferId)
                    .HasConstraintName("FK_Ms_SalesItemsOffersDetails_Ms_SalesItemsOffers");
            });

            modelBuilder.Entity<MsSalesOffer>(entity =>
            {
                entity.Property(e => e.AccountId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.AccountTableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.DbtableId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.InvoiceType).HasComment("0  Cash ; 1  Due ");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MsSalesOfferItemCard>(entity =>
            {
                entity.HasKey(e => e.SalesOffertemCardId)
                    .HasName("PK_Table_1");

                entity.Property(e => e.AccountId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.AccountTableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.IsBonus).HasDefaultValueSql("((0))");

                entity.Property(e => e.QtyIunit2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.ItemCard)
                    .WithMany(p => p.MsSalesOfferItemCards)
                    .HasForeignKey(d => d.ItemCardId)
                    .HasConstraintName("FK_Ms_SalesOfferItemCard_MS_ItemCard");

                entity.HasOne(d => d.SalesOffer)
                    .WithMany(p => p.MsSalesOfferItemCards)
                    .HasForeignKey(d => d.SalesOfferId)
                    .HasConstraintName("FK_Ms_SalesOfferItemCard_Ms_SalesOffer");
            });

            modelBuilder.Entity<MsSalesOfferItemRequest>(entity =>
            {
                entity.Property(e => e.IsBonus).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.SalesOfferReq)
                    .WithMany(p => p.MsSalesOfferItemRequests)
                    .HasForeignKey(d => d.SalesOfferReqId)
                    .HasConstraintName("FK_Ms_SalesOfferItemRequest_Ms_SalesOfferRequest");
            });

            modelBuilder.Entity<MsSalesOfferRequest>(entity =>
            {
                entity.Property(e => e.AccountId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.AccountTableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.DbtableId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.InvoiceType).HasComment("0  Cash ; 1  Due ");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Rate).HasComment("True  Closed ;  False  Not Closed");
            });

            modelBuilder.Entity<MsSalesOrder>(entity =>
            {
                entity.Property(e => e.AccountId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.AccountTableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.DbtableId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.InvoiceType).HasComment("0  Cash ; 1  Due ");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MsSalesOrderItemCard>(entity =>
            {
                entity.Property(e => e.AccountId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.AccountTableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.IsBonus).HasDefaultValueSql("((0))");

                entity.Property(e => e.QtyIunit2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.SalesOrder)
                    .WithMany(p => p.MsSalesOrderItemCards)
                    .HasForeignKey(d => d.SalesOrderId)
                    .HasConstraintName("FK_Ms_SalesOrderItemCard_Ms_SalesOrder");
            });

            modelBuilder.Entity<MsSetting>(entity =>
            {
                entity.Property(e => e.AskForAttachMove).HasComment("1 always copy, 2 always move,3 never copy or move,4 ask to move");

                entity.Property(e => e.CustSeparator).IsFixedLength();

                entity.Property(e => e.ItemSeparator).IsFixedLength();

                entity.Property(e => e.VendSeparator).IsFixedLength();
            });

            modelBuilder.Entity<MsStockReceiptItemCard>(entity =>
            {
                entity.Property(e => e.AccountId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.AccountTableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.IsBonus).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastUpdateTime)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.QtyIunit2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.ItemCard)
                    .WithMany(p => p.MsStockReceiptItemCards)
                    .HasForeignKey(d => d.ItemCardId)
                    .HasConstraintName("FK_MS_StockReceiptItemCard_MS_ItemCard");

                entity.HasOne(d => d.StockRec)
                    .WithMany(p => p.MsStockReceiptItemCards)
                    .HasForeignKey(d => d.StockRecId)
                    .HasConstraintName("FK_MS_StockReceiptItemCard_MS_StockRecript");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.MsStockReceiptItemCards)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_MS_StockReceiptItemCard_Ms_ItemUnit");
            });

            modelBuilder.Entity<MsStockRecript>(entity =>
            {
                entity.Property(e => e.AccountId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.AccountTableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DbtableId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsClosed).HasComment("True Closed ;  False  Not Closed");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 Invoice ; 1 Return ; 2  Vendor ");

                entity.Property(e => e.StockRecDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StockRecDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsStockRecriptExpense>(entity =>
            {
                entity.HasOne(d => d.StockRec)
                    .WithMany(p => p.MsStockRecriptExpenses)
                    .HasForeignKey(d => d.StockRecId)
                    .HasConstraintName("FK_MS_StockRecriptExpenses_MS_StockRecript");
            });

            modelBuilder.Entity<MsStockRecriptMultiAccount>(entity =>
            {
                entity.Property(e => e.AccountId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.AccountTableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableName).HasComment("to attach any document in database to receiptnote");

                entity.HasOne(d => d.StockRec)
                    .WithMany(p => p.MsStockRecriptMultiAccounts)
                    .HasForeignKey(d => d.StockRecId)
                    .HasConstraintName("FK_MS_StockRecriptMultiAccounts_MS_StockRecript");
            });

            modelBuilder.Entity<MsStockTranItemCard>(entity =>
            {
                entity.Property(e => e.LastUpdateTime)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.QtyIunit2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.ItemCard)
                    .WithMany(p => p.MsStockTranItemCards)
                    .HasForeignKey(d => d.ItemCardId)
                    .HasConstraintName("FK_MS_StockTranItemCard_MS_ItemCard");

                entity.HasOne(d => d.Tran)
                    .WithMany(p => p.MsStockTranItemCards)
                    .HasForeignKey(d => d.TranId)
                    .HasConstraintName("FK_MS_StockTranItemCard_MS_StockTransferNote");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.MsStockTranItemCards)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_MS_StockTranItemCard_Ms_ItemUnit");
            });

            modelBuilder.Entity<MsStockTranItemCardReq>(entity =>
            {
                entity.Property(e => e.QtyIunit2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.TranReq)
                    .WithMany(p => p.MsStockTranItemCardReqs)
                    .HasForeignKey(d => d.TranReqId)
                    .HasConstraintName("FK_Ms_StockTranItemCardReq_Ms_StockTransferNoteRequest");
            });

            modelBuilder.Entity<MsStockTransferNote>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastUpdateTime)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StockTranDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StockTranDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsStockTransferNoteRequest>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StockTranDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StockTranDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsStore>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Fax).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreKeeper).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StorePosition).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreType).HasComment("true MainBranch , False Sub Branch");

                entity.Property(e => e.Tel).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.Box)
                    .WithMany(p => p.MsStores)
                    .HasForeignKey(d => d.BoxId)
                    .HasConstraintName("FK_MS_Stores_MS_BoxBank");
            });

            modelBuilder.Entity<MsTaxis>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TaxCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TaxNameA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TaxNameE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TaxStyle).HasComment("0 Percent , 1 value , 2 Without");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsTerm>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsTermsCostCenter>(entity =>
            {
                entity.Property(e => e.ValuAddCostCenter1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ValuAddCostCenter2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ValuAddCostCenter3).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ValuAddCostCenter4).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ValuAddCostCenter5).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ValuCostCenterCash).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ValuCostCenterCredit).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ValuCostCenterDebit).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ValuCostCenterDisc).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ValuCostCenterTax).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.Term)
                    .WithMany(p => p.MsTermsCostCenters)
                    .HasForeignKey(d => d.TermId)
                    .HasConstraintName("FK_Ms_TermsCostCenter_Ms_Terms");
            });

            modelBuilder.Entity<MsTermsDetail>(entity =>
            {
                entity.Property(e => e.ValuAccountCash).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ValuAccountCredit).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ValuAccountDebit).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ValuAccountDisc).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ValuAccountTax).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ValuAddAccount1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ValuAddAccount2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ValuAddAccount3).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ValuAddAccount4).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ValuAddAccount5).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.Term)
                    .WithMany(p => p.MsTermsDetails)
                    .HasForeignKey(d => d.TermId)
                    .HasConstraintName("FK_Ms_TermsDetails_Ms_Terms");
            });

            modelBuilder.Entity<MsUserAuthentication>(entity =>
            {
                entity.Property(e => e.AuthCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.AuthDesc).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.AuthName).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.AuthenticatedBy).HasComment("the Id of the user who athurized to give this authentication");
            });

            modelBuilder.Entity<MsVendImg>(entity =>
            {
                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.MsVendImgs)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_Ms_VendImgs_MS_Vendor");
            });

            modelBuilder.Entity<MsVendor>(entity =>
            {
                entity.Property(e => e.Address).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Address1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Address2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Address3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Company).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email4).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.EtaxCustType).HasComment("Business  tax Reg Required,Person   NationalID not required,Foreigner  Name and ID  required");

                entity.Property(e => e.Fax).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.LastUpdateTime)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Tel).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Tel2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel3).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel4).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel5).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.VendId).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.VendJob).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.VendorCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.VendorDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.VendorDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.MsVendors)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_MS_Vendor_MS_Currency");

                entity.HasOne(d => d.VendorCat)
                    .WithMany(p => p.MsVendors)
                    .HasForeignKey(d => d.VendorCatId)
                    .HasConstraintName("FK_MS_Vendor_MS_VendorCategory");

                entity.HasOne(d => d.VendorType)
                    .WithMany(p => p.MsVendors)
                    .HasForeignKey(d => d.VendorTypeId)
                    .HasConstraintName("FK_MS_Vendor_Ms_VendorTypes");
            });

            modelBuilder.Entity<MsVendorBranch>(entity =>
            {
                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.MsVendorBranches)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_Ms_VendorBranches_MS_Vendor");
            });

            modelBuilder.Entity<MsVendorCategory>(entity =>
            {
                entity.Property(e => e.CatCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CatDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CatDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsVendorContact>(entity =>
            {
                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.MsVendorContacts)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_Ms_VendorContacts_MS_Vendor");
            });

            modelBuilder.Entity<MsVendorType>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.VendorTypeCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.VendorTypeDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.VendorTypeDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsVendorUser>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.MsVendorUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Ms_VendorUsers_G_Users");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.MsVendorUsers)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_Ms_VendorUsers_MS_Vendor");
            });

            modelBuilder.Entity<MsVwAssetExcelExport>(entity =>
            {
                entity.ToView("Ms_Vw_AssetExcelExport");

                entity.Property(e => e.Email).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Fax).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Tel).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsVwBankTran>(entity =>
            {
                entity.ToView("Ms_VW_BankTran");

                entity.Property(e => e.BoxFrom).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.BoxTo).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Desca).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Desce).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsVwCustomerExcelExport>(entity =>
            {
                entity.ToView("Ms_Vw_CustomerExcelExport");

                entity.Property(e => e.Address).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CatCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CatDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencyCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencyDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Fax).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Tel).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsVwItemBatchStore>(entity =>
            {
                entity.ToView("Ms_VW_ItemBatchStores");

                entity.Property(e => e.StoreCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsVwItemBatchesQtyInStore>(entity =>
            {
                entity.ToView("Ms_VW_ItemBatchesQtyInStores");

                entity.Property(e => e.ItemBatchCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ItemBatchName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.PartCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PartDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsVwItemCardExcelExport>(entity =>
            {
                entity.ToView("Ms_Vw_ItemCardExcelExport");

                entity.Property(e => e.BarCode1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode10).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode11).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode12).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode13).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode14).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode15).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode3).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode4).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode5).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode6).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode7).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode8).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode9).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ItemCatCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ItemCatDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PartCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PartDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Ttype)
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<MsVwItemStore>(entity =>
            {
                entity.ToView("Ms_VW_ItemStores");

                entity.Property(e => e.StoreCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsVwLetterDocSearch>(entity =>
            {
                entity.ToView("Ms_Vw_letterDocSearch");

                entity.Property(e => e.CityName).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsVwLetterSearchresult>(entity =>
            {
                entity.ToView("Ms_Vw_letterSearchresult");

                entity.Property(e => e.CityName).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsVwLetterTaxSearch>(entity =>
            {
                entity.ToView("Ms_Vw_LetterTaxSearch");
            });

            modelBuilder.Entity<MsVwQtyInStore>(entity =>
            {
                entity.ToView("Ms_VW_QtyInStores");

                entity.Property(e => e.PartCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PartDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsVwVendorExcelExport>(entity =>
            {
                entity.ToView("Ms_Vw_VendorExcelExport");

                entity.Property(e => e.Address).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CatCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CatDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencyCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencyDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Fax).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Tel).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.VendorCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.VendorDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.VendorDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsWeightCard>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<MsWeightcardItem>(entity =>
            {
                entity.Property(e => e.QtyIunit2).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.ScaleCard)
                    .WithMany(p => p.MsWeightcardItems)
                    .HasForeignKey(d => d.ScaleCardId)
                    .HasConstraintName("FK_Ms_WeightcardItems_Ms_WeightCard");
            });

            modelBuilder.Entity<MsgaCity>(entity =>
            {
                entity.HasKey(e => e.CityId)
                    .HasName("PK_MS_City");

                entity.Property(e => e.CityCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CityName).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<PayNoteSearch>(entity =>
            {
                entity.ToView("PayNoteSearch");

                entity.Property(e => e.BoxCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CheckNumber).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CurrencyCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencyDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencyDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CustomerDescA).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CustomerDescE).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Desca).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<PrintBoxType>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<PrintBreakType>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<PrintClosing>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<PrintConnectionType>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<PrintCoverType>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<PrintCutterTypeId>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<PrintDistribution>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<PrintEditType>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<PrintFaceType>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<PrintGofferType>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<PrintGradeType>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<PrintGramType>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<PrintIndustry>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<PrintJobOrderCreationType>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<PrintPadingType>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<PrintPricing>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<PrintPricingDetail>(entity =>
            {
                entity.HasOne(d => d.PrinPrice)
                    .WithMany(p => p.PrintPricingDetails)
                    .HasForeignKey(d => d.PrinPriceId)
                    .HasConstraintName("FK_Print_PricingDetails_Print_Pricing");
            });

            modelBuilder.Entity<PrintQoutation>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<PrintQoutationDetail>(entity =>
            {
                entity.HasOne(d => d.PrinQout)
                    .WithMany(p => p.PrintQoutationDetails)
                    .HasForeignKey(d => d.PrinQoutId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Print_QoutationDetails_Print_Qoutation");
            });

            modelBuilder.Entity<PrintQoutationDetailsItem>(entity =>
            {
                entity.HasOne(d => d.PrinQoutDetail)
                    .WithMany(p => p.PrintQoutationDetailsItems)
                    .HasForeignKey(d => d.PrinQoutDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Print_QoutationDetailsItems_Print_QoutationDetails");
            });

            modelBuilder.Entity<PrintSector>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<PrintSizeType>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<PrintStickyType>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<PrintStocking>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<ProdAttributeValue>(entity =>
            {
                entity.Property(e => e.AttributValuName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.AttributValuName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.AttributValue).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.Attribut)
                    .WithMany(p => p.ProdAttributeValues)
                    .HasForeignKey(d => d.AttributId)
                    .HasConstraintName("FK_Prod_AttributeValue_Prod_ItemAttributes");
            });

            modelBuilder.Entity<ProdBasicUnit>(entity =>
            {
                entity.Property(e => e.AutoDesc).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Symbol).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UnitNam).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.ParentUnitNavigation)
                    .WithMany(p => p.InverseParentUnitNavigation)
                    .HasForeignKey(d => d.ParentUnit)
                    .HasConstraintName("FK_Prod_BasicUnits_Prod_BasicUnits");
            });

            modelBuilder.Entity<ProdBillOfMaterial>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<ProdBillOfMaterialItem>(entity =>
            {
                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.BillOfMaterial)
                    .WithMany(p => p.ProdBillOfMaterialItems)
                    .HasForeignKey(d => d.BillOfMaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prod_BillOfMaterialItems_Prod_BillOfMaterial");
            });

            modelBuilder.Entity<ProdBillOfMaterialSecondaryItem>(entity =>
            {
                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.BillOfMaterial)
                    .WithMany(p => p.ProdBillOfMaterialSecondaryItems)
                    .HasForeignKey(d => d.BillOfMaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prod_BillOfMaterialSecondaryItems_Prod_BillOfMaterial");
            });

            modelBuilder.Entity<ProdEmpEquipDistrib>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<ProdEmpEquipDistribDetail>(entity =>
            {
                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.EmpEquipDist)
                    .WithMany(p => p.ProdEmpEquipDistribDetails)
                    .HasForeignKey(d => d.EmpEquipDistId)
                    .HasConstraintName("FK_Prod_EmpEquipDistribDetail_Prod_EmpEquipDistrib");
            });

            modelBuilder.Entity<ProdEmpJobOrderDistrib>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<ProdEmpJobOrderDistribDetail>(entity =>
            {
                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.EmpJobOrderDist)
                    .WithMany(p => p.ProdEmpJobOrderDistribDetails)
                    .HasForeignKey(d => d.EmpJobOrderDistId)
                    .HasConstraintName("FK_Prod_EmpJobOrderDistribDetail_Prod_EmpJobOrderDistrib");
            });

            modelBuilder.Entity<ProdEquipProfile>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ProdileDesc).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ProfileCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.Equip)
                    .WithMany(p => p.ProdEquipProfiles)
                    .HasForeignKey(d => d.EquipId)
                    .HasConstraintName("FK_Prod_EquipProfile_Prod_Equipments");
            });

            modelBuilder.Entity<ProdEquipment>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EquipCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EquipName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EquipName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jdesc).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<ProdItemAttribute>(entity =>
            {
                entity.Property(e => e.AttributCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.AttributName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.AttributName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Dimension).HasComment("0 without,1 length,2 width,3 Height");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<ProdItemAttributesBatche>(entity =>
            {
                entity.HasKey(e => e.ItemAtrribBatchId)
                    .HasName("PK_Prod_ItemAttributesBatched");

                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ItemBatchCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ItemBatchDesc).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ItemBatchName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ItemBatchName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<ProdItemAttributesBatchesDetail>(entity =>
            {
                entity.Property(e => e.AttribValueDesc).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.ItemAtrribBatch)
                    .WithMany(p => p.ProdItemAttributesBatchesDetails)
                    .HasForeignKey(d => d.ItemAtrribBatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prod_ItemAttributesBatchesDetails_Prod_ItemAttributesBatche");
            });

            modelBuilder.Entity<ProdItemAttributsJoin>(entity =>
            {
                entity.HasKey(e => e.ProdItemAtrribId)
                    .HasName("PK_Prod_ItemAttributs");

                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.Attribut)
                    .WithMany(p => p.ProdItemAttributsJoins)
                    .HasForeignKey(d => d.AttributId)
                    .HasConstraintName("FK_Prod_ItemAttributsJoin_Prod_ItemAttributes");

                entity.HasOne(d => d.ItemCard)
                    .WithMany(p => p.ProdItemAttributsJoins)
                    .HasForeignKey(d => d.ItemCardId)
                    .HasConstraintName("FK_Prod_ItemAttributsJoin_MS_ItemCard");
            });

            modelBuilder.Entity<ProdItemBatchPartition>(entity =>
            {
                entity.Property(e => e.QtyInNotebook).HasDefaultValueSql("((0))");

                entity.Property(e => e.QtyIunit2Notebook).HasDefaultValueSql("((0))");

                entity.Property(e => e.QtyIunit2Partiation).HasDefaultValueSql("((0))");

                entity.Property(e => e.QtyPartiation).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ttype)
                    .IsFixedLength()
                    .HasComment("i for inserted, u for updated")
                    .UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tversion).HasComment("number of updates on the table");

                entity.HasOne(d => d.ItemAtrribBatch)
                    .WithMany(p => p.ProdItemBatchPartitions)
                    .HasForeignKey(d => d.ItemAtrribBatchId)
                    .HasConstraintName("FK_Prod_ItemBatchPartition_Prod_ItemAttributesBatche");
            });

            modelBuilder.Entity<ProdItemcardExpense>(entity =>
            {
                entity.HasOne(d => d.ItemCard)
                    .WithMany(p => p.ProdItemcardExpenses)
                    .HasForeignKey(d => d.ItemCardId)
                    .HasConstraintName("FK_Prod_ItemcardExpenses_MS_ItemCard");
            });

            modelBuilder.Entity<ProdJobOrder>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.FatteningType).HasComment("1 Fattening, 2 Feeding");

                entity.Property(e => e.RefOrder).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<ProdJobOrderClosing>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<ProdJobOrderEmpCostDoc>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ShiftId).IsFixedLength();

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<ProdJobOrderEmpCostDocDetail>(entity =>
            {
                entity.HasOne(d => d.JorderEmpDoc)
                    .WithMany(p => p.ProdJobOrderEmpCostDocDetails)
                    .HasForeignKey(d => d.JorderEmpDocId)
                    .HasConstraintName("FK_Prod_JobOrderEmpCostDocDetail_Prod_JobOrderEmpCostDoc");
            });

            modelBuilder.Entity<ProdJobOrderEquipCostDoc>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<ProdJobOrderEquipCostDocDetail>(entity =>
            {
                entity.HasOne(d => d.JorderEquipDoc)
                    .WithMany(p => p.ProdJobOrderEquipCostDocDetails)
                    .HasForeignKey(d => d.JorderEquipDocId)
                    .HasConstraintName("FK_Prod_JobOrderEquipCostDocDetail_Prod_JobOrderEquipCostDoc");
            });

            modelBuilder.Entity<ProdJobOrderEquipment>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TimeUnit).HasComment("1 Minutes, 2 Hours,3 Days, 4 Months");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.JobOrder)
                    .WithMany(p => p.ProdJobOrderEquipments)
                    .HasForeignKey(d => d.JobOrderId)
                    .HasConstraintName("FK_Prod_JobOrderEquipment_Prod_JobOrder");
            });

            modelBuilder.Entity<ProdJobOrderExpense>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TimeUnit).HasComment("1 Minutes, 2 Hours,3 Days, 4 Months");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.JobOrder)
                    .WithMany(p => p.ProdJobOrderExpenses)
                    .HasForeignKey(d => d.JobOrderId)
                    .HasConstraintName("FK_Prod_JobOrderExpenses_Prod_JobOrder");
            });

            modelBuilder.Entity<ProdJobOrderGoStock>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.JobOrder)
                    .WithMany(p => p.ProdJobOrderGoStocks)
                    .HasForeignKey(d => d.JobOrderId)
                    .HasConstraintName("FK_Prod_JobOrderGoStock_Prod_JobOrder");
            });

            modelBuilder.Entity<ProdJobOrderJob>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TimeUnit).HasComment("1 Minutes, 2 Hours,3 Days, 4 Months");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.JobOrder)
                    .WithMany(p => p.ProdJobOrderJobs)
                    .HasForeignKey(d => d.JobOrderId)
                    .HasConstraintName("FK_Prod_JobOrderJobs_Prod_JobOrder");
            });

            modelBuilder.Entity<ProdJobOrderMaterial>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.JobOrder)
                    .WithMany(p => p.ProdJobOrderMaterials)
                    .HasForeignKey(d => d.JobOrderId)
                    .HasConstraintName("FK_Prod_JobOrderMaterials_Prod_JobOrder");
            });

            modelBuilder.Entity<ProdJobOrderProduct>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.ItemAtrribBatch)
                    .WithMany(p => p.ProdJobOrderProducts)
                    .HasForeignKey(d => d.ItemAtrribBatchId)
                    .HasConstraintName("FK_Prod_JobOrderProducts_Prod_ItemAttributesBatche");

                entity.HasOne(d => d.ItemCard)
                    .WithMany(p => p.ProdJobOrderProducts)
                    .HasForeignKey(d => d.ItemCardId)
                    .HasConstraintName("FK_Prod_JobOrderProducts_MS_ItemCard");

                entity.HasOne(d => d.JobOrder)
                    .WithMany(p => p.ProdJobOrderProducts)
                    .HasForeignKey(d => d.JobOrderId)
                    .HasConstraintName("FK_Prod_JobOrderProducts_Prod_JobOrder");
            });

            modelBuilder.Entity<ProdJobOrderPurchaseInvoice>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.JobOrder)
                    .WithMany(p => p.ProdJobOrderPurchaseInvoices)
                    .HasForeignKey(d => d.JobOrderId)
                    .HasConstraintName("FK_Prod_JobOrderPurchaseInvoices_Prod_JobOrder");

                entity.HasOne(d => d.PurInv)
                    .WithMany(p => p.ProdJobOrderPurchaseInvoices)
                    .HasForeignKey(d => d.PurInvId)
                    .HasConstraintName("FK_Prod_JobOrderPurchaseInvoices_MS_PurchasInvoice");
            });

            modelBuilder.Entity<ProdJobOrderScrap>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.JobOrder)
                    .WithMany(p => p.ProdJobOrderScraps)
                    .HasForeignKey(d => d.JobOrderId)
                    .HasConstraintName("FK_Prod_JobOrderScrap_Prod_JobOrder");
            });

            modelBuilder.Entity<ProdJobOrderService>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TimeUnit).HasComment("1 Minutes, 2 Hours,3 Days, 4 Months");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.JobOrder)
                    .WithMany(p => p.ProdJobOrderServices)
                    .HasForeignKey(d => d.JobOrderId)
                    .HasConstraintName("FK_Prod_JobOrderServices_Prod_JobOrder");
            });

            modelBuilder.Entity<ProdJobOrderTask>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Description).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TimeUnit).HasComment("1 Minutes, 2 Hours,3 Days, 4 Months");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.JobOrder)
                    .WithMany(p => p.ProdJobOrderTasks)
                    .HasForeignKey(d => d.JobOrderId)
                    .HasConstraintName("FK_Prod_JobOrderTasks_Prod_JobOrder");
            });

            modelBuilder.Entity<ProdJobOrderType>(entity =>
            {
                entity.Property(e => e.AnimalOrFood).HasComment("1 food,2 animal");

                entity.Property(e => e.Code).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.JobOrderMadeFor).HasComment("0 store, 1 customer");

                entity.Property(e => e.Name1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remark).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<ProdJobOrderWorkFlow>(entity =>
            {
                entity.Property(e => e.Note).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.JobOrder)
                    .WithMany(p => p.ProdJobOrderWorkFlows)
                    .HasForeignKey(d => d.JobOrderId)
                    .HasConstraintName("FK_Prod_JobOrderWorkFlow_Prod_JobOrder");
            });

            modelBuilder.Entity<ProdJoinTaskEquipment>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.ProdJoinTaskEquipments)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("FK_Prod_JoinTaskEquipments_Prod_Tasks");
            });

            modelBuilder.Entity<ProdJoinTaskJob>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.ProdJoinTaskJobs)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("FK_Prod_JoinTaskJob_Prod_Tasks");
            });

            modelBuilder.Entity<ProdProductionLine>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ProdLinDesc).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ProdLinName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ProdLinName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<ProdProductionLineDetail>(entity =>
            {
                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TimeUnit).HasComment("1 Minutes, 2 Hours,3 Days, 4 Months");

                entity.HasOne(d => d.ProLine)
                    .WithMany(p => p.ProdProductionLineDetails)
                    .HasForeignKey(d => d.ProLineId)
                    .HasConstraintName("FK_Prod_ProductionLineDetails_Prod_ProductionLine");
            });

            modelBuilder.Entity<ProdProductionOrder>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<ProdProductionOrderDetail>(entity =>
            {
                entity.HasOne(d => d.ProductionOrder)
                    .WithMany(p => p.ProdProductionOrderDetails)
                    .HasForeignKey(d => d.ProductionOrderId)
                    .HasConstraintName("FK_Prod_ProductionOrderDetail_Prod_ProductionOrder");
            });

            modelBuilder.Entity<ProdRecipe>(entity =>
            {
                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<ProdRecipeDetail>(entity =>
            {
                entity.HasOne(d => d.Recipe)
                    .WithMany(p => p.ProdRecipeDetails)
                    .HasForeignKey(d => d.RecipeId)
                    .HasConstraintName("FK_Prod_RecipeDetail_Prod_Recipe");
            });

            modelBuilder.Entity<ProdSetting>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EmpDataSource).HasComment("1 production,2 Hr");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<ProdTask>(entity =>
            {
                entity.Property(e => e.Comment).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TaskCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TaskDesc).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TaskName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TaskName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<ProdWorkOrder>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<ProdWorkOrderEquipment>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TimeUnit).HasComment("1 Minutes, 2 Hours,3 Days, 4 Months");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.WorkOrder)
                    .WithMany(p => p.ProdWorkOrderEquipments)
                    .HasForeignKey(d => d.WorkOrderId)
                    .HasConstraintName("FK_Prod_WorkOrderEquipment_Prod_WorkOrder");
            });

            modelBuilder.Entity<ProdWorkOrderExpense>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TimeUnit).HasComment("1 Minutes, 2 Hours,3 Days, 4 Months");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.WorkOrder)
                    .WithMany(p => p.ProdWorkOrderExpenses)
                    .HasForeignKey(d => d.WorkOrderId)
                    .HasConstraintName("FK_Prod_WorkOrderExpenses_Prod_WorkOrder");
            });

            modelBuilder.Entity<ProdWorkOrderItemRecQualityDoc>(entity =>
            {
                entity.HasOne(d => d.WorkOrder)
                    .WithMany(p => p.ProdWorkOrderItemRecQualityDocs)
                    .HasForeignKey(d => d.WorkOrderId)
                    .HasConstraintName("FK_Prod_WorkOrderItemRecQualityDocs_Prod_WorkOrder");
            });

            modelBuilder.Entity<ProdWorkOrderMaterial>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.WorkOrder)
                    .WithMany(p => p.ProdWorkOrderMaterials)
                    .HasForeignKey(d => d.WorkOrderId)
                    .HasConstraintName("FK_Prod_WorkOrderMaterials_Prod_WorkOrder");
            });

            modelBuilder.Entity<ProdWorkOrderProdItem>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.WorkOrder)
                    .WithMany(p => p.ProdWorkOrderProdItems)
                    .HasForeignKey(d => d.WorkOrderId)
                    .HasConstraintName("FK_Prod_WorkOrderProdItems_Prod_WorkOrder");
            });

            modelBuilder.Entity<ProdWorkOrderScrap>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<ProdWorkOrderService>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TimeUnit).HasComment("1 Minutes, 2 Hours,3 Days, 4 Months");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.WorkOrder)
                    .WithMany(p => p.ProdWorkOrderServices)
                    .HasForeignKey(d => d.WorkOrderId)
                    .HasConstraintName("FK_Prod_WorkOrderServices_Prod_WorkOrder");
            });

            modelBuilder.Entity<ProjAccount>(entity =>
            {
                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjAccounts)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_Proj_Accounts_Proj_Projects");
            });

            modelBuilder.Entity<ProjEstimateItem>(entity =>
            {
                entity.Property(e => e.AttributeCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.AttributeName).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjEstimateItems)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_Proj_EstimateItems_Proj_Projects");
            });

            modelBuilder.Entity<ProjExpense>(entity =>
            {
                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjExpenses)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_Proj_Expenses_Proj_Projects");
            });

            modelBuilder.Entity<ProjFund>(entity =>
            {
                entity.Property(e => e.Contact).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Description).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.FundName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.FundName2).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjFunds)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_Proj_Fund_Proj_Projects");
            });

            modelBuilder.Entity<ProjProjDocument>(entity =>
            {
                entity.Property(e => e.Fsid).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.OwnShipBond)
                    .WithMany(p => p.ProjProjDocuments)
                    .HasForeignKey(d => d.OwnShipBondId)
                    .HasConstraintName("FK_Proj_ProjDocuments_Cod_OwnershipBonds");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjProjDocuments)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_Proj_ProjDocuments_Proj_Projects");
            });

            modelBuilder.Entity<ProjProjExploitJoin>(entity =>
            {
                entity.HasOne(d => d.BuildExploit)
                    .WithMany(p => p.ProjProjExploitJoins)
                    .HasForeignKey(d => d.BuildExploitId)
                    .HasConstraintName("FK_Proj_ProjExploitJoin_Cod_BuildingExploitation");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjProjExploitJoins)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_Proj_ProjExploitJoin_Proj_Projects");
            });

            modelBuilder.Entity<ProjProjInsurance>(entity =>
            {
                entity.HasOne(d => d.BuildInsurStat)
                    .WithMany(p => p.ProjProjInsurances)
                    .HasForeignKey(d => d.BuildInsurStatId)
                    .HasConstraintName("FK_Proj_ProjInsurance_Cod_BuildingInsuranceStatus");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjProjInsurances)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_Proj_ProjInsurance_Proj_Projects");
            });

            modelBuilder.Entity<ProjProjInsuranceUnit>(entity =>
            {
                entity.HasOne(d => d.InsurCase)
                    .WithMany(p => p.ProjProjInsuranceUnits)
                    .HasForeignKey(d => d.InsurCaseId)
                    .HasConstraintName("FK_Proj_ProjInsuranceUnit_Cod_InsuranceCases");

                entity.HasOne(d => d.ProjUnit)
                    .WithMany(p => p.ProjProjInsuranceUnits)
                    .HasForeignKey(d => d.ProjUnitId)
                    .HasConstraintName("FK_Proj_ProjInsuranceUnit_Proj_ProjUnits");

                entity.HasOne(d => d.UnitInsurstat)
                    .WithMany(p => p.ProjProjInsuranceUnits)
                    .HasForeignKey(d => d.UnitInsurstatId)
                    .HasConstraintName("FK_Proj_ProjInsuranceUnit_Cod_UnitInsuranceStatus");
            });

            modelBuilder.Entity<ProjProjItemEmpTaskJoin>(entity =>
            {
                entity.HasOne(d => d.ProjItemEmp)
                    .WithMany(p => p.ProjProjItemEmpTaskJoins)
                    .HasForeignKey(d => d.ProjItemEmpId)
                    .HasConstraintName("FK_Proj_ProjItemEmpTaskJoin_Proj_ProjectItemEmpJoin");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.ProjProjItemEmpTaskJoins)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("FK_Proj_ProjItemEmpTaskJoin_Prod_Tasks");
            });

            modelBuilder.Entity<ProjProjOccupTypeJoin>(entity =>
            {
                entity.HasOne(d => d.BuildOccupType)
                    .WithMany(p => p.ProjProjOccupTypeJoins)
                    .HasForeignKey(d => d.BuildOccupTypeId)
                    .HasConstraintName("FK_Proj_ProjOccupTypeJoin_Cod_BuildOccupTypes");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjProjOccupTypeJoins)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_Proj_ProjOccupTypeJoin_Proj_Projects");
            });

            modelBuilder.Entity<ProjProjOwnerJoin>(entity =>
            {
                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjProjOwnerJoins)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_Proj_ProjOwnerJoin_Proj_Projects");
            });

            modelBuilder.Entity<ProjProjParkingJoin>(entity =>
            {
                entity.HasOne(d => d.Parking)
                    .WithMany(p => p.ProjProjParkingJoins)
                    .HasForeignKey(d => d.ParkingId)
                    .HasConstraintName("FK_Proj_ProjParkingJoin_Cod_Parkings");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjProjParkingJoins)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_Proj_ProjParkingJoin_Proj_Projects");
            });

            modelBuilder.Entity<ProjProjPermitActivityJoin>(entity =>
            {
                entity.HasOne(d => d.BuildPermitActivity)
                    .WithMany(p => p.ProjProjPermitActivityJoins)
                    .HasForeignKey(d => d.BuildPermitActivityId)
                    .HasConstraintName("FK_Proj_ProjPermitActivityJoin_Cod_BuildPermitActiv");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjProjPermitActivityJoins)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_Proj_ProjPermitActivityJoin_Proj_Projects");
            });

            modelBuilder.Entity<ProjProjPerspectiveJoin>(entity =>
            {
                entity.Property(e => e.Fsid).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.BuildPerspective)
                    .WithMany(p => p.ProjProjPerspectiveJoins)
                    .HasForeignKey(d => d.BuildPerspectiveId)
                    .HasConstraintName("FK_Proj_ProjPerspectiveJoin_Cod_BuildPerspective");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjProjPerspectiveJoins)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_Proj_ProjPerspectiveJoin_Proj_Projects2");
            });

            modelBuilder.Entity<ProjProjPicture>(entity =>
            {
                entity.Property(e => e.Fsid)
                    .HasDefaultValueSql("(newid())")
                    .HasComment("");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjProjPictures)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_Proj_ProjPicture_Proj_Projects");
            });

            modelBuilder.Entity<ProjProjUnit>(entity =>
            {
                entity.HasKey(e => e.ProjUnitId)
                    .HasName("PK_Proj_ProjUnits_1");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjProjUnits)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_Proj_ProjUnits_Proj_Projects");
            });

            modelBuilder.Entity<ProjProjUnitDocument>(entity =>
            {
                entity.Property(e => e.Fsid).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.OwnShipBond)
                    .WithMany(p => p.ProjProjUnitDocuments)
                    .HasForeignKey(d => d.OwnShipBondId)
                    .HasConstraintName("FK_Proj_ProjUnitDocument_Cod_OwnershipBonds");

                entity.HasOne(d => d.ProjUnit)
                    .WithMany(p => p.ProjProjUnitDocuments)
                    .HasForeignKey(d => d.ProjUnitId)
                    .HasConstraintName("FK_Proj_ProjUnitDocument_Proj_ProjUnits");
            });

            modelBuilder.Entity<ProjProjUnitExploitJoin>(entity =>
            {
                entity.HasOne(d => d.ProjUnit)
                    .WithMany(p => p.ProjProjUnitExploitJoins)
                    .HasForeignKey(d => d.ProjUnitId)
                    .HasConstraintName("FK_Proj_ProjUnitExploitJoin_Proj_ProjUnits");

                entity.HasOne(d => d.UnitExploit)
                    .WithMany(p => p.ProjProjUnitExploitJoins)
                    .HasForeignKey(d => d.UnitExploitId)
                    .HasConstraintName("FK_Proj_ProjUnitExploitJoin_Cod_UnitExploitation");
            });

            modelBuilder.Entity<ProjProjUnitInstallTemp>(entity =>
            {
                entity.HasOne(d => d.InstallTemp)
                    .WithMany(p => p.ProjProjUnitInstallTemps)
                    .HasForeignKey(d => d.InstallTempId)
                    .HasConstraintName("FK_Proj_ProjUnitInstallTemp_Cod_InstallmentTemps");

                entity.HasOne(d => d.ProjUnit)
                    .WithMany(p => p.ProjProjUnitInstallTemps)
                    .HasForeignKey(d => d.ProjUnitId)
                    .HasConstraintName("FK_Proj_ProjUnitInstallTemp_Proj_ProjUnits");
            });

            modelBuilder.Entity<ProjProjUnitOccupTypeJoin>(entity =>
            {
                entity.HasOne(d => d.ProjUnit)
                    .WithMany(p => p.ProjProjUnitOccupTypeJoins)
                    .HasForeignKey(d => d.ProjUnitId)
                    .HasConstraintName("FK_Proj_ProjUnitOccupTypeJoin_Proj_ProjUnits");

                entity.HasOne(d => d.UnitOccuType)
                    .WithMany(p => p.ProjProjUnitOccupTypeJoins)
                    .HasForeignKey(d => d.UnitOccuTypeId)
                    .HasConstraintName("FK_Proj_ProjUnitOccupTypeJoin_Cod_UnitOccupancyTypes");
            });

            modelBuilder.Entity<ProjProjUnitOwnerJoin>(entity =>
            {
                entity.HasOne(d => d.ProjUnit)
                    .WithMany(p => p.ProjProjUnitOwnerJoins)
                    .HasForeignKey(d => d.ProjUnitId)
                    .HasConstraintName("FK_Proj_ProjUnitOwnerJoin_Proj_ProjUnits");
            });

            modelBuilder.Entity<ProjProjUnitPermitActivityJoin>(entity =>
            {
                entity.HasOne(d => d.ProjUnit)
                    .WithMany(p => p.ProjProjUnitPermitActivityJoins)
                    .HasForeignKey(d => d.ProjUnitId)
                    .HasConstraintName("FK_Proj_ProjUnitPermitActivityJoin_Proj_ProjUnits");

                entity.HasOne(d => d.UnitPermitActiv)
                    .WithMany(p => p.ProjProjUnitPermitActivityJoins)
                    .HasForeignKey(d => d.UnitPermitActivId)
                    .HasConstraintName("FK_Proj_ProjUnitPermitActivityJoin_Cod_UnitPermittedActivity");
            });

            modelBuilder.Entity<ProjProjUnitPerspectiveJoin>(entity =>
            {
                entity.Property(e => e.Fsid).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.ProjUnit)
                    .WithMany(p => p.ProjProjUnitPerspectiveJoins)
                    .HasForeignKey(d => d.ProjUnitId)
                    .HasConstraintName("FK_Proj_ProjUnitPerspectiveJoin_Proj_ProjUnits");

                entity.HasOne(d => d.UnitPerspective)
                    .WithMany(p => p.ProjProjUnitPerspectiveJoins)
                    .HasForeignKey(d => d.UnitPerspectiveId)
                    .HasConstraintName("FK_Proj_ProjUnitPerspectiveJoin_Cod_UnitPerspective");
            });

            modelBuilder.Entity<ProjProjUnitPicture>(entity =>
            {
                entity.Property(e => e.Fsid).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.ProjUnit)
                    .WithMany(p => p.ProjProjUnitPictures)
                    .HasForeignKey(d => d.ProjUnitId)
                    .HasConstraintName("FK_Proj_ProjUnitPicture_Proj_ProjUnits");
            });

            modelBuilder.Entity<ProjProjUnitService>(entity =>
            {
                entity.HasOne(d => d.ProjUnit)
                    .WithMany(p => p.ProjProjUnitServices)
                    .HasForeignKey(d => d.ProjUnitId)
                    .HasConstraintName("FK_Proj_ProjUnitService_Proj_ProjUnits");

                entity.HasOne(d => d.Reserv)
                    .WithMany(p => p.ProjProjUnitServices)
                    .HasForeignKey(d => d.ReservId)
                    .HasConstraintName("FK_Proj_ProjUnitService_Proj_UnitReservation");

                entity.HasOne(d => d.UnitServ)
                    .WithMany(p => p.ProjProjUnitServices)
                    .HasForeignKey(d => d.UnitServId)
                    .HasConstraintName("FK_Proj_ProjUnitService_Cod_UnitServices");
            });

            modelBuilder.Entity<ProjProjUnitSubUnit>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.ProjUnit)
                    .WithMany(p => p.ProjProjUnitSubUnits)
                    .HasForeignKey(d => d.ProjUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Proj_ProjUnitSubUnits_Proj_ProjUnits");

                entity.HasOne(d => d.SubUnittype)
                    .WithMany(p => p.ProjProjUnitSubUnits)
                    .HasForeignKey(d => d.SubUnittypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Proj_ProjUnitSubUnits_Code_SubUnitTypes");
            });

            modelBuilder.Entity<ProjProject>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Description1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Description2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ProjectCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ProjectName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ProjectName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<ProjProjectItem>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<ProjProjectItemEmpJoin>(entity =>
            {
                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.ProjProjectItemEmpJoins)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_Proj_ProjectItemEmpJoin_Hr_Employees");

                entity.HasOne(d => d.ProjItemsJoin)
                    .WithMany(p => p.ProjProjectItemEmpJoins)
                    .HasForeignKey(d => d.ProjItemsJoinId)
                    .HasConstraintName("FK_Proj_ProjectItemEmpJoin_Proj_ProjectItemsJoin");
            });

            modelBuilder.Entity<ProjProjectItemsJoin>(entity =>
            {
                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjProjectItemsJoins)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_Proj_ProjectItemsJoin_Proj_Projects");

                entity.HasOne(d => d.ProjectItems)
                    .WithMany(p => p.ProjProjectItemsJoins)
                    .HasForeignKey(d => d.ProjectItemsId)
                    .HasConstraintName("FK_Proj_ProjectItemsJoin_Proj_ProjectItems");
            });

            modelBuilder.Entity<ProjProjectItemsVendor>(entity =>
            {
                entity.HasOne(d => d.ProjectItems)
                    .WithMany(p => p.ProjProjectItemsVendors)
                    .HasForeignKey(d => d.ProjectItemsId)
                    .HasConstraintName("FK_Proj_ProjectItemsVendors_Proj_ProjectItems");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.ProjProjectItemsVendors)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_Proj_ProjectItemsVendors_MS_Vendor");
            });

            modelBuilder.Entity<ProjReInstallment>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<ProjRealItem>(entity =>
            {
                entity.Property(e => e.AttributeCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.AttributeName).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjRealItems)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_Proj_RealItems_Proj_Projects");
            });

            modelBuilder.Entity<ProjReservInstallment>(entity =>
            {
                entity.HasOne(d => d.Reserv)
                    .WithMany(p => p.ProjReservInstallments)
                    .HasForeignKey(d => d.ReservId)
                    .HasConstraintName("FK_Proj_ReservInstallments_Proj_UnitReservation1");
            });

            modelBuilder.Entity<ProjReserveUnitDocument>(entity =>
            {
                entity.Property(e => e.Fsid).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Reserv)
                    .WithMany(p => p.ProjReserveUnitDocuments)
                    .HasForeignKey(d => d.ReservId)
                    .HasConstraintName("FK_Proj_ReserveUnitDocuments_Proj_UnitReservation");
            });

            modelBuilder.Entity<ProjReserveUnitOwner>(entity =>
            {
                entity.HasOne(d => d.Reserv)
                    .WithMany(p => p.ProjReserveUnitOwners)
                    .HasForeignKey(d => d.ReservId)
                    .HasConstraintName("FK_Proj_ReserveUnitOwners_Proj_UnitReservation");
            });

            modelBuilder.Entity<ProjReserveUnitSeller>(entity =>
            {
                entity.HasOne(d => d.Reserv)
                    .WithMany(p => p.ProjReserveUnitSellers)
                    .HasForeignKey(d => d.ReservId)
                    .HasConstraintName("FK_Proj_ReserveUnitSellers_Proj_UnitReservation");
            });

            modelBuilder.Entity<ProjTender>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.ConsultantType).HasComment("1 Account,2 Customer,3 Vendor, 4 Employee, 5 BusinessPartner");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.OwnerType).HasComment("1 Account,2 Customer,3 Vendor, 4 Employee, 5 BusinessPartner");

                entity.Property(e => e.PmType).HasComment("1 Account,2 Customer,3 Vendor, 4 Employee, 5 BusinessPartner");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<ProjTenderContract>(entity =>
            {
                entity.HasKey(e => e.TenderContractId)
                    .HasName("PK_Proj_TenderSituation");

                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<ProjTenderContractAdd>(entity =>
            {
                entity.HasOne(d => d.TenderContract)
                    .WithMany(p => p.ProjTenderContractAdds)
                    .HasForeignKey(d => d.TenderContractId)
                    .HasConstraintName("FK_Proj_TenderContractAdds_Proj_TenderContract");
            });

            modelBuilder.Entity<ProjTenderContractDetail>(entity =>
            {
                entity.HasOne(d => d.TenderContract)
                    .WithMany(p => p.ProjTenderContractDetails)
                    .HasForeignKey(d => d.TenderContractId)
                    .HasConstraintName("FK_Proj_TenderContractDetail_Proj_TenderContract");
            });

            modelBuilder.Entity<ProjTenderContractDiscount>(entity =>
            {
                entity.HasOne(d => d.TenderContract)
                    .WithMany(p => p.ProjTenderContractDiscounts)
                    .HasForeignKey(d => d.TenderContractId)
                    .HasConstraintName("FK_Proj_TenderContractDiscounts_Proj_TenderContract");
            });

            modelBuilder.Entity<ProjTenderContractorContract>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<ProjTenderContractorContractAdd>(entity =>
            {
                entity.HasOne(d => d.ContractorContract)
                    .WithMany(p => p.ProjTenderContractorContractAdds)
                    .HasForeignKey(d => d.ContractorContractId)
                    .HasConstraintName("FK_Proj_TenderContractorContractAdds_Proj_TenderContractorContract");
            });

            modelBuilder.Entity<ProjTenderContractorContractDetail>(entity =>
            {
                entity.HasOne(d => d.ContractorContract)
                    .WithMany(p => p.ProjTenderContractorContractDetails)
                    .HasForeignKey(d => d.ContractorContractId)
                    .HasConstraintName("FK_Proj_TenderContractorContractDetails_Proj_TenderContractorContract");
            });

            modelBuilder.Entity<ProjTenderContractorContractDiscount>(entity =>
            {
                entity.HasOne(d => d.ContractorContract)
                    .WithMany(p => p.ProjTenderContractorContractDiscounts)
                    .HasForeignKey(d => d.ContractorContractId)
                    .HasConstraintName("FK_Proj_TenderContractorContractDiscounts_Proj_TenderContractorContract");
            });

            modelBuilder.Entity<ProjTenderContractorExitract>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<ProjTenderContractorExitractAdd>(entity =>
            {
                entity.HasOne(d => d.ContractorExitract)
                    .WithMany(p => p.ProjTenderContractorExitractAdds)
                    .HasForeignKey(d => d.ContractorExitractId)
                    .HasConstraintName("FK_Proj_TenderContractorExitractAdds_Proj_TenderContractorExitract");
            });

            modelBuilder.Entity<ProjTenderContractorExitractDetail>(entity =>
            {
                entity.HasOne(d => d.ContractorExitract)
                    .WithMany(p => p.ProjTenderContractorExitractDetails)
                    .HasForeignKey(d => d.ContractorExitractId)
                    .HasConstraintName("FK_Proj_TenderContractorExitractDetail_Proj_TenderContractorExitract");
            });

            modelBuilder.Entity<ProjTenderContractorExitractDiscount>(entity =>
            {
                entity.HasOne(d => d.ContractorExitract)
                    .WithMany(p => p.ProjTenderContractorExitractDiscounts)
                    .HasForeignKey(d => d.ContractorExitractId)
                    .HasConstraintName("FK_Proj_TenderContractorExitractDiscounts_Proj_TenderContractorExitract");
            });

            modelBuilder.Entity<ProjTenderExecutionExitract>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<ProjTenderExecutionExitractDetail>(entity =>
            {
                entity.HasOne(d => d.ExecutExitract)
                    .WithMany(p => p.ProjTenderExecutionExitractDetails)
                    .HasForeignKey(d => d.ExecutExitractId)
                    .HasConstraintName("FK_Proj_TenderExecutionExitractDetail_Proj_TenderExecutionExitract");
            });

            modelBuilder.Entity<ProjTenderItem>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<ProjTenderItemsCategory>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<ProjTenderOffer>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<ProjTenderOfferDetail>(entity =>
            {
                entity.HasOne(d => d.TenderOffer)
                    .WithMany(p => p.ProjTenderOfferDetails)
                    .HasForeignKey(d => d.TenderOfferId)
                    .HasConstraintName("FK_Proj_TenderOfferDetail_Proj_TenderOffer");
            });

            modelBuilder.Entity<ProjTenderOwnerExitract>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<ProjTenderOwnerExitractAdd>(entity =>
            {
                entity.HasOne(d => d.OwnerExitract)
                    .WithMany(p => p.ProjTenderOwnerExitractAdds)
                    .HasForeignKey(d => d.OwnerExitractId)
                    .HasConstraintName("FK_Proj_TenderOwnerExitractAdds_Proj_TenderOwnerExitract");
            });

            modelBuilder.Entity<ProjTenderOwnerExitractDetail>(entity =>
            {
                entity.HasOne(d => d.OwnerExitract)
                    .WithMany(p => p.ProjTenderOwnerExitractDetails)
                    .HasForeignKey(d => d.OwnerExitractId)
                    .HasConstraintName("FK_Proj_TenderOwnerExitractDetail_Proj_TenderOwnerExitract");
            });

            modelBuilder.Entity<ProjTenderOwnerExitractDiscount>(entity =>
            {
                entity.HasOne(d => d.OwnerExitract)
                    .WithMany(p => p.ProjTenderOwnerExitractDiscounts)
                    .HasForeignKey(d => d.OwnerExitractId)
                    .HasConstraintName("FK_Proj_TenderOwnerExitractDiscounts_Proj_TenderOwnerExitract");
            });

            modelBuilder.Entity<ProjTenderPlan>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<ProjTenderPlanDetail>(entity =>
            {
                entity.HasOne(d => d.TenderPlan)
                    .WithMany(p => p.ProjTenderPlanDetails)
                    .HasForeignKey(d => d.TenderPlanId)
                    .HasConstraintName("FK_Proj_TenderPlanDetails_Proj_TenderPlan");
            });

            modelBuilder.Entity<ProjTenderPlanDistribution>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<ProjTenderPlanDistributionDetail>(entity =>
            {
                entity.HasOne(d => d.TenderPlanDist)
                    .WithMany(p => p.ProjTenderPlanDistributionDetails)
                    .HasForeignKey(d => d.TenderPlanDistId)
                    .HasConstraintName("FK_Proj_TenderPlanDistributionDetails_Proj_TenderPlanDistribution");
            });

            modelBuilder.Entity<ProjTenderQoutation>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<ProjTenderQoutationDetail>(entity =>
            {
                entity.HasOne(d => d.TenderQoutation)
                    .WithMany(p => p.ProjTenderQoutationDetails)
                    .HasForeignKey(d => d.TenderQoutationId)
                    .HasConstraintName("FK_Proj_TenderQoutationDetails_Proj_TenderQoutation");
            });

            modelBuilder.Entity<ProjTendersDetail>(entity =>
            {
                entity.HasOne(d => d.Tender)
                    .WithMany(p => p.ProjTendersDetails)
                    .HasForeignKey(d => d.TenderId)
                    .HasConstraintName("FK_Proj_TendersDetails_Proj_Tenders");
            });

            modelBuilder.Entity<ProjTendersReviewReason>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<ProjUnitConcession>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<ProjUnitReplacement>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<ProjUnitReservation>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RoundType)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0 without,1=10,2=100,3=1000,4=10000");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<ProjUnitReservationGuarantor>(entity =>
            {
                entity.HasOne(d => d.Reserv)
                    .WithMany(p => p.ProjUnitReservationGuarantors)
                    .HasForeignKey(d => d.ReservId)
                    .HasConstraintName("FK_Proj_UnitReservationGuarantors_Proj_UnitReservation");
            });

            modelBuilder.Entity<PurInvVendSearch>(entity =>
            {
                entity.ToView("PurInvVendSearch");

                entity.Property(e => e.CurrencyCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencyDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencyDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.InvDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.InvDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.VendorCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.VendorDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<PurOrderVendor>(entity =>
            {
                entity.ToView("PurOrderVendor");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.VendorCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.VendorDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<PurRequestVendor>(entity =>
            {
                entity.ToView("PurRequestVendor");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.VendorCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.VendorDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<QualityCategory>(entity =>
            {
                entity.HasKey(e => e.QualityCatId)
                    .HasName("PK_Prod_QualityCategory");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<QualityItemDeliverDetail>(entity =>
            {
                entity.HasOne(d => d.ItemDeliver)
                    .WithMany(p => p.QualityItemDeliverDetails)
                    .HasForeignKey(d => d.ItemDeliverId)
                    .HasConstraintName("FK_Quality_ItemDeliverDetails_Quality_ItemDelivery");
            });

            modelBuilder.Entity<QualityItemDelivery>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<QualityItemDeliveryPackage>(entity =>
            {
                entity.HasOne(d => d.ItemDeliver)
                    .WithMany(p => p.QualityItemDeliveryPackages)
                    .HasForeignKey(d => d.ItemDeliverId)
                    .HasConstraintName("FK_Quality_ItemDeliveryPackages_Quality_ItemDelivery");
            });

            modelBuilder.Entity<QualityItemRecCheck>(entity =>
            {
                entity.HasKey(e => e.ItemRecQualityId)
                    .HasName("PK_prod_ItemRecQualityCheck");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<QualityItemRecCheckDetail>(entity =>
            {
                entity.HasOne(d => d.ItemRecQuality)
                    .WithMany(p => p.QualityItemRecCheckDetails)
                    .HasForeignKey(d => d.ItemRecQualityId)
                    .HasConstraintName("FK_Quality_ItemRecCheckDetail_Quality_ItemRecCheck");
            });

            modelBuilder.Entity<QualityItemRecPackage>(entity =>
            {
                entity.HasOne(d => d.ItemRecQuality)
                    .WithMany(p => p.QualityItemRecPackages)
                    .HasForeignKey(d => d.ItemRecQualityId)
                    .HasConstraintName("FK_Quality_ItemRecPackages_Quality_ItemRecCheck");

                entity.HasOne(d => d.WorkOrder)
                    .WithMany(p => p.QualityItemRecPackages)
                    .HasForeignKey(d => d.WorkOrderId)
                    .HasConstraintName("FK_Quality_ItemRecPackages_Prod_WorkOrder");
            });

            modelBuilder.Entity<QualityItemReceivType>(entity =>
            {
                entity.HasKey(e => e.ItemRecTypeId)
                    .HasName("PK_Prod_ItemReceivTypes");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<QualityItemRecieve>(entity =>
            {
                entity.HasKey(e => e.ProdItemRecId)
                    .HasName("PK_Prod_ItemRecieve");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<QualityItemRecieveDetail>(entity =>
            {
                entity.HasKey(e => e.ProdItemRecDetailId)
                    .HasName("PK_Prod_ItemRecieveDetails");

                entity.HasOne(d => d.ProdItemRec)
                    .WithMany(p => p.QualityItemRecieveDetails)
                    .HasForeignKey(d => d.ProdItemRecId)
                    .HasConstraintName("FK_Prod_ItemRecieveDetails_Prod_ItemRecieve");
            });

            modelBuilder.Entity<ReciNotSearch>(entity =>
            {
                entity.ToView("ReciNotSearch");

                entity.Property(e => e.BankAccNumber).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.BoxCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CheckNumber).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CurrencyCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencyDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencyDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CustomerDescA).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CustomerDescE).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Desca).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<RepairJobOrder>(entity =>
            {
                entity.Property(e => e.Address).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Address1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Address2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Address3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email4).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Fax).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsClosed).HasComment("True Closed ;  False  Not Closed");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tel).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Tel2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel3).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel4).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel5).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.VehicleId).HasComment("ItemCardId");
            });

            modelBuilder.Entity<RepairJobOrderComment>(entity =>
            {
                entity.HasOne(d => d.Repair)
                    .WithMany(p => p.RepairJobOrderComments)
                    .HasForeignKey(d => d.RepairId)
                    .HasConstraintName("FK_Repair_JobOrderComments_Repair_JobOrder");
            });

            modelBuilder.Entity<RepairJobOrderEmp>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TimeUnit).HasComment("1 Minutes, 2 Hours,3 Days, 4 Months");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.Repair)
                    .WithMany(p => p.RepairJobOrderEmps)
                    .HasForeignKey(d => d.RepairId)
                    .HasConstraintName("FK_Repair_JobOrderEmps_Repair_JobOrder");
            });

            modelBuilder.Entity<RepairJobOrderItem>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.Repair)
                    .WithMany(p => p.RepairJobOrderItems)
                    .HasForeignKey(d => d.RepairId)
                    .HasConstraintName("FK_Repair_JobOrderItems_Repair_JobOrder");
            });

            modelBuilder.Entity<RepairJobOrderScrapItem>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.Repair)
                    .WithMany(p => p.RepairJobOrderScrapItems)
                    .HasForeignKey(d => d.RepairId)
                    .HasConstraintName("FK_Repair_JobOrderScrapItems_Repair_JobOrder");
            });

            modelBuilder.Entity<RepairJobOrederExpense>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TimeUnit).HasComment("1 Minutes, 2 Hours,3 Days, 4 Months");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.Repair)
                    .WithMany(p => p.RepairJobOrederExpenses)
                    .HasForeignKey(d => d.RepairId)
                    .HasConstraintName("FK_Repair_JobOrederExpenses_Repair_JobOrder");
            });

            modelBuilder.Entity<RetPurVendSearch>(entity =>
            {
                entity.ToView("retPurVendSearch");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.VendorCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.VendorDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<RetSaleSearch>(entity =>
            {
                entity.ToView("retSaleSearch");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SalesInvCustSearch>(entity =>
            {
                entity.ToView("SalesInvCustSearch");

                entity.Property(e => e.CurrencyCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencyDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencyDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.InvDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.InvDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SalesOfferCust>(entity =>
            {
                entity.ToView("SalesOfferCust");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SalesOrderCust>(entity =>
            {
                entity.ToView("SalesOrderCust");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SearchAdjustMent>(entity =>
            {
                entity.ToView("SearchAdjustMent");

                entity.Property(e => e.AdjustSourceName).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SearchAssetSetting>(entity =>
            {
                entity.ToView("SearchAssetSettings");

                entity.Property(e => e.DepartCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DepartName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DepartName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SearchAssetTermination>(entity =>
            {
                entity.ToView("SearchAssetTermination");

                entity.Property(e => e.Email).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Fax).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Tel).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SearchAttendanceDoc>(entity =>
            {
                entity.ToView("SearchAttendanceDoc");

                entity.Property(e => e.DepartCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DepartName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DepartName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EmpCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EmpName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EmpName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jcode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jname1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jname2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.PeriodName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.PeriodName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.SubPeriodCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SearchBankNotice>(entity =>
            {
                entity.ToView("SearchBankNotice");

                entity.Property(e => e.CheckNumber).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CurrencyCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencyDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencyDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CustomerDescA).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CustomerDescE).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SearchBoxTransferNote>(entity =>
            {
                entity.ToView("SearchBoxTransferNote");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.StrCustm1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StrCustm2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SearchDeliveRetVend>(entity =>
            {
                entity.ToView("SearchDeliveRetVend");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.VendorCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.VendorDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<SearchDepreciationDoc>(entity =>
            {
                entity.ToView("SearchDepreciationDoc");

                entity.Property(e => e.FinancialYearNameA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FinancialYearNameE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.MonthNameA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.MonthNameE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SearchEmpActivity>(entity =>
            {
                entity.ToView("SearchEmpActivity");

                entity.Property(e => e.PeriodName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.PeriodName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.SubPeriodCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SearchEmpDocument>(entity =>
            {
                entity.ToView("SearchEmpDocuments");

                entity.Property(e => e.DepartCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DepartName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DepartName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EmpCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EmpName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EmpName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jcode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jname1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jname2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.StoreCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SearchEmpLoanRequest>(entity =>
            {
                entity.ToView("SearchEmpLoanRequest");

                entity.Property(e => e.DepartCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DepartName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DepartName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EmpCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EmpName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EmpName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jcode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jname1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jname2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SearchEmpMovePromotion>(entity =>
            {
                entity.ToView("SearchEmpMovePromotion");

                entity.Property(e => e.DepartCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DepartName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DepartName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EmpCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EmpName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EmpName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jcode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jname1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jname2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SearchEmpVacation>(entity =>
            {
                entity.ToView("SearchEmpVacation");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SearchItemStockAdjustment>(entity =>
            {
                entity.ToView("SearchItemStockAdjustment");

                entity.Property(e => e.PartCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PartDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PartDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SearchJobOrderEmpCostDoc>(entity =>
            {
                entity.ToView("SearchJobOrderEmpCostDoc");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SearchJobOrderEquipCostDoc>(entity =>
            {
                entity.ToView("SearchJobOrderEquipCostDoc");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SearchJurnalEntry>(entity =>
            {
                entity.ToView("SearchJurnalEntry");

                entity.Property(e => e.JurnalDesc).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SearchKeeper>(entity =>
            {
                entity.ToView("SearchKeepers");

                entity.Property(e => e.BankDesc).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CheckNumber).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CustomerCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CustomerDescA).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CustomerDescE).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SearchLeavPermissionRequest>(entity =>
            {
                entity.ToView("SearchLeavPermissionRequest");

                entity.Property(e => e.DepartCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DepartName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DepartName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EmpCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EmpName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EmpName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jname1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jname2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SearchLeavePermision>(entity =>
            {
                entity.ToView("SearchLeavePermision");

                entity.Property(e => e.DepartCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DepartName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DepartName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EmpCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EmpName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EmpName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jname1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jname2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SearchPassPort>(entity =>
            {
                entity.ToView("SearchPassPorts");

                entity.Property(e => e.Address1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Address2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CityCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CityName).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jcode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jname1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.PassportNo).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Phone1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Phone2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Phone3).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.SeasonName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.SeasonName2).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SearchPettycash>(entity =>
            {
                entity.ToView("SearchPettycash");

                entity.Property(e => e.CurrencyCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencyDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencyDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.EmpCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SearchPrintPricing>(entity =>
            {
                entity.ToView("SearchPrintPricing");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ItemBatchCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ItemBatchName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ItemBatchName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SearchPrintQoutation>(entity =>
            {
                entity.ToView("SearchPrintQoutation");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SearchProductionOrder>(entity =>
            {
                entity.ToView("SearchProductionOrder");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SearchReqOfQoutation>(entity =>
            {
                entity.ToView("SearchReqOfQoutation");

                entity.Property(e => e.AnalyticalCodeName1).UseCollation("Arabic_BIN");

                entity.Property(e => e.AnalyticalCodeName2).UseCollation("Arabic_BIN");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SearchRewardAndPenalty>(entity =>
            {
                entity.ToView("SearchRewardAndPenalty");

                entity.Property(e => e.DepartCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DepartName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DepartName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EmpCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EmpName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EmpName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jname1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jname2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.SalaryCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.StoreCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SearchSalaryIssueDoc>(entity =>
            {
                entity.ToView("SearchSalaryIssueDoc");

                entity.Property(e => e.DepartCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DepartName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DepartName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EmpCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EmpName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EmpName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jcode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jname1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jname2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.SubPeriodCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SearchSalesOfferRequest>(entity =>
            {
                entity.ToView("SearchSalesOfferRequest");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<SearchServiceRequest>(entity =>
            {
                entity.ToView("SearchServiceRequest");

                entity.Property(e => e.AnalyticalCodeName1).UseCollation("Arabic_BIN");

                entity.Property(e => e.AnalyticalCodeName2).UseCollation("Arabic_BIN");

                entity.Property(e => e.BrandName).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CityName).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CountryName).UseCollation("Arabic_BIN");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.MaintenanceTypeName).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ProductsTypeName).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RegionNameA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ReqResourceName).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Tel).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Tel2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel3).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel4).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Wname1).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SearchShippingDeclaration>(entity =>
            {
                entity.ToView("SearchShippingDeclaration");

                entity.Property(e => e.AnalyticalCodeName1).UseCollation("Arabic_BIN");

                entity.Property(e => e.AnalyticalCodeName2).UseCollation("Arabic_BIN");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SearchStockTransferNote>(entity =>
            {
                entity.ToView("SearchStockTransferNote");

                entity.Property(e => e.PartitionFrom).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PartitionTo).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SearchStockTransferNoteRequest>(entity =>
            {
                entity.ToView("SearchStockTransferNoteRequest");

                entity.Property(e => e.PartitionFrom).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PartitionTo).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SearchTermination>(entity =>
            {
                entity.ToView("SearchTermination");

                entity.Property(e => e.DepartCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DepartName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DepartName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EmpCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EmpName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EmpName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jcode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jname1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jname2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SearchTrip>(entity =>
            {
                entity.ToView("SearchTrips");

                entity.Property(e => e.Address).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Address1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Address2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Address3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CityCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CityName).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email4).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Fax).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Tel).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Tel2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel3).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel4).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel5).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SearchVacationDoc>(entity =>
            {
                entity.ToView("SearchVacationDoc");

                entity.Property(e => e.DepartCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DepartName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DepartName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EmpCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EmpName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EmpName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jcode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jname1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jname2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SearchVacationEdit>(entity =>
            {
                entity.ToView("SearchVacationEdit");

                entity.Property(e => e.DepartCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DepartName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DepartName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EmpCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EmpName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EmpName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jcode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jname1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jname2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SearchVacationRequest>(entity =>
            {
                entity.ToView("SearchVacationRequest");

                entity.Property(e => e.DepartCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DepartName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DepartName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EmpCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EmpName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EmpName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jcode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jname1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jname2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SearchVehicleJobOrder>(entity =>
            {
                entity.ToView("SearchVehicleJobOrder");

                entity.Property(e => e.Address).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Address1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Address2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.BodyNo).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DriverCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DriverName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DriverName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Email).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.EmpCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EmpName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EmpName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.GarageCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.GarageName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.GarageName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.RegNo).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Tel2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.VehicleCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.VheicleJobOrderTypeName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.VorderTypeCode).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SearchVehicleMovement>(entity =>
            {
                entity.ToView("SearchVehicleMovement");

                entity.Property(e => e.AnName).UseCollation("Arabic_BIN");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.VendorCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.VendorDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.VendorDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<SearchVehicleRenalContract>(entity =>
            {
                entity.ToView("SearchVehicleRenalContract");

                entity.Property(e => e.Address).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Address1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Address2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Address3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.BodyNo).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Color).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CustId).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DriverName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DriverName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Email).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email4).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Fax).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FirstDriverCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.HotelCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.HotelName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.HotelName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MotorNo).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.RegNo).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.SecondDriverCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.SecondDriverName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.SecondDriverName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Tel2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel3).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel4).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel5).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ThirdDriverCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ThirdDriverName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ThirdDriverName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.VehicleCode).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SearchWeightCard>(entity =>
            {
                entity.ToView("SearchWeightCard");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SrAccomodation>(entity =>
            {
                entity.Property(e => e.AccomodationType).HasComment("1 RO,2 BB,3 HB,4 FB");

                entity.HasOne(d => d.Hotel)
                    .WithMany(p => p.SrAccomodations)
                    .HasForeignKey(d => d.HotelId)
                    .HasConstraintName("FK_Sr_Accomodation_Sr_Hotels");

                entity.HasOne(d => d.Trip)
                    .WithMany(p => p.SrAccomodations)
                    .HasForeignKey(d => d.TripId)
                    .HasConstraintName("FK_Sr_Accomodation_Sr_Trips");
            });

            modelBuilder.Entity<SrBrand>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<SrContainerType>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SrDriver>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DriverCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remark).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SrEmpServicType>(entity =>
            {
                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.SrEmpServicTypes)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_Sr_EmpServicTypes_Hr_Employees");

                entity.HasOne(d => d.SrTyp)
                    .WithMany(p => p.SrEmpServicTypes)
                    .HasForeignKey(d => d.SrTypId)
                    .HasConstraintName("FK_Sr_EmpServicTypes_Sr_ServiceTypes");
            });

            modelBuilder.Entity<SrExtension>(entity =>
            {
                entity.Property(e => e.Number).HasComment("single, double, Trible");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.SrExtensions)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_Sr_Extension_MSGA_City");

                entity.HasOne(d => d.Hotel)
                    .WithMany(p => p.SrExtensions)
                    .HasForeignKey(d => d.HotelId)
                    .HasConstraintName("FK_Sr_Extension_Sr_Hotels");

                entity.HasOne(d => d.Trip)
                    .WithMany(p => p.SrExtensions)
                    .HasForeignKey(d => d.TripId)
                    .HasConstraintName("FK_Sr_Extension_Sr_Trips");
            });

            modelBuilder.Entity<SrFlateRate>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<SrFlight>(entity =>
            {
                entity.HasOne(d => d.Trip)
                    .WithMany(p => p.SrFlights)
                    .HasForeignKey(d => d.TripId)
                    .HasConstraintName("FK_Sr_Flight_Sr_Trips");
            });

            modelBuilder.Entity<SrGarage>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.GarageCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remark).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SrHarbor>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SrHotel>(entity =>
            {
                entity.HasKey(e => e.HotelId)
                    .HasName("PK_Sr_Hoterls");

                entity.Property(e => e.Address).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Address1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Address2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Address3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Email).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email4).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Fax).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.HotelCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remark).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Tel2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel3).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel4).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel5).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.SrHotels)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_Sr_Hotels_MSGA_City");
            });

            modelBuilder.Entity<SrJobAdditionalCost>(entity =>
            {
                entity.HasOne(d => d.Jorder)
                    .WithMany(p => p.SrJobAdditionalCosts)
                    .HasForeignKey(d => d.JorderId)
                    .HasConstraintName("FK_Sr_JobAdditionalCost_Sr_JobOrder");
            });

            modelBuilder.Entity<SrJobComment>(entity =>
            {
                entity.HasOne(d => d.Jorder)
                    .WithMany(p => p.SrJobComments)
                    .HasForeignKey(d => d.JorderId)
                    .HasConstraintName("FK_Sr_JobComments_Sr_JobOrder");
            });

            modelBuilder.Entity<SrJobExtrnalExpen>(entity =>
            {
                entity.HasOne(d => d.Jorder)
                    .WithMany(p => p.SrJobExtrnalExpens)
                    .HasForeignKey(d => d.JorderId)
                    .HasConstraintName("FK_Sr_JobExtrnalExpens_Sr_JobOrder");
            });

            modelBuilder.Entity<SrJobFile>(entity =>
            {
                entity.Property(e => e.Binary).IsFixedLength();

                entity.HasOne(d => d.Jorder)
                    .WithMany(p => p.SrJobFiles)
                    .HasForeignKey(d => d.JorderId)
                    .HasConstraintName("FK_Sr_JobFiles_Sr_JobOrder");
            });

            modelBuilder.Entity<SrJobOrder>(entity =>
            {
                entity.HasOne(d => d.Reciption)
                    .WithMany(p => p.SrJobOrders)
                    .HasForeignKey(d => d.ReciptionId)
                    .HasConstraintName("FK_Sr_JobOrder_Sr_Reciption");

                entity.HasOne(d => d.SrTyp)
                    .WithMany(p => p.SrJobOrders)
                    .HasForeignKey(d => d.SrTypId)
                    .HasConstraintName("FK_Sr_JobOrder_Sr_ServiceTypes");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.SrJobOrders)
                    .HasForeignKey(d => d.VehicleId)
                    .HasConstraintName("FK_Sr_JobOrder_Sr_Vehicles");
            });

            modelBuilder.Entity<SrJobSpart>(entity =>
            {
                entity.HasOne(d => d.Jorder)
                    .WithMany(p => p.SrJobSparts)
                    .HasForeignKey(d => d.JorderId)
                    .HasConstraintName("FK_Sr_JobSparts_Sr_JobOrder");
            });

            modelBuilder.Entity<SrJobSwage>(entity =>
            {
                entity.HasOne(d => d.Jorder)
                    .WithMany(p => p.SrJobSwages)
                    .HasForeignKey(d => d.JorderId)
                    .HasConstraintName("FK_Sr_JobSWages_Sr_JobOrder");
            });

            modelBuilder.Entity<SrMalfunction>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<SrProductsType>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<SrProgram>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Number).HasComment("single, double, Trible");

                entity.Property(e => e.Remark).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SrReceptionImage>(entity =>
            {
                entity.HasOne(d => d.Reciption)
                    .WithMany(p => p.SrReceptionImages)
                    .HasForeignKey(d => d.ReciptionId)
                    .HasConstraintName("FK_Sr_ReceptionImages_Sr_Reciption");
            });

            modelBuilder.Entity<SrReciptionDetail>(entity =>
            {
                entity.HasOne(d => d.Com)
                    .WithMany(p => p.SrReciptionDetails)
                    .HasForeignKey(d => d.ComId)
                    .HasConstraintName("FK_Sr_ReciptionDetail_Sr_Complaints");

                entity.HasOne(d => d.Reciption)
                    .WithMany(p => p.SrReciptionDetails)
                    .HasForeignKey(d => d.ReciptionId)
                    .HasConstraintName("FK_Sr_ReciptionDetail_Sr_Reciption");
            });

            modelBuilder.Entity<SrReqOfQoutation>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<SrServiceDistribution>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<SrServiceDistributionDetail>(entity =>
            {
                entity.HasOne(d => d.SerDist)
                    .WithMany(p => p.SrServiceDistributionDetails)
                    .HasForeignKey(d => d.SerDistId)
                    .HasConstraintName("FK_Sr_ServiceDistributionDetails_Sr_ServiceDistribution");
            });

            modelBuilder.Entity<SrServiceRequest>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemStatus).HasComment("1 Good,2 Weak, Perfect 3");

                entity.Property(e => e.RequestStatus).HasComment("1 opened,2 closed");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<SrServiceRequestResource>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<SrShippingDeclaration>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<SrTask>(entity =>
            {
                entity.HasOne(d => d.Com)
                    .WithMany(p => p.SrTasks)
                    .HasForeignKey(d => d.ComId)
                    .HasConstraintName("FK_Sr_Tasks_Sr_Complaints");
            });

            modelBuilder.Entity<SrTaskEmp>(entity =>
            {
                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.SrTaskEmps)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_Sr_TaskEmp_Hr_Employees");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.SrTaskEmps)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("FK_Sr_TaskEmp_Sr_Tasks");
            });

            modelBuilder.Entity<SrTaskItem>(entity =>
            {
                entity.HasOne(d => d.ItemCard)
                    .WithMany(p => p.SrTaskItems)
                    .HasForeignKey(d => d.ItemCardId)
                    .HasConstraintName("FK_Sr_TaskItem_MS_ItemCard");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.SrTaskItems)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("FK_Sr_TaskItem_Sr_Tasks");
            });

            modelBuilder.Entity<SrTrafficLine>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remark).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SrTrafficLinePriceList>(entity =>
            {
                entity.HasOne(d => d.ContainerType)
                    .WithMany(p => p.SrTrafficLinePriceLists)
                    .HasForeignKey(d => d.ContainerTypeId)
                    .HasConstraintName("FK_Sr_TrafficLinePriceList_Sr_ContainerTypes");

                entity.HasOne(d => d.TrafficLine)
                    .WithMany(p => p.SrTrafficLinePriceLists)
                    .HasForeignKey(d => d.TrafficLineId)
                    .HasConstraintName("FK_Sr_TrafficLinePriceList_Sr_TrafficLines");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.SrTrafficLinePriceLists)
                    .HasForeignKey(d => d.VehicleId)
                    .HasConstraintName("FK_Sr_TrafficLinePriceList_Sr_Vehicles");
            });

            modelBuilder.Entity<SrTransportation>(entity =>
            {
                entity.HasOne(d => d.Trip)
                    .WithMany(p => p.SrTransportations)
                    .HasForeignKey(d => d.TripId)
                    .HasConstraintName("FK_Sr_Transportation_Sr_Trips");
            });

            modelBuilder.Entity<SrTrip>(entity =>
            {
                entity.HasKey(e => e.TripId)
                    .HasName("PK_St_Trips");

                entity.Property(e => e.Address).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Address1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Address2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Address3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Email).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email4).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Fax).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tel).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Tel2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel3).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel4).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel5).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SrTripAccomDetail>(entity =>
            {
                entity.HasOne(d => d.Accomodation)
                    .WithMany(p => p.SrTripAccomDetails)
                    .HasForeignKey(d => d.AccomodationId)
                    .HasConstraintName("FK_Sr_TripAccomDetail_Sr_Accomodation");
            });

            modelBuilder.Entity<SrTripProgramJoin>(entity =>
            {
                entity.Property(e => e.Number).HasComment("single, double, Trible");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.SrTripProgramJoins)
                    .HasForeignKey(d => d.ProgramId)
                    .HasConstraintName("FK_Sr_TripProgramJoin_Sr_Programs");

                entity.HasOne(d => d.Trip)
                    .WithMany(p => p.SrTripProgramJoins)
                    .HasForeignKey(d => d.TripId)
                    .HasConstraintName("FK_Sr_TripProgramJoin_Sr_Trips");
            });

            modelBuilder.Entity<SrVehicle>(entity =>
            {
                entity.HasKey(e => e.VehicleId)
                    .HasName("PK_Sr_Vehicles_1");

                entity.Property(e => e.VehicleId).HasComment("ItemCardId");

                entity.Property(e => e.BodyNo).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Color).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MotorNo).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.RegNo).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.VehicleCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.VtypeConcrete).HasComment("1 car,2 pump");

                entity.HasOne(d => d.Garage)
                    .WithMany(p => p.SrVehicles)
                    .HasForeignKey(d => d.GarageId)
                    .HasConstraintName("FK_Sr_Vehicles_Sr_Garage");

                entity.HasOne(d => d.VehicleShape)
                    .WithMany(p => p.SrVehicles)
                    .HasForeignKey(d => d.VehicleShapeId)
                    .HasConstraintName("FK_Sr_Vehicles_Sr_VehicleShapes");

                entity.HasOne(d => d.VehicleTyp)
                    .WithMany(p => p.SrVehicles)
                    .HasForeignKey(d => d.VehicleTypId)
                    .HasConstraintName("FK_Sr_Vehicles_Sr_VehicleTypes");

                entity.HasOne(d => d.WidNavigation)
                    .WithMany(p => p.SrVehicles)
                    .HasForeignKey(d => d.Wid)
                    .HasConstraintName("FK_Sr_Vehicles_Sr_Warranty");
            });

            modelBuilder.Entity<SrVehicleItemCard>(entity =>
            {
                entity.HasOne(d => d.ItemCard)
                    .WithMany(p => p.SrVehicleItemCards)
                    .HasForeignKey(d => d.ItemCardId)
                    .HasConstraintName("FK_Sr_VehicleItemCard_MS_ItemCard");
            });

            modelBuilder.Entity<SrVehicleJobOrder>(entity =>
            {
                entity.Property(e => e.Address).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Address1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Address2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Address3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email4).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Fax).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsClosed).HasComment("True Closed ;  False  Not Closed");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tel).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Tel2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel3).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel4).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel5).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.VehicleId).HasComment("ItemCardId");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.SrVehicleJobOrders)
                    .HasForeignKey(d => d.VehicleId)
                    .HasConstraintName("FK_Sr_VehicleJobOrder_Sr_Vehicles");

                entity.HasOne(d => d.VorderType)
                    .WithMany(p => p.SrVehicleJobOrders)
                    .HasForeignKey(d => d.VorderTypeId)
                    .HasConstraintName("FK_Sr_VehicleJobOrder_Sr_VheicleJobOrderType");
            });

            modelBuilder.Entity<SrVehicleJobOrderDetail>(entity =>
            {
                entity.HasOne(d => d.Driver)
                    .WithMany(p => p.SrVehicleJobOrderDetails)
                    .HasForeignKey(d => d.DriverId)
                    .HasConstraintName("FK_Sr_VehicleJobOrderDetail_Sr_Drivers");

                entity.HasOne(d => d.Vjorder)
                    .WithMany(p => p.SrVehicleJobOrderDetails)
                    .HasForeignKey(d => d.VjorderId)
                    .HasConstraintName("FK_Sr_VehicleJobOrderDetail_Sr_VehicleJobOrder");
            });

            modelBuilder.Entity<SrVehicleMovement>(entity =>
            {
                entity.Property(e => e.AccountId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.AccountTableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DbtableId).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DbtableName).HasComment("to attach any document in database to receiptnote");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<SrVehicleMovementDetail>(entity =>
            {
                entity.Property(e => e.VehicleId).HasComment("ItemCardId");

                entity.HasOne(d => d.VehiclMov)
                    .WithMany(p => p.SrVehicleMovementDetails)
                    .HasForeignKey(d => d.VehiclMovId)
                    .HasConstraintName("FK_Sr_VehicleMovementDetails_Sr_VehicleMovement");
            });

            modelBuilder.Entity<SrVehicleRenalContract>(entity =>
            {
                entity.Property(e => e.Address).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Address1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Address2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Address3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email4).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Fax).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tel).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Tel2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel3).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel4).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel5).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.VehicleId).HasComment("ItemCardId");
            });

            modelBuilder.Entity<SrVehicleRentPayJoin>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.Pay)
                    .WithMany(p => p.SrVehicleRentPayJoins)
                    .HasForeignKey(d => d.PayId)
                    .HasConstraintName("FK_Sr_VehicleRentPayJoin_MS_PaymentNote");

                entity.HasOne(d => d.VrentContract)
                    .WithMany(p => p.SrVehicleRentPayJoins)
                    .HasForeignKey(d => d.VrentContractId)
                    .HasConstraintName("FK_Sr_VehicleRentPayJoin_Sr_VehicleRenalContract");
            });

            modelBuilder.Entity<SrVehicleRentPurchJoin>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.PurInv)
                    .WithMany(p => p.SrVehicleRentPurchJoins)
                    .HasForeignKey(d => d.PurInvId)
                    .HasConstraintName("FK_Sr_VehicleRentPurchJoin_MS_PurchasInvoice");

                entity.HasOne(d => d.VrentContract)
                    .WithMany(p => p.SrVehicleRentPurchJoins)
                    .HasForeignKey(d => d.VrentContractId)
                    .HasConstraintName("FK_Sr_VehicleRentPurchJoin_Sr_VehicleRenalContract");
            });

            modelBuilder.Entity<SrVehicleRentRecJoin>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.Rect)
                    .WithMany(p => p.SrVehicleRentRecJoins)
                    .HasForeignKey(d => d.RectId)
                    .HasConstraintName("FK_Sr_VehicleRentRecJoin_Ms_ReceiptNote");

                entity.HasOne(d => d.VrentContract)
                    .WithMany(p => p.SrVehicleRentRecJoins)
                    .HasForeignKey(d => d.VrentContractId)
                    .HasConstraintName("FK_Sr_VehicleRentRecJoin_Sr_VehicleRenalContract");
            });

            modelBuilder.Entity<SrVehicleRentSalesInvJoin>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.Inv)
                    .WithMany(p => p.SrVehicleRentSalesInvJoins)
                    .HasForeignKey(d => d.InvId)
                    .HasConstraintName("FK_Sr_VehicleRentSalesInvJoin_Ms_SalesInvoice");

                entity.HasOne(d => d.VrentContract)
                    .WithMany(p => p.SrVehicleRentSalesInvJoins)
                    .HasForeignKey(d => d.VrentContractId)
                    .HasConstraintName("FK_Sr_VehicleRentSalesInvJoin_Sr_VehicleRenalContract");
            });

            modelBuilder.Entity<SrVehicleShape>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remark).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ShapeCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SrVehicleType>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remark).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TypeCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SrVheicleJobOrderType>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remark).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.VorderTypeCode).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SrWarranty>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Wcode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Wconditions).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Wmethod).HasComment("0 periodic,1 distance, 2 both");

                entity.Property(e => e.Wname1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Wname2).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<StockArchive>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Name1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Name2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<StockBroker>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Name1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Name2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<StockCapitalUpdate>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.Stock)
                    .WithMany(p => p.StockCapitalUpdates)
                    .HasForeignKey(d => d.StockId)
                    .HasConstraintName("FK_Stock_CapitalUpdate_Stock_Stocks");
            });

            modelBuilder.Entity<StockCashTransfer>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<StockCashWithdrawalReason>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Name1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Name2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<StockCategory>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Name1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Name2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<StockDealer>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Name1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Name2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<StockMarket>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Name1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Name2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<StockOpenningBalance>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<StockOpenningBalanceDetail>(entity =>
            {
                entity.Property(e => e.StockOpenDetailId).ValueGeneratedNever();

                entity.HasOne(d => d.StockOpen)
                    .WithMany(p => p.StockOpenningBalanceDetails)
                    .HasForeignKey(d => d.StockOpenId)
                    .HasConstraintName("FK_Stock_OpenningBalanceDetails_Stock_OpenningBalance");
            });

            modelBuilder.Entity<StockPortfolio>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Name1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Name2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<StockPortfolioAccount>(entity =>
            {
                entity.HasOne(d => d.Account)
                    .WithMany(p => p.StockPortfolioAccounts)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_Stock_PortfolioAccounts_Cal_AccountChart");

                entity.HasOne(d => d.StockPortfolio)
                    .WithMany(p => p.StockPortfolioAccounts)
                    .HasForeignKey(d => d.StockPortfolioId)
                    .HasConstraintName("FK_Stock_PortfolioAccounts_Stock_Portfolio");
            });

            modelBuilder.Entity<StockPortfolioStock>(entity =>
            {
                entity.HasOne(d => d.Stock)
                    .WithMany(p => p.StockPortfolioStocks)
                    .HasForeignKey(d => d.StockId)
                    .HasConstraintName("FK_Stock_PortfolioStocks_Stock_Stocks");

                entity.HasOne(d => d.StockPortfolio)
                    .WithMany(p => p.StockPortfolioStocks)
                    .HasForeignKey(d => d.StockPortfolioId)
                    .HasConstraintName("FK_Stock_PortfolioStocks_Stock_Portfolio");
            });

            modelBuilder.Entity<StockPortfolioStockArchive>(entity =>
            {
                entity.HasOne(d => d.StockArch)
                    .WithMany(p => p.StockPortfolioStockArchives)
                    .HasForeignKey(d => d.StockArchId)
                    .HasConstraintName("FK_Stock_PortfolioStockArchives_Stock_Archives");

                entity.HasOne(d => d.StockPortJoin)
                    .WithMany(p => p.StockPortfolioStockArchives)
                    .HasForeignKey(d => d.StockPortJoinId)
                    .HasConstraintName("FK_Stock_PortfolioStockArchives_Stock_PortfolioStocks");
            });

            modelBuilder.Entity<StockRecCustSearch>(entity =>
            {
                entity.ToView("stockRecCustSearch");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<StockRecSearch>(entity =>
            {
                entity.ToView("StockRecSearch");

                entity.Property(e => e.CustomerCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CustomerDescA).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<StockRecVendSearch>(entity =>
            {
                entity.ToView("StockRecVendSearch");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.VendorCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.VendorDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<StockSalesPurchase>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<StockSalesPurchaseDetail>(entity =>
            {
                entity.HasOne(d => d.StockSalPurch)
                    .WithMany(p => p.StockSalesPurchaseDetails)
                    .HasForeignKey(d => d.StockSalPurchId)
                    .HasConstraintName("FK_Stock_SalesPurchaseDetails_Stock_SalesPurchase");
            });

            modelBuilder.Entity<StockSector>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Name1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Name2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<StockShareholdersName>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Name1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Name2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<StockStock>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Name1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Name2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.StockCat)
                    .WithMany(p => p.StockStocks)
                    .HasForeignKey(d => d.StockCatId)
                    .HasConstraintName("FK_Stock_Stocks_Stock_Categories");

                entity.HasOne(d => d.StockMarket)
                    .WithMany(p => p.StockStocks)
                    .HasForeignKey(d => d.StockMarketId)
                    .HasConstraintName("FK_Stock_Stocks_Stock_Markets");

                entity.HasOne(d => d.StockSectors)
                    .WithMany(p => p.StockStocks)
                    .HasForeignKey(d => d.StockSectorsId)
                    .HasConstraintName("FK_Stock_Stocks_Stock_Sectors");
            });

            modelBuilder.Entity<StockTranType>(entity =>
            {
                entity.Property(e => e.CashEffect1).HasComment("1 Plus, 2 Minus, 3 Without");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StockEffect).HasComment("1 Plus, 2 Minus, 3 Without");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<StockTransfer>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<StockTransferDetail>(entity =>
            {
                entity.HasOne(d => d.StockTransfer)
                    .WithMany(p => p.StockTransferDetails)
                    .HasForeignKey(d => d.StockTransferId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Stock_TransferDetail_Stock_Transfer");
            });

            modelBuilder.Entity<SysAnalyticalCode>(entity =>
            {
                entity.Property(e => e.DescA).UseCollation("Arabic_BIN");

                entity.Property(e => e.DescE).UseCollation("Arabic_BIN");

                entity.Property(e => e.RemarksA).UseCollation("Arabic_BIN");

                entity.Property(e => e.RemarksE).UseCollation("Arabic_BIN");
            });

            modelBuilder.Entity<SysAnalyticalCodeProccess>(entity =>
            {
                entity.HasOne(d => d.AidNavigation)
                    .WithMany(p => p.SysAnalyticalCodeProccesses)
                    .HasForeignKey(d => d.Aid)
                    .HasConstraintName("FK_sys_AnalyticalCodeProccess_Sys_AnalyticalCodes");
            });

            modelBuilder.Entity<SysAnalyticalCodeUpdate>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.AidNavigation)
                    .WithMany(p => p.SysAnalyticalCodeUpdates)
                    .HasForeignKey(d => d.Aid)
                    .HasConstraintName("FK_sys_AnalyticalCodeUpdates_Sys_AnalyticalCodes");
            });

            modelBuilder.Entity<SysAnalyticalCodeUpdateType>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<SysBasket>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DocName).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DocTrNo).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Message).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SysBook>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<SysCity>(entity =>
            {
                entity.Property(e => e.CityName).UseCollation("Arabic_BIN");

                entity.Property(e => e.CountryCode).UseCollation("Arabic_BIN");

                entity.Property(e => e.Latitude).UseCollation("Arabic_BIN");

                entity.Property(e => e.Longitude).UseCollation("Arabic_BIN");
            });

            modelBuilder.Entity<SysCounter>(entity =>
            {
                entity.Property(e => e.TrIdName).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<SysCountry>(entity =>
            {
                entity.Property(e => e.CountryCode).UseCollation("Arabic_BIN");

                entity.Property(e => e.CountryId).ValueGeneratedOnAdd();

                entity.Property(e => e.CountryName).UseCollation("Arabic_BIN");

                entity.Property(e => e.Latitude).UseCollation("Arabic_BIN");

                entity.Property(e => e.Longitude).UseCollation("Arabic_BIN");
            });

            modelBuilder.Entity<SysFinancialInterval>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.EndToHijri).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.MonthNameA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.MonthNameE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StartingFromHijri).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.HasOne(d => d.FinancialYear)
                    .WithMany(p => p.SysFinancialIntervals)
                    .HasForeignKey(d => d.FinancialYearId)
                    .HasConstraintName("FK_Sys_FinancialIntervals_Sys_FinancialYears");
            });

            modelBuilder.Entity<SysFinancialYear>(entity =>
            {
                entity.Property(e => e.ClosingDateHijri).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.EndToHijri).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FinancialYearNameA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FinancialYearNameE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StartingFromHijri).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.YearState).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<SysFinancialYearsClosing>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<SysLog>(entity =>
            {
                entity.Property(e => e.FieldDetail).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.FieldName).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.FieldNameAr).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.LogAction).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.NewValue).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.OldValue).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ScreenName).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ScreenNameAr).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TablDetailName).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TablName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SysNaming>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<SysNotification>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<SysNotificationType>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RemarksE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<SysRemotBranchesLog>(entity =>
            {
                entity.Property(e => e.LogTimStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.LogType).HasComment("1 insert,2 update,3 delete");
            });

            modelBuilder.Entity<SysRemotLogDetail>(entity =>
            {
                entity.Property(e => e.LogType).HasComment("1 insert,2 update,3 delete,4 print, preview");

                entity.HasOne(d => d.Log)
                    .WithMany(p => p.SysRemotLogDetails)
                    .HasForeignKey(d => d.LogId)
                    .HasConstraintName("FK_Sys_RemotLogDetail_Sys_RemotTranLog");
            });

            modelBuilder.Entity<SysRemotTranLog>(entity =>
            {
                entity.Property(e => e.LogTimStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.LogType).HasComment("1 insert,2 update,3 delete");
            });

            modelBuilder.Entity<SysRemoteBranchesLogDetaile>(entity =>
            {
                entity.Property(e => e.LogType).HasComment("1 insert,2 update,3 delete,4 print, preview");

                entity.HasOne(d => d.Log)
                    .WithMany(p => p.SysRemoteBranchesLogDetailes)
                    .HasForeignKey(d => d.LogId)
                    .HasConstraintName("FK_SysRemoteBranchesLogDetaile_Sys_RemotBranchesLog");
            });

            modelBuilder.Entity<TrOpenningBalance>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<TrOpenningBalanceDetail>(entity =>
            {
                entity.HasOne(d => d.TrOpenningBalance)
                    .WithMany(p => p.TrOpenningBalanceDetails)
                    .HasForeignKey(d => d.TrOpenningBalanceId)
                    .HasConstraintName("FK_Tr_OpenningBalanceDetails_Tr_OpenningBalance");
            });

            modelBuilder.Entity<VdeliverSalesInvfilter>(entity =>
            {
                entity.ToView("VDeliverSalesInvfilter");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<VwAccountClassification>(entity =>
            {
                entity.ToView("VW_AccountClassification");

                entity.Property(e => e.AccountCatDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.AccountCatDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<VwAllAccountsTransaction>(entity =>
            {
                entity.ToView("VW_AllAccountsTransactions");

                entity.Property(e => e.AccountCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.AccountNameA).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.AnalizName1).UseCollation("Arabic_BIN");

                entity.Property(e => e.AnalizName2).UseCollation("Arabic_BIN");

                entity.Property(e => e.CheckNumber).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CurrencyCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencyDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CustomerDescA).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.HelpAccType).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.RemarksA)
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.SourceCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.SourceName).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.StoreCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TableCode).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<VwAllAnalyticalCodTransaction>(entity =>
            {
                entity.ToView("VW_AllAnalyticalCodTransactions");

                entity.Property(e => e.AccountNameA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.AccountNameE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CostCenterNameA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CostCenterNameE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencyCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencyDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencySymbol).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("Arabic_BIN");

                entity.Property(e => e.DescE).UseCollation("Arabic_BIN");

                entity.Property(e => e.DocRemarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.RemarksA).UseCollation("Arabic_BIN");

                entity.Property(e => e.RemarksE).UseCollation("Arabic_BIN");
            });

            modelBuilder.Entity<VwAllAnalyticalCodTransactionsDetail>(entity =>
            {
                entity.ToView("VW_AllAnalyticalCodTransactionsDetails");

                entity.Property(e => e.AccountNameA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.AccountNameE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CostCenterNameA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CostCenterNameE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencyCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencyDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencySymbol).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("Arabic_BIN");

                entity.Property(e => e.DescE).UseCollation("Arabic_BIN");

                entity.Property(e => e.DocRemarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ItemCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ItemDescA).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ItemDescE).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.RemarksA).UseCollation("Arabic_BIN");

                entity.Property(e => e.RemarksE).UseCollation("Arabic_BIN");
            });

            modelBuilder.Entity<VwAllCostCenterTransaction>(entity =>
            {
                entity.ToView("VW_AllCostCenterTransactions");

                entity.Property(e => e.CostCenterNameA).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CurrencyCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencyDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CustomerDescA).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.HelpCostCenterType).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TableCode).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<VwAllJobOrder>(entity =>
            {
                entity.ToView("VW_AllJobOrders");

                entity.Property(e => e.Address).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Address1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Fax).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<VwAllJobOrderDocument>(entity =>
            {
                entity.ToView("vw_AllJobOrderDocuments");
            });

            modelBuilder.Entity<VwAllLetOfGtransaction>(entity =>
            {
                entity.ToView("VW_AllLetOfGTransactions");

                entity.Property(e => e.CurrencyCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencyDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencySymbol).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<VwAllRepairOrder>(entity =>
            {
                entity.ToView("VW_AllRepairOrders");

                entity.Property(e => e.CurrencyCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencyDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencySymbol).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<VwAllSrJobOrderMotor>(entity =>
            {
                entity.ToView("VW_AllSrJobOrderMotors");

                entity.Property(e => e.CurrencyCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencyDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencySymbol).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<VwAllVehicleJobOrdersDoc>(entity =>
            {
                entity.ToView("VW_AllVehicleJobOrdersDocs");

                entity.Property(e => e.CurrencyCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencyDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencySymbol).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DocRemarks).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<VwAttendTime>(entity =>
            {
                entity.ToView("VW_AttendTime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwCustomerCategory>(entity =>
            {
                entity.ToView("VW_CustomerCategory");

                entity.Property(e => e.Address).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CatCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CatDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CatDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Tel).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<VwDailyTransaction>(entity =>
            {
                entity.ToView("VW_DailyTransactions");

                entity.Property(e => e.AnalizName1).UseCollation("Arabic_BIN");

                entity.Property(e => e.AnalizName2).UseCollation("Arabic_BIN");

                entity.Property(e => e.CurrencyCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencyDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencyDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CustomerDescA).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.SourceCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.SourceName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<VwEmpAttendanceTran>(entity =>
            {
                entity.ToView("VW_EmpAttendanceTran");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DepartCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DepartName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DepartName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EmpCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jcode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jname1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Jname2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.PeriodCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.PeriodName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.PeriodName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.StoreCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.SubPeriodCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.SubPeriodName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.SubPeriodName2).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<VwGetAdjustMentsByCust>(entity =>
            {
                entity.ToView("VW_GetAdjustMentsByCust");

                entity.Property(e => e.CurrencyDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<VwGetAdjustMentsByVend>(entity =>
            {
                entity.ToView("VW_GetAdjustMentsByVend");

                entity.Property(e => e.CurrencyDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.VendorCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.VendorDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<VwGetAdjustMentsRank>(entity =>
            {
                entity.ToView("VW_GetAdjustMentsRank");

                entity.Property(e => e.AdjustId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetAllBatch>(entity =>
            {
                entity.ToView("VW_GetAllBatches");

                entity.Property(e => e.ItemBatchCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ItemBatchName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ItemBatchName2).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<VwGetAnalyticalCodeRank>(entity =>
            {
                entity.ToView("VW_GetAnalyticalCodeRank");

                entity.Property(e => e.Aid).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetAssetRank>(entity =>
            {
                entity.ToView("VW_GetAssetRank");

                entity.Property(e => e.AssetId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetAssetSettingsRank>(entity =>
            {
                entity.ToView("VW_GetAssetSettingsRank");

                entity.Property(e => e.AssetSetId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetAssetTerminationRank>(entity =>
            {
                entity.ToView("VW_GetAssetTerminationRank");

                entity.Property(e => e.AssetTerminatId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetAttendanceDocRank>(entity =>
            {
                entity.ToView("VW_GetAttendanceDocRank");

                entity.Property(e => e.AttendDocId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetBankNoticeRank>(entity =>
            {
                entity.ToView("VW_GetBankNoticeRank");

                entity.Property(e => e.BankNoticId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetBomrank>(entity =>
            {
                entity.ToView("VW_GetBOMRank");

                entity.Property(e => e.BillOfMaterialId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetBoxTransferNoteRank>(entity =>
            {
                entity.ToView("VW_GetBoxTransferNoteRank");

                entity.Property(e => e.BoxTranId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetCurrencyRank>(entity =>
            {
                entity.ToView("VW_GetCurrencyRank");

                entity.Property(e => e.CurrencyCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencyId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetCustomersRank>(entity =>
            {
                entity.ToView("VW_GetCustomersRank");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetDeliverSalesInvoiceByCust>(entity =>
            {
                entity.ToView("VW_GetDeliverSalesInvoiceByCust");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<VwGetDeliverSalesInvoiceByVend>(entity =>
            {
                entity.ToView("VW_GetDeliverSalesInvoiceByVend");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<VwGetDeliverSalesInvoiceRank>(entity =>
            {
                entity.ToView("VW_GetDeliverSalesInvoiceRank");

                entity.Property(e => e.DeliverId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetDepreciationDocRank>(entity =>
            {
                entity.ToView("VW_GetDepreciationDocRank");

                entity.Property(e => e.DeprDocId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetEmpActivityRank>(entity =>
            {
                entity.ToView("VW_GetEmpActivityRank");

                entity.Property(e => e.EmpActivityId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetEmpLoanRequestRank>(entity =>
            {
                entity.ToView("VW_GetEmpLoanRequestRank");

                entity.Property(e => e.EmpLoanReqId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetEmpMovePromotionRank>(entity =>
            {
                entity.ToView("VW_GetEmpMovePromotionRank");

                entity.Property(e => e.EmpMoveId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetEmpVacationRank>(entity =>
            {
                entity.ToView("VW_GetEmpVacationRank");

                entity.Property(e => e.EmpVacId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetGawabRecordRank>(entity =>
            {
                entity.ToView("VW_GetGawabRecordRank");

                entity.Property(e => e.LetterNormId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetHrTerminationRank>(entity =>
            {
                entity.ToView("VW_GetHrTerminationRank");

                entity.Property(e => e.TerminateId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetItemAlter>(entity =>
            {
                entity.ToView("VW_GetItemAlters");
            });

            modelBuilder.Entity<VwGetItemCardRank>(entity =>
            {
                entity.ToView("VW_GetItemCardRank");

                entity.Property(e => e.ItemCardId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetItemStockAdjustmentRank>(entity =>
            {
                entity.ToView("VW_GetItemStockAdjustmentRank");

                entity.Property(e => e.StockAdjustId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetJobOrderByCust>(entity =>
            {
                entity.ToView("VW_GetJobOrderByCust");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<VwGetJobOrderRank>(entity =>
            {
                entity.ToView("VW_GetJobOrderRank");

                entity.Property(e => e.JobOrderId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetJournalEntryRank>(entity =>
            {
                entity.ToView("VW_GetJournalEntryRank");

                entity.Property(e => e.JurnalId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetKeeperBankRank>(entity =>
            {
                entity.ToView("VW_GetKeeperBankRank");

                entity.Property(e => e.KeeperId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetLeavPermissionRequestRank>(entity =>
            {
                entity.ToView("VW_GetLeavPermissionRequestRank");

                entity.Property(e => e.LeavPermReqId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetLeavePermisionRank>(entity =>
            {
                entity.ToView("VW_GetLeavePermisionRank");

                entity.Property(e => e.LeavPermisionId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetNotification>(entity =>
            {
                entity.ToView("VW_GetNotifications");

                entity.Property(e => e.CurrentUser).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DepartCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DepartName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DepartName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DocName).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DocTrNo).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Message).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.SenderUser).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UserCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<VwGetPassPortRank>(entity =>
            {
                entity.ToView("VW_GetPassPortRank");

                entity.Property(e => e.WfpassPortId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetPaymentNoteByCust>(entity =>
            {
                entity.ToView("VW_GetPaymentNoteByCust");

                entity.Property(e => e.CurrencyDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<VwGetPaymentNoteByVend>(entity =>
            {
                entity.ToView("VW_GetPaymentNoteByVend");

                entity.Property(e => e.CurrencyDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<VwGetPaymentNoteRank>(entity =>
            {
                entity.ToView("VW_GetPaymentNoteRank");

                entity.Property(e => e.PayId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetPettycashRank>(entity =>
            {
                entity.ToView("VW_GetPettycashRank");

                entity.Property(e => e.PettycashId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetPettycashSearch>(entity =>
            {
                entity.ToView("VW_GetPettycashSearch");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<VwGetProductionOrdeRank>(entity =>
            {
                entity.ToView("VW_GetProductionOrdeRank");

                entity.Property(e => e.ProductionOrderId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetPurchasInvoiceByVend>(entity =>
            {
                entity.ToView("VW_GetPurchasInvoiceByVend");

                entity.Property(e => e.CurrencyDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.InvDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.InvDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.VendorCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.VendorDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<VwGetPurchasInvoiceRank>(entity =>
            {
                entity.ToView("VW_GetPurchasInvoiceRank");

                entity.Property(e => e.PurInvId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetPurchasOrderByVend>(entity =>
            {
                entity.ToView("VW_GetPurchasOrderByVend");

                entity.Property(e => e.CurrencyDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.VendorCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.VendorDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<VwGetPurchasOrderRank>(entity =>
            {
                entity.ToView("VW_GetPurchasOrderRank");

                entity.Property(e => e.PurOrderId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetPurchasOrderRequestRank>(entity =>
            {
                entity.ToView("VW_GetPurchasOrderRequestRank");

                entity.Property(e => e.PurOrderReqId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetReceiptNoteByCust>(entity =>
            {
                entity.ToView("VW_GetReceiptNoteByCust");

                entity.Property(e => e.CurrencyDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<VwGetReceiptNoteByVend>(entity =>
            {
                entity.ToView("VW_GetReceiptNoteByVend");

                entity.Property(e => e.CurrencyDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<VwGetReceiptNoteRank>(entity =>
            {
                entity.ToView("VW_GetReceiptNoteRank");

                entity.Property(e => e.RectId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetRecipeRank>(entity =>
            {
                entity.ToView("VW_GetRecipeRank");

                entity.Property(e => e.RecipeId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetReturnPurchaseByVend>(entity =>
            {
                entity.ToView("VW_GetReturnPurchaseByVend");

                entity.Property(e => e.CurrencyDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.InvDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.InvDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.VendorCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.VendorDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<VwGetReturnPurchaseRank>(entity =>
            {
                entity.ToView("VW_GetReturnPurchaseRank");

                entity.Property(e => e.RetPurchId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetReturnSalesByCust>(entity =>
            {
                entity.ToView("VW_GetReturnSalesByCust");

                entity.Property(e => e.CurrencyDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.InvDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.InvDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<VwGetReturnSalesRank>(entity =>
            {
                entity.ToView("VW_GetReturnSalesRank");

                entity.Property(e => e.RetSaleId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetRewardAndPenaltyRank>(entity =>
            {
                entity.ToView("VW_GetRewardAndPenaltyRank");

                entity.Property(e => e.RewardId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetSalaryIssueDocRank>(entity =>
            {
                entity.ToView("VW_GetSalaryIssueDocRank");

                entity.Property(e => e.SalaryIssuDocId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetSalesInvByCust>(entity =>
            {
                entity.ToView("VW_GetSalesInvByCust");

                entity.Property(e => e.CurrencyDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.InvDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.InvDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<VwGetSalesInvoiceRank>(entity =>
            {
                entity.ToView("VW_GetSalesInvoiceRank");

                entity.Property(e => e.InvId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetSalesOfferByCust>(entity =>
            {
                entity.ToView("VW_GetSalesOfferByCust");

                entity.Property(e => e.CurrencyDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<VwGetSalesOfferRank>(entity =>
            {
                entity.ToView("VW_GetSalesOfferRank");

                entity.Property(e => e.SalesOfferId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetSalesOfferRequestByCust>(entity =>
            {
                entity.ToView("VW_GetSalesOfferRequestByCust");

                entity.Property(e => e.CurrencyDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<VwGetSalesOfferRequestRank>(entity =>
            {
                entity.ToView("VW_GetSalesOfferRequestRank");

                entity.Property(e => e.SalesOfferReqId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetSalesOrderByCust>(entity =>
            {
                entity.ToView("VW_GetSalesOrderByCust");

                entity.Property(e => e.CurrencyDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<VwGetSalesOrderRank>(entity =>
            {
                entity.ToView("VW_GetSalesOrderRank");

                entity.Property(e => e.SalesOrderId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetStockRecriptByCust>(entity =>
            {
                entity.ToView("VW_GetStockRecriptByCust");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<VwGetStockRecriptByVend>(entity =>
            {
                entity.ToView("VW_GetStockRecriptByVend");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<VwGetStockRecriptRank>(entity =>
            {
                entity.ToView("VW_GetStockRecriptRank");

                entity.Property(e => e.StockRecId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetStockTransferNoteRank>(entity =>
            {
                entity.ToView("VW_GetStockTransferNoteRank");

                entity.Property(e => e.TranId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetTripsRank>(entity =>
            {
                entity.ToView("VW_GetTripsRank");

                entity.Property(e => e.TripId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetVacationDocRank>(entity =>
            {
                entity.ToView("VW_GetVacationDocRank");

                entity.Property(e => e.VacationDocId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetVacationEditRank>(entity =>
            {
                entity.ToView("VW_GetVacationEditRank");

                entity.Property(e => e.VacationEditDocId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetVacationRequestRank>(entity =>
            {
                entity.ToView("VW_GetVacationRequestRank");

                entity.Property(e => e.VacRequestId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetVehicleJobOrderRank>(entity =>
            {
                entity.ToView("VW_GetVehicleJobOrderRank");

                entity.Property(e => e.VjorderId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetVehicleRenalContractRank>(entity =>
            {
                entity.ToView("VW_GetVehicleRenalContractRank");

                entity.Property(e => e.VrentContractId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetVendorsRank>(entity =>
            {
                entity.ToView("VW_GetVendorsRank");

                entity.Property(e => e.VendorCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.VendorId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGetWeightCardRank>(entity =>
            {
                entity.ToView("VW_GetWeightCardRank");

                entity.Property(e => e.ScaleCardId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwGlclassification>(entity =>
            {
                entity.ToView("VW_GLClassification");

                entity.Property(e => e.AccountNameA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.AccountNameE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<VwHelpingAccountsSearch>(entity =>
            {
                entity.ToView("VW_HelpingAccountsSearch");

                entity.Property(e => e.AccountCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.AccountNameA).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<VwItemCard>(entity =>
            {
                entity.ToView("VW_ItemCard");

                entity.Property(e => e.ItemCatCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ItemCatDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ItemCatDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<VwItemUnitGrand>(entity =>
            {
                entity.ToView("VW_ItemUnitGrand");

                entity.Property(e => e.BarCode1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode10).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode11).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode12).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode13).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode14).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode15).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode3).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode4).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode5).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode6).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode7).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode8).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode9).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Symbol).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UnitNam).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<VwItemUnitGrandAttribute>(entity =>
            {
                entity.ToView("VW_ItemUnitGrandAttribute");

                entity.Property(e => e.BarCode1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode10).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode11).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode12).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode13).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode14).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode15).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode3).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode4).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode5).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode6).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode7).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode8).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BarCode9).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ItemBatchCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ItemBatchName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ItemBatchName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Symbol).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UnitNam).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<VwItemUnitSummary>(entity =>
            {
                entity.ToView("VW_ItemUnitSummary");

                entity.Property(e => e.Symbol).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UnitNam).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<VwJobOrder>(entity =>
            {
                entity.ToView("VW_JobOrder");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.ItemBatchCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ItemBatchName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<VwLotNumberExpiryPartition>(entity =>
            {
                entity.ToView("VW_LotNumberExpiryPartition");

                entity.Property(e => e.ItemBatchCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ItemBatchName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.PartCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PartDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PartDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks4).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks5).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks6).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks7).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Ttype)
                    .IsFixedLength()
                    .UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<VwProdItemAttribute>(entity =>
            {
                entity.ToView("VW_ProdItemAttributes");

                entity.Property(e => e.AttributCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.AttributName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.AttributName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Symbol).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UnitNam).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<VwProdItemUnit>(entity =>
            {
                entity.ToView("VW_ProdItemUnits");
            });

            modelBuilder.Entity<VwProdWorkOrderSearch>(entity =>
            {
                entity.ToView("Vw_Prod_WorkOrderSearch");

                entity.Property(e => e.CurrencyCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencyDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencyDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.EmpCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ShiftCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ShiftsName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ShiftsName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.StoreCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<VwQualityItemDeliverySearch>(entity =>
            {
                entity.ToView("Vw_Quality_ItemDeliverySearch");

                entity.Property(e => e.CurrencyCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencyDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencyDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.EmpCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ItemRecCheckEmpCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ItemRecCheckEmpName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ItemRecCheckEmpName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ShiftCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ShiftsName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ShiftsName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.StoreCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<VwQualityItemRecCheckSearch>(entity =>
            {
                entity.ToView("Vw_Quality_ItemRecCheckSearch");

                entity.Property(e => e.CurrencyCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencyDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencyDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.EmpCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ShiftCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ShiftsName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ShiftsName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.StoreCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<VwQualityItemRecieveSearch>(entity =>
            {
                entity.ToView("Vw_Quality_ItemRecieveSearch");

                entity.Property(e => e.CurrencyCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencyDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CurrencyDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.EmpCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ShiftCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ShiftsName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.ShiftsName2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.StoreCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TermCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.TermName).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<VwReservedQty>(entity =>
            {
                entity.ToView("VW_reservedQTY");

                entity.Property(e => e.StoreDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<VwSearchAllAccount>(entity =>
            {
                entity.ToView("VW_SearchAllAccounts");

                entity.Property(e => e.AccountCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.AccountNameA).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<VwSearchInstallment>(entity =>
            {
                entity.ToView("VW_SearchInstallments");

                entity.Property(e => e.CustomerCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<VwSearchRealStatUnit>(entity =>
            {
                entity.ToView("VW_SearchRealStatUnits");

                entity.Property(e => e.CustomerCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<VwSearchUnitReservation>(entity =>
            {
                entity.ToView("VW_SearchUnitReservations");

                entity.Property(e => e.CustomerCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CustomerDescA).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CustomerDescE).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<VwVendorCategory>(entity =>
            {
                entity.ToView("VW_VendorCategory");

                entity.Property(e => e.Address).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CatCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CatDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CatDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Tel).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.VendorCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.VendorDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.VendorDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<VwWeightCard>(entity =>
            {
                entity.ToView("VW_WeightCard");

                entity.Property(e => e.Addemp1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Addemp2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.BodyNo).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CityName).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DriverCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DriverName1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.EmpCode).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Empcode2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MotorNo).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.PartCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PartDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.RegNo).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.StoreCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.StoreDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.VehiclRemarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.VehicleCode).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<VwWorkForcExecluded>(entity =>
            {
                entity.ToView("VW_WorkForcExecluded");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.SeasonName2).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<VwWorkForcTemplate>(entity =>
            {
                entity.ToView("VW_WorkForcTemplates");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.SeasonName2).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<VwWorkForcTestResult>(entity =>
            {
                entity.ToView("VW_WorkForcTestResults");

                entity.Property(e => e.CustomerCode).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescA).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CustomerDescE).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.SeasonName2).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<VwsimpleAllTransaction>(entity =>
            {
                entity.ToView("VWSimpleAllTransactions");

                entity.Property(e => e.AccountNameA).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.HelpAccType).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.RemarksA)
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.TableCode).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<WorForcFirm>(entity =>
            {
                entity.Property(e => e.Address1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Address2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Address3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email4).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Fax).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Tel).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Tel2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel3).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Tel4).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<WorkForcActionType>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<WorkForcBloodExeclude>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<WorkForcBloodExecludeDetail>(entity =>
            {
                entity.HasOne(d => d.BloodExeclud)
                    .WithMany(p => p.WorkForcBloodExecludeDetails)
                    .HasForeignKey(d => d.BloodExecludId)
                    .HasConstraintName("FK_WorkForc_BloodExecludeDetails_WorkForc_BloodExeclude");
            });

            modelBuilder.Entity<WorkForcFirstCustExeclude>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<WorkForcFirstCustExecludeDetail>(entity =>
            {
                entity.HasOne(d => d.Execlud)
                    .WithMany(p => p.WorkForcFirstCustExecludeDetails)
                    .HasForeignKey(d => d.ExecludId)
                    .HasConstraintName("FK_WorkForc_FirstCustExecludeDetail_WorkForc_FirstCustExeclude");
            });

            modelBuilder.Entity<WorkForcPassPort>(entity =>
            {
                entity.Property(e => e.Address1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Address2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MaritalStatus).HasComment("0 single,1 married,2 married and have kids");

                entity.Property(e => e.PassportNo).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Phone1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Phone2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Phone3).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<WorkForcPassPortsArchive>(entity =>
            {
                entity.Property(e => e.Address1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Address2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Email).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.MaritalStatus).HasComment("0 single,1 married,2 married and have kids");

                entity.Property(e => e.PassportNo).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Phone1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Phone2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Phone3).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<WorkForcSeason>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name1).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Name2).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.Remarks).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<WorkForcSecondCustExeclude>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<WorkForcSecondCustExecludeDetail>(entity =>
            {
                entity.HasOne(d => d.ScndExeclud)
                    .WithMany(p => p.WorkForcSecondCustExecludeDetails)
                    .HasForeignKey(d => d.ScndExecludId)
                    .HasConstraintName("FK_WorkForc_SecondCustExecludeDetail_WorkForc_SecondCustExeclude");
            });

            modelBuilder.Entity<WorkForcTempId>(entity =>
            {
                entity.Property(e => e.CreatedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.DeletedBy).UseCollation("Arabic_CI_AI");

                entity.Property(e => e.UpdateBy).UseCollation("Arabic_CI_AI");
            });

            modelBuilder.Entity<WorkForcTemplate>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<WorkForcTemplatesDetail>(entity =>
            {
                entity.HasOne(d => d.Wftemp)
                    .WithMany(p => p.WorkForcTemplatesDetails)
                    .HasForeignKey(d => d.WftempId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkForc_TemplatesDetails_WorkForc_Templates");
            });

            modelBuilder.Entity<WorkForcTestResult>(entity =>
            {
                entity.Property(e => e.Closed).HasComment("True  Closed ;  False  Not Closed");

                entity.Property(e => e.CreatedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DeletedBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsPosted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks1).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks2).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Remarks3).UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UpdateBy).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<WorkForcTestResultsDetail>(entity =>
            {
                entity.HasOne(d => d.TestResult)
                    .WithMany(p => p.WorkForcTestResultsDetails)
                    .HasForeignKey(d => d.TestResultId)
                    .HasConstraintName("FK_WorkForc_TestResultsDetails_WorkForc_TestResults");
            });

            modelBuilder.Entity<YearMonthe>(entity =>
            {
                entity.Property(e => e.CustomField).UseCollation("Arabic_BIN");

                entity.Property(e => e.MontnName).UseCollation("Arabic_BIN");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
