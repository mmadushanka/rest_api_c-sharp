﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenImis.RestApi.Security
{
    public enum Rights
    {
        Family = 101000, // 0x00018A88
        FamilySearch = 101001, // 0x00018A89
        FamilyAdd = 101002, // 0x00018A8A
        FamilyEdit = 101003, // 0x00018A8B
        FamilyDelete = 101004, // 0x00018A8C
        Insuree = 101100, // 0x00018AEC
        InsureeSearch = 101101, // 0x00018AED
        InsureeAdd = 101102, // 0x00018AEE
        InsureeEdit = 101103, // 0x00018AEF
        InsureeDelete = 101104, // 0x00018AF0
        InsureeEnquire = 101105, // 0x00018AF1
        PolicySearch = 101201, // 0x00018B51
        PolicyAdd = 101202, // 0x00018B52
        PolicyEdit = 101203, // 0x00018B53
        PolicyDelete = 101204, // 0x00018B54
        PolicyRenew = 101205, // 0x00018B55
        ContributionSearch = 101301, // 0x00018BB5
        ContributionAdd = 101302, // 0x00018BB6
        ContributionEdit = 101303, // 0x00018BB7
        ContributionDelete = 101304, // 0x00018BB8
        PaymentSearch = 101401, // 0x00018C19
        PaymentAdd = 101402, // 0x00018C1A
        PaymentEdit = 101403, // 0x00018C1B
        PaymentDelete = 101404, // 0x00018C1C
        Claims = 111000, // 0x0001B198
        ClaimSearch = 111001, // 0x0001B199
        ClaimAdd = 111002, // 0x0001B19A
        ClaimDelete = 111004, // 0x0001B19C
        ClaimLoad = 111005, // 0x0001B19D
        ClaimPrint = 111006, // 0x0001B19E
        ClaimSubmit = 111007, // 0x0001B19F
        ClaimReview = 111008, // 0x0001B1A0
        ClaimFeedback = 111009, // 0x0001B1A1
        ClaimUpdate = 111010, // 0x0001B1A2
        ClaimProcess = 111011, // 0x0001B1A3
        Batch = 111100, // 0x0001B1FC
        BatchProcess = 111101, // 0x0001B1FD
        BatchFilter = 111102, // 0x0001B1FE
        BatchPreview = 111103, // 0x0001B1FF
        Product = 121000, // 0x0001D8A8
        ProductSearch = 121001, // 0x0001D8A9
        ProductAdd = 121002, // 0x0001D8AA
        ProductEdit = 121003, // 0x0001D8AB
        ProductDelete = 121004, // 0x0001D8AC
        ProductDuplicate = 121005, // 0x0001D8AD
        HealthFacility = 121100, // 0x0001D90C
        HealthFacilitySearch = 121101, // 0x0001D90D
        HealthFacilityAdd = 121102, // 0x0001D90E
        HealthFacilityEdit = 121103, // 0x0001D90F
        HealthFacilityDelete = 121104, // 0x0001D910
        PriceListMedicalServices = 121200, // 0x0001D970
        FindPriceListMedicalServices = 121201, // 0x0001D971
        AddPriceListMedicalServices = 121202, // 0x0001D972
        EditPriceListMedicalServices = 121203, // 0x0001D973
        DeletePriceListMedicalServices = 121204, // 0x0001D974
        DuplicatePriceListMedicalServices = 121205, // 0x0001D975
        PriceListMedicalItems = 121300, // 0x0001D9D4
        FindPriceListMedicalItems = 121301, // 0x0001D9D5
        AddPriceListMedicalItems = 121302, // 0x0001D9D6
        EditPriceListMedicalItems = 121303, // 0x0001D9D7
        DeletePriceListMedicalItems = 121304, // 0x0001D9D8
        DuplicatePriceListMedicalItems = 121305, // 0x0001D9D9
        MedicalService = 121400, // 0x0001DA38
        FindMedicalService = 121401, // 0x0001DA39
        AddMedicalService = 121402, // 0x0001DA3A
        EditMedicalService = 121403, // 0x0001DA3B
        DeleteMedicalService = 121404, // 0x0001DA3C
        Officer = 121500, // 0x0001DA9C
        FindOfficer = 121501, // 0x0001DA9D
        AddOfficer = 121502, // 0x0001DA9E
        EditOfficer = 121503, // 0x0001DA9F
        DeleteOfficer = 121504, // 0x0001DAA0
        ClaimAdministrator = 121600, // 0x0001DB00
        FindClaimAdministrator = 121601, // 0x0001DB01
        AddClaimAdministrator = 121602, // 0x0001DB02
        EditClaimAdministrator = 121603, // 0x0001DB03
        DeleteClaimAdministrator = 121604, // 0x0001DB04
        Users = 121700, // 0x0001DB64
        UsersSearch = 121701, // 0x0001DB65
        UsersAdd = 121702, // 0x0001DB66
        UsersEdit = 121703, // 0x0001DB67
        UsersDelete = 121704, // 0x0001DB68
        Payer = 121800, // 0x0001DBC8
        FindPayer = 121801, // 0x0001DBC9
        ViewPayer = 121801, // 0x0001DBC9
        AddPayer = 121802, // 0x0001DBCA
        EditPayer = 121803, // 0x0001DBCB
        DeletePayer = 121804, // 0x0001DBCC
        Locations = 121900, // 0x0001DC2C
        FindLocations = 121901, // 0x0001DC2D
        AddLocations = 121902, // 0x0001DC2E
        EditLocations = 121903, // 0x0001DC2F
        DeleteLocations = 121904, // 0x0001DC30
        MoveLocations = 121905, // 0x0001DC31
        userProfiles = 122000, // 0x0001DC90
        FindUserProfile = 122001, // 0x0001DC91
        AddUserProfile = 122002, // 0x0001DC92
        EditUserProfile = 122003, // 0x0001DC93
        DeleteUserProfile = 122004, // 0x0001DC94
        DuplicateUserProfile = 122005, // 0x0001DC95
        MedicalItem = 122100, // 0x0001DCF4
        FindMedicalItem = 122101, // 0x0001DCF5
        AddMedicalItem = 122102, // 0x0001DCF6
        EditMedicalItem = 122103, // 0x0001DCF7
        DeleteMedicalItem = 122104, // 0x0001DCF8
        Tools = 130000, // 0x0001FBD0
        Registers = 131000, // 0x0001FFB8
        DiagnosesUpload = 131001, // 0x0001FFB9
        DiagnosesDownload = 131002, // 0x0001FFBA
        HealthFacilitiesUpload = 131003, // 0x0001FFBB
        HealthFacilitiesDownload = 131004, // 0x0001FFBC
        LocationUpload = 131005, // 0x0001FFBD
        LocationDonwload = 131006, // 0x0001FFBE
        Extracts = 131100, // 0x0002001C
        ExtractMasterDataDownload = 131101, // 0x0002001D
        ExtractPhoneExtractsCreate = 131102, // 0x0002001E
        ExtractOfflineExtractCreate = 131103, // 0x0002001F
        ExtractClaimUpload = 131104, // 0x00020020
        ExtractEnrolmentsUpload = 131105, // 0x00020021
        ExtractFeedbackUpload = 131106, // 0x00020022
        Reports = 131200, // 0x00020080
        ReportsPrimaryOperationalIndicatorPolicies = 131201, // 0x00020081
        ReportsPrimaryOperationalIndicatorsClaims = 131202, // 0x00020082
        ReportsDerivedOperationalIndicators = 131203, // 0x00020083
        ReportsContributionCollection = 131204, // 0x00020084
        ReportsProductSales = 131205, // 0x00020085
        ReportsContributionDistribution = 131206, // 0x00020086
        ReportsUserActivity = 131207, // 0x00020087
        ReportsEnrolmentPerformanceIndicators = 131208, // 0x00020088
        ReportsStatusOfRegister = 131209, // 0x00020089
        ReportsInsureeWithoutPhotos = 131210, // 0x0002008A
        ReportsPaymentCategoryOverview = 131211, // 0x0002008B
        ReportsMatchingFunds = 131212, // 0x0002008C
        ReportsClaimOverviewReport = 131213, // 0x0002008D
        ReportsPercentageReferrals = 131214, // 0x0002008E
        ReportsFamiliesInsureesOverview = 131215, // 0x0002008F
        ReportsPendingInsurees = 131216, // 0x00020090
        ReportsRenewals = 131217, // 0x00020091
        ReportsCapitationPayment = 131218, // 0x00020092
        ReportRejectedPhoto = 131219, // 0x00020093
        ReportsContributionPayment = 131220, // 0x00020094
        ReportsControlNumberAssignment = 131221, // 0x00020095
        ReportsOverviewOfCommissions = 131222, // 0x00020096
        ReportsClaimHistoryReport = 131223, // 0x00020097
        Utilities = 131300, // 0x000200E4
        DatabaseBackup = 131301, // 0x000200E5
        DatabaseRestore = 131302, // 0x000200E6
        ExecuteScripts = 131303, // 0x000200E7
        EmailSettings = 131304, // 0x000200E8
        FundingSave = 131401, // 0x00020149
    }
}
