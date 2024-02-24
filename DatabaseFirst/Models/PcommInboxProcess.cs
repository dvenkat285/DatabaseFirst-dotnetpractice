using System;
using System.Collections.Generic;

namespace DatabaseFirst.Models
{
    public partial class PcommInboxProcess
    {
        public decimal PinboxProcessId { get; set; }
        public decimal InboxFrameId { get; set; }
        public string Cjid { get; set; } = null!;
        public string? PhysicalAddress { get; set; }
        public string? CommandCode { get; set; }
        public string PayLoad { get; set; } = null!;
        public int? DeviceTid { get; set; }
        public DateTimeOffset? DeviceTs { get; set; }
        public string? ModemImeino { get; set; }
        public DateTimeOffset CrTs { get; set; }
        public bool IsProcessed { get; set; }
        public DateTimeOffset? ProcessedTs { get; set; }
        public string? NodeId { get; set; }
    }
}
