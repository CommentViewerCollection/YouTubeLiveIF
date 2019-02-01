using SitePlugin;

namespace YouTubeLiveSitePlugin
{
    public enum YouTubeLiveMessageType
    {
        Unknown,
        Comment,
        Superchat,
        Connected,
        Disconnected,
    }


    public interface IYouTubeLiveMessage : IMessage
    {
        YouTubeLiveMessageType YouTubeLiveMessageType { get; }
    }
    public interface IYouTubeLiveConnected : IYouTubeLiveMessage
    {
    }
    public interface IYouTubeLiveDisconnected : IYouTubeLiveMessage
    {
    }
    public interface IYouTubeLiveComment : IYouTubeLiveMessage
    {
        //string Comment { get; }
        string Id { get; }
        //string UserName { get; }
        string UserId { get; }
        long PostedAt { get; }
        IMessageImage UserIcon { get; set; }
    }
    public interface IYouTubeLiveSuperchat : IYouTubeLiveMessage
    {
        //string Comment { get; }
        string Id { get; }
        //string UserName { get; }
        string UserId { get; }
        long PostedAt { get; }
        IMessageImage UserIcon { get; }
    }
}