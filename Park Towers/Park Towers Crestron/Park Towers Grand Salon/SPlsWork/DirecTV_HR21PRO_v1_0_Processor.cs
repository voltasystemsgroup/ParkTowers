using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace CrestronModule_DIRECTV_HR21PRO_V1_0_PROCESSOR
{
    public class CrestronModuleClass_DIRECTV_HR21PRO_V1_0_PROCESSOR : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput GET_PRIMARY_STATUS;
        Crestron.Logos.SplusObjects.DigitalInput GET_CURRENT_TIME;
        Crestron.Logos.SplusObjects.BufferInput FROM_DEVICE;
        Crestron.Logos.SplusObjects.AnalogOutput TRANSPONDER;
        Crestron.Logos.SplusObjects.AnalogOutput SIGNAL_QUALITY;
        Crestron.Logos.SplusObjects.StringOutput CHANNEL;
        Crestron.Logos.SplusObjects.StringOutput PRIMARY_TYPE;
        Crestron.Logos.SplusObjects.StringOutput AUDIO_TYPE;
        Crestron.Logos.SplusObjects.StringOutput CURRENT_DATE;
        Crestron.Logos.SplusObjects.StringOutput CURRENT_TIME;
        Crestron.Logos.SplusObjects.StringOutput DAY_OF_WEEK;
        Crestron.Logos.SplusObjects.StringOutput TO_DEVICE;
        ushort ASEMAPHORE = 0;
        ushort A = 0;
        ushort APOLL = 0;
        ushort [] ABYTE;
        CrestronString STEMP;
        private void GETBYTES (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 129;
            STEMP  .UpdateValue ( FROM_DEVICE  ) ; 
            __context__.SourceCodeLine = 130;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 2 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)(Functions.Length( STEMP ) - 1); 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( A  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (A  >= __FN_FORSTART_VAL__1) && (A  <= __FN_FOREND_VAL__1) ) : ( (A  <= __FN_FORSTART_VAL__1) && (A  >= __FN_FOREND_VAL__1) ) ; A  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 132;
                ABYTE [ (A - 1)] = (ushort) ( Byte( STEMP , (int)( A ) ) ) ; 
                __context__.SourceCodeLine = 130;
                } 
            
            
            }
            
        object GET_PRIMARY_STATUS_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 166;
                TO_DEVICE  .UpdateValue ( "\u00FA\u0083"  ) ; 
                __context__.SourceCodeLine = 167;
                APOLL = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 168;
                Functions.ClearBuffer ( FROM_DEVICE ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object GET_CURRENT_TIME_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 173;
            TO_DEVICE  .UpdateValue ( "\u00FA\u0091"  ) ; 
            __context__.SourceCodeLine = 174;
            APOLL = (ushort) ( 2 ) ; 
            __context__.SourceCodeLine = 175;
            Functions.ClearBuffer ( FROM_DEVICE ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object FROM_DEVICE_OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 188;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ASEMAPHORE == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 190;
            ASEMAPHORE = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 191;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\u00F4" , FROM_DEVICE ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 194;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Find( "\u00F4" , FROM_DEVICE ) == 47) ) && Functions.TestForTrue ( Functions.BoolToInt (APOLL == 1) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 197;
                    GETBYTES (  __context__  ) ; 
                    __context__.SourceCodeLine = 199;
                    MakeString ( CHANNEL , "{0:d}", (short)((ABYTE[ 1 ] << 8) + ABYTE[ 2 ])) ; 
                    __context__.SourceCodeLine = 200;
                    
                        {
                        int __SPLS_TMPVAR__SWTCH_1__ = ((int)ABYTE[ 5 ]);
                        
                            { 
                            if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 11) ) ) ) 
                                {
                                __context__.SourceCodeLine = 203;
                                PRIMARY_TYPE  .UpdateValue ( "Data"  ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 12) ) ) ) 
                                {
                                __context__.SourceCodeLine = 205;
                                PRIMARY_TYPE  .UpdateValue ( "Audio"  ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 14) ) ) ) 
                                {
                                __context__.SourceCodeLine = 207;
                                PRIMARY_TYPE  .UpdateValue ( "Retired"  ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 15) ) ) ) 
                                {
                                __context__.SourceCodeLine = 209;
                                PRIMARY_TYPE  .UpdateValue ( "TV"  ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 16) ) ) ) 
                                {
                                __context__.SourceCodeLine = 211;
                                PRIMARY_TYPE  .UpdateValue ( "HDTV"  ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 255) ) ) ) 
                                {
                                __context__.SourceCodeLine = 213;
                                PRIMARY_TYPE  .UpdateValue ( "None"  ) ; 
                                }
                            
                            } 
                            
                        }
                        
                    
                    __context__.SourceCodeLine = 215;
                    
                        {
                        int __SPLS_TMPVAR__SWTCH_2__ = ((int)ABYTE[ 6 ]);
                        
                            { 
                            if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 0) ) ) ) 
                                {
                                __context__.SourceCodeLine = 218;
                                AUDIO_TYPE  .UpdateValue ( "MPEG IN/PCM Out"  ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 9) ) ) ) 
                                {
                                __context__.SourceCodeLine = 220;
                                AUDIO_TYPE  .UpdateValue ( "AC3 In/AC3 Out"  ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 255) ) ) ) 
                                {
                                __context__.SourceCodeLine = 222;
                                AUDIO_TYPE  .UpdateValue ( "None"  ) ; 
                                }
                            
                            } 
                            
                        }
                        
                    
                    __context__.SourceCodeLine = 224;
                    TRANSPONDER  .Value = (ushort) ( ABYTE[ 16 ] ) ; 
                    __context__.SourceCodeLine = 225;
                    SIGNAL_QUALITY  .Value = (ushort) ( ABYTE[ 39 ] ) ; 
                    } 
                
                __context__.SourceCodeLine = 227;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Find( "\u00F4" , FROM_DEVICE ) == 9) ) && Functions.TestForTrue ( Functions.BoolToInt (APOLL == 2) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 230;
                    GETBYTES (  __context__  ) ; 
                    __context__.SourceCodeLine = 231;
                    MakeString ( CURRENT_DATE , "{0:d2}/{1:d2}/{2:d}", (short)ABYTE[ 2 ], (short)ABYTE[ 3 ], (short)(ABYTE[ 1 ] + 1993)) ; 
                    __context__.SourceCodeLine = 232;
                    MakeString ( CURRENT_TIME , "{0:d2}:{1:d2}", (short)ABYTE[ 4 ], (short)ABYTE[ 5 ]) ; 
                    __context__.SourceCodeLine = 233;
                    
                        {
                        int __SPLS_TMPVAR__SWTCH_3__ = ((int)ABYTE[ 7 ]);
                        
                            { 
                            if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 1) ) ) ) 
                                {
                                __context__.SourceCodeLine = 236;
                                DAY_OF_WEEK  .UpdateValue ( "Monday"  ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 2) ) ) ) 
                                {
                                __context__.SourceCodeLine = 238;
                                DAY_OF_WEEK  .UpdateValue ( "Tuesday"  ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 3) ) ) ) 
                                {
                                __context__.SourceCodeLine = 240;
                                DAY_OF_WEEK  .UpdateValue ( "Wednesday"  ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 4) ) ) ) 
                                {
                                __context__.SourceCodeLine = 242;
                                DAY_OF_WEEK  .UpdateValue ( "Thursday"  ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 5) ) ) ) 
                                {
                                __context__.SourceCodeLine = 244;
                                DAY_OF_WEEK  .UpdateValue ( "Friday"  ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 6) ) ) ) 
                                {
                                __context__.SourceCodeLine = 246;
                                DAY_OF_WEEK  .UpdateValue ( "Saturday"  ) ; 
                                }
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 7) ) ) ) 
                                {
                                __context__.SourceCodeLine = 248;
                                DAY_OF_WEEK  .UpdateValue ( "Sunday"  ) ; 
                                }
                            
                            } 
                            
                        }
                        
                    
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 252;
                    Functions.ClearBuffer ( FROM_DEVICE ) ; 
                    }
                
                __context__.SourceCodeLine = 253;
                APOLL = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 191;
                } 
            
            __context__.SourceCodeLine = 255;
            ASEMAPHORE = (ushort) ( 0 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 302;
        ASEMAPHORE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 303;
        APOLL = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    ABYTE  = new ushort[ 51 ];
    STEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    
    GET_PRIMARY_STATUS = new Crestron.Logos.SplusObjects.DigitalInput( GET_PRIMARY_STATUS__DigitalInput__, this );
    m_DigitalInputList.Add( GET_PRIMARY_STATUS__DigitalInput__, GET_PRIMARY_STATUS );
    
    GET_CURRENT_TIME = new Crestron.Logos.SplusObjects.DigitalInput( GET_CURRENT_TIME__DigitalInput__, this );
    m_DigitalInputList.Add( GET_CURRENT_TIME__DigitalInput__, GET_CURRENT_TIME );
    
    TRANSPONDER = new Crestron.Logos.SplusObjects.AnalogOutput( TRANSPONDER__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( TRANSPONDER__AnalogSerialOutput__, TRANSPONDER );
    
    SIGNAL_QUALITY = new Crestron.Logos.SplusObjects.AnalogOutput( SIGNAL_QUALITY__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SIGNAL_QUALITY__AnalogSerialOutput__, SIGNAL_QUALITY );
    
    CHANNEL = new Crestron.Logos.SplusObjects.StringOutput( CHANNEL__AnalogSerialOutput__, this );
    m_StringOutputList.Add( CHANNEL__AnalogSerialOutput__, CHANNEL );
    
    PRIMARY_TYPE = new Crestron.Logos.SplusObjects.StringOutput( PRIMARY_TYPE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PRIMARY_TYPE__AnalogSerialOutput__, PRIMARY_TYPE );
    
    AUDIO_TYPE = new Crestron.Logos.SplusObjects.StringOutput( AUDIO_TYPE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( AUDIO_TYPE__AnalogSerialOutput__, AUDIO_TYPE );
    
    CURRENT_DATE = new Crestron.Logos.SplusObjects.StringOutput( CURRENT_DATE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( CURRENT_DATE__AnalogSerialOutput__, CURRENT_DATE );
    
    CURRENT_TIME = new Crestron.Logos.SplusObjects.StringOutput( CURRENT_TIME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( CURRENT_TIME__AnalogSerialOutput__, CURRENT_TIME );
    
    DAY_OF_WEEK = new Crestron.Logos.SplusObjects.StringOutput( DAY_OF_WEEK__AnalogSerialOutput__, this );
    m_StringOutputList.Add( DAY_OF_WEEK__AnalogSerialOutput__, DAY_OF_WEEK );
    
    TO_DEVICE = new Crestron.Logos.SplusObjects.StringOutput( TO_DEVICE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_DEVICE__AnalogSerialOutput__, TO_DEVICE );
    
    FROM_DEVICE = new Crestron.Logos.SplusObjects.BufferInput( FROM_DEVICE__AnalogSerialInput__, 100, this );
    m_StringInputList.Add( FROM_DEVICE__AnalogSerialInput__, FROM_DEVICE );
    
    
    GET_PRIMARY_STATUS.OnDigitalPush.Add( new InputChangeHandlerWrapper( GET_PRIMARY_STATUS_OnPush_0, false ) );
    GET_CURRENT_TIME.OnDigitalPush.Add( new InputChangeHandlerWrapper( GET_CURRENT_TIME_OnPush_1, false ) );
    FROM_DEVICE.OnSerialChange.Add( new InputChangeHandlerWrapper( FROM_DEVICE_OnChange_2, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public CrestronModuleClass_DIRECTV_HR21PRO_V1_0_PROCESSOR ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint GET_PRIMARY_STATUS__DigitalInput__ = 0;
const uint GET_CURRENT_TIME__DigitalInput__ = 1;
const uint FROM_DEVICE__AnalogSerialInput__ = 0;
const uint TRANSPONDER__AnalogSerialOutput__ = 0;
const uint SIGNAL_QUALITY__AnalogSerialOutput__ = 1;
const uint CHANNEL__AnalogSerialOutput__ = 2;
const uint PRIMARY_TYPE__AnalogSerialOutput__ = 3;
const uint AUDIO_TYPE__AnalogSerialOutput__ = 4;
const uint CURRENT_DATE__AnalogSerialOutput__ = 5;
const uint CURRENT_TIME__AnalogSerialOutput__ = 6;
const uint DAY_OF_WEEK__AnalogSerialOutput__ = 7;
const uint TO_DEVICE__AnalogSerialOutput__ = 8;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
