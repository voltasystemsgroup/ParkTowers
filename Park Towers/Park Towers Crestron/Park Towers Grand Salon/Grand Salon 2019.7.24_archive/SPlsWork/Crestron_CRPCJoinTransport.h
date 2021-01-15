namespace Crestron.CRPC;
        // class declarations
         class JoinTransportClientBase;
         class JoinTransportServerBase;
     class JoinTransportServerBase 
    {
        // class delegates
        delegate FUNCTION simplsharpstringcallback ( STRING s );

        // class events

        // class functions
        FUNCTION AddFilter ( STRING name );
        FUNCTION RemoveFilter ( STRING name );
        FUNCTION CloseClientTransports ();
        FUNCTION CloseClientTransport ( STRING tag );
        FUNCTION OnJoinData ( STRING pkt );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static SIGNED_LONG_INTEGER ENCODING;

        // class properties
        DelegateProperty simplsharpstringcallback Sendback;
        STRING Type[];
    };

