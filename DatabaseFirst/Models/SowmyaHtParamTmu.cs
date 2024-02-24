using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class SowmyaHtParamTmu
    {
        public SowmyaHtParamTmu()
        {
            Sowmyatables = new HashSet<Sowmyatable>();
        }

        public decimal HtDataParamTmultctid { get; set; }
        public string? Cjid { get; set; }
        public int? MeterId { get; set; }
        public int? Dtrid { get; set; }
        public int? CommandId { get; set; }
        public string? Rtc { get; set; }
        public decimal? CurrentRphase { get; set; }
        public decimal? CurrentYphase { get; set; }
        public decimal? CurrentBphase { get; set; }
        public string? LoadLimitFunctionStatus { get; set; }
        public string? PowerAlert { get; set; }
        public string? SrlcdoorsStatus { get; set; }
        public string? OilLevel { get; set; }
        public string? SrlcoilLevel { get; set; }
        public decimal? SrlcoilTemperature { get; set; }
        public decimal? SrlcsurfaceTemperature { get; set; }
        public decimal? Srlcambtemperature { get; set; }
        public string? RelayAlert { get; set; }
        public decimal? AvgCurrentIr { get; set; }
        public decimal? AvgCurrentIy { get; set; }
        public decimal? AvgCurrentIb { get; set; }
        public decimal? L1voltageVrn { get; set; }
        public decimal? AvgVoltageVrn { get; set; }
        public decimal? L2voltageVyn { get; set; }
        public decimal? AvgVoltageVyn { get; set; }
        public decimal? L3voltageVbn { get; set; }
        public decimal? L1signedPowerFactorRphase { get; set; }
        public decimal? AvgVoltageVbn { get; set; }
        public decimal? L2signedPowerFactorYphase { get; set; }
        public decimal? L3signedPowerFactorBphase { get; set; }
        public decimal? BlockEnergyWhImport { get; set; }
        public decimal? BlockEnergyVahImport { get; set; }
        public decimal? BlockEnergyWhExport { get; set; }
        public decimal? Frequency { get; set; }
        public decimal? BlockEnergyVahExport { get; set; }
        public decimal? BlockEnergykvarhLagIimport { get; set; }
        public decimal? BlockEnergykvarhLagIiexport { get; set; }
        public decimal? SignedActivePowerkW { get; set; }
        public decimal? BlockEnergykvarhLeadIiiimport { get; set; }
        public string? PushSetupId { get; set; }
        public string? EmeventStatusWord { get; set; }
        public string? EmeventCode { get; set; }
        public int? SrlcdeviceId { get; set; }
        public string? SrlcconnectStatus { get; set; }
        public long? SrlccumulativeEventcounter { get; set; }
        public string? SrlccontrolMode { get; set; }
        public string? EventRegisterStatus { get; set; }
        public DateTimeOffset Sts { get; set; }
        public bool? IsDataExist { get; set; }
        public int? Id { get; set; }

        public virtual ICollection<Sowmyatable> Sowmyatables { get; set; }
    }
}
