namespace DeveOspStreamCombiner.Data
{
    public class StreamChannels
    {
        public StreamChannel[] results { get; set; }
    }

    public class StreamChannel
    {
        public int id { get; set; }
        public string channelEndpointID { get; set; }
        public int owningUser { get; set; }
        public string owningUsername { get; set; }
        public string owningUserImage { get; set; }
        public string channelName { get; set; }
        public string description { get; set; }
        public string channelImage { get; set; }
        public string offlineImageLocation { get; set; }
        public int topic { get; set; }
        public int views { get; set; }
        public int currentViews { get; set; }
        public bool recordingEnabled { get; set; }
        public bool chatEnabled { get; set; }
        public int[] stream { get; set; }
        public int[] recordedVideoIDs { get; set; }
        public int upvotes { get; set; }
        public bool _protected { get; set; }
        public bool allowGuestNickChange { get; set; }
        public object vanityURL { get; set; }
        public bool showHome { get; set; }
        public int maxVideoRetention { get; set; }
        public int subscriptions { get; set; }
        public object hubEnabled { get; set; }
        public object hubNSFW { get; set; }
        public string[] tags { get; set; }
    }

}
