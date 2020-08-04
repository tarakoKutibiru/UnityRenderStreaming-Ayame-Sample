using System.Collections.Generic;

namespace Ayame.Signaling
{
    public class Message
    {
        public string type;
    }

    public class AcceptMessage
    {
        public string type = "accept";
        public string connectionId;
        public List<IceServer> iceServers;
        public bool isExistClient;
        public bool isExistUser;
    }

    [System.Serializable]
    public class IceServer
    {
        public List<string> urls;
        public string username;
        public string credential;
    }

    public class RegisterMessage
    {
        public string type = "register";
        public string roomId;
        public string signalingKey;
    }

    public class AnswerMessage
    {
        public string type = "answer";
        public string sdp;
    }

    public class OfferMessage
    {
        public string type = "offer";
        public string sdp;
    }

    public class CandidateMessage
    {
        public string type = "candidate";
        public Ice ice;
    }

    [System.Serializable]
    public class Ice
    {
        public string candidate;
        public string sdpMid;
        public int sdpMLineIndex;
    }

    public class PongMessage
    {
        public string type = "pong";
    }
}
