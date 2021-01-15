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

namespace UserModule_YAMAHA_RX_A3000_RS232_COMMAND___FB_PROCESSOR_V2_0
{
    public class UserModuleClass_YAMAHA_RX_A3000_RS232_COMMAND___FB_PROCESSOR_V2_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        Crestron.Logos.SplusObjects.StringInput CMDIN;
        Crestron.Logos.SplusObjects.BufferInput RS232FROMDEV;
        Crestron.Logos.SplusObjects.DigitalInput PROCESS;
        Crestron.Logos.SplusObjects.DigitalInput TUNERISFM;
        Crestron.Logos.SplusObjects.DigitalInput PANDORA_MEM_SAVE;
        Crestron.Logos.SplusObjects.DigitalInput NAPSTER_MEM_SAVE;
        Crestron.Logos.SplusObjects.DigitalInput SIRIUSIR_MEM_SAVE;
        Crestron.Logos.SplusObjects.DigitalInput RHAP_MEM_SAVE;
        Crestron.Logos.SplusObjects.DigitalInput PC_MEM_SAVE;
        Crestron.Logos.SplusObjects.DigitalInput NETRADIO_MEM_SAVE;
        Crestron.Logos.SplusObjects.DigitalInput USB_MEM_SAVE;
        Crestron.Logos.SplusObjects.DigitalInput SIRIUS_MEM_SAVE;
        Crestron.Logos.SplusObjects.AnalogInput TUNERDIRVAL;
        Crestron.Logos.SplusObjects.AnalogInput SIRIUSDIRVAL;
        Crestron.Logos.SplusObjects.AnalogInput PANDORA_MEM_LOC_VAL;
        Crestron.Logos.SplusObjects.AnalogInput NAPSTER_MEM_LOC_VAL;
        Crestron.Logos.SplusObjects.AnalogInput SIRIUSIR_MEM_LOC_VAL;
        Crestron.Logos.SplusObjects.AnalogInput RHAP_MEM_LOC_VAL;
        Crestron.Logos.SplusObjects.AnalogInput PC_MEM_LOC_VAL;
        Crestron.Logos.SplusObjects.AnalogInput NETRADIO_MEM_LOC_VAL;
        Crestron.Logos.SplusObjects.AnalogInput USB_MEM_LOC_VAL;
        Crestron.Logos.SplusObjects.AnalogInput SIRIUS_MEM_LOC_VAL;
        Crestron.Logos.SplusObjects.DigitalOutput TUNER_PROGRAM1_AVAIL;
        Crestron.Logos.SplusObjects.DigitalOutput TUNER_PROGRAM2_AVAIL;
        Crestron.Logos.SplusObjects.DigitalOutput TUNER_PROGRAM3_AVAIL;
        Crestron.Logos.SplusObjects.DigitalOutput TUNER_PROGRAM4_AVAIL;
        Crestron.Logos.SplusObjects.DigitalOutput TUNER_PROGRAM5_AVAIL;
        Crestron.Logos.SplusObjects.DigitalOutput TUNER_PROGRAM6_AVAIL;
        Crestron.Logos.SplusObjects.DigitalOutput TUNER_PROGRAM7_AVAIL;
        Crestron.Logos.SplusObjects.DigitalOutput TUNER_PROGRAM8_AVAIL;
        Crestron.Logos.SplusObjects.StringOutput RXPROCESSED;
        Crestron.Logos.SplusObjects.StringOutput RS232_TO_DEV;
        Crestron.Logos.SplusObjects.StringOutput MAIN_ZONE_NAME;
        Crestron.Logos.SplusObjects.StringOutput MAIN_SCENE1_NAME;
        Crestron.Logos.SplusObjects.StringOutput MAIN_SCENE2_NAME;
        Crestron.Logos.SplusObjects.StringOutput MAIN_SCENE3_NAME;
        Crestron.Logos.SplusObjects.StringOutput MAIN_SCENE4_NAME;
        Crestron.Logos.SplusObjects.StringOutput MAIN_SCENE5_NAME;
        Crestron.Logos.SplusObjects.StringOutput MAIN_SCENE6_NAME;
        Crestron.Logos.SplusObjects.StringOutput MAIN_SCENE7_NAME;
        Crestron.Logos.SplusObjects.StringOutput MAIN_SCENE8_NAME;
        Crestron.Logos.SplusObjects.StringOutput MAIN_SCENE9_NAME;
        Crestron.Logos.SplusObjects.StringOutput MAIN_SCENE10_NAME;
        Crestron.Logos.SplusObjects.StringOutput MAIN_SCENE11_NAME;
        Crestron.Logos.SplusObjects.StringOutput MAIN_SCENE12_NAME;
        Crestron.Logos.SplusObjects.StringOutput MAIN_SLEEP_TIMER_TEXT;
        Crestron.Logos.SplusObjects.StringOutput MAIN_VOL_TEXT;
        Crestron.Logos.SplusObjects.StringOutput MAIN_CURR_INPUT_AUDIO_TYPE;
        Crestron.Logos.SplusObjects.StringOutput MAIN_DECODER_MODE;
        Crestron.Logos.SplusObjects.StringOutput MAIN_PURE_DIRECT_MODE;
        Crestron.Logos.SplusObjects.StringOutput MAIN_ADAPTIVE_DYNAMIC_RANGE_MODE;
        Crestron.Logos.SplusObjects.StringOutput MAIN_LIP_SYNC_MODE;
        Crestron.Logos.SplusObjects.StringOutput MAIN_STRAIGHT_MODE_STATUS;
        Crestron.Logos.SplusObjects.StringOutput MAIN_ENHANCER_STATUS;
        Crestron.Logos.SplusObjects.StringOutput MAIN_SOUND_PROG_STATUS;
        Crestron.Logos.SplusObjects.StringOutput MAIN_ADAPTIVE_DSP_MODE;
        Crestron.Logos.SplusObjects.StringOutput MAIN_3D_CINEMA_MODE;
        Crestron.Logos.SplusObjects.StringOutput MAIN_EX_DECODER_MODE;
        Crestron.Logos.SplusObjects.StringOutput MAIN_2CHAN_DECODER_MODE;
        Crestron.Logos.SplusObjects.StringOutput MAIN_CURR_HDMI_OUT_CONFIG;
        Crestron.Logos.SplusObjects.StringOutput MAIN_HDMI_PROC_STATE;
        Crestron.Logos.SplusObjects.StringOutput MAIN_HDMI_ASPECT;
        Crestron.Logos.SplusObjects.StringOutput MAIN_HDMI_RES;
        Crestron.Logos.SplusObjects.StringOutput ZONE2_NAME;
        Crestron.Logos.SplusObjects.StringOutput ZONE2_SCENE1_NAME;
        Crestron.Logos.SplusObjects.StringOutput ZONE2_SCENE2_NAME;
        Crestron.Logos.SplusObjects.StringOutput ZONE2_SCENE3_NAME;
        Crestron.Logos.SplusObjects.StringOutput ZONE2_SCENE4_NAME;
        Crestron.Logos.SplusObjects.StringOutput ZONE2_SLEEP_TIMER_TEXT;
        Crestron.Logos.SplusObjects.StringOutput ZONE2_VOL_TEXT;
        Crestron.Logos.SplusObjects.StringOutput ZONE3_NAME;
        Crestron.Logos.SplusObjects.StringOutput ZONE3_SCENE1_NAME;
        Crestron.Logos.SplusObjects.StringOutput ZONE3_SCENE2_NAME;
        Crestron.Logos.SplusObjects.StringOutput ZONE3_SCENE3_NAME;
        Crestron.Logos.SplusObjects.StringOutput ZONE3_SCENE4_NAME;
        Crestron.Logos.SplusObjects.StringOutput ZONE3_SLEEP_TIMER_TEXT;
        Crestron.Logos.SplusObjects.StringOutput ZONE3_VOL_TEXT;
        Crestron.Logos.SplusObjects.StringOutput ZONE4_NAME;
        Crestron.Logos.SplusObjects.StringOutput ZONE4_SCENE1_NAME;
        Crestron.Logos.SplusObjects.StringOutput ZONE4_SCENE2_NAME;
        Crestron.Logos.SplusObjects.StringOutput ZONE4_SCENE3_NAME;
        Crestron.Logos.SplusObjects.StringOutput ZONE4_SCENE4_NAME;
        Crestron.Logos.SplusObjects.StringOutput ZONE4_SLEEP_TIMER_TEXT;
        Crestron.Logos.SplusObjects.StringOutput TUNER_CURR_STATION;
        Crestron.Logos.SplusObjects.StringOutput TUNER_CURR_PROGRAM_NUMBER;
        Crestron.Logos.SplusObjects.StringOutput TUNER_CURR_PROGRAM_TYPE;
        Crestron.Logos.SplusObjects.StringOutput TUNER_CURR_SONG;
        Crestron.Logos.SplusObjects.StringOutput TUNER_CURR_ARTIST;
        Crestron.Logos.SplusObjects.StringOutput TUNER_CURR_ALBUM;
        Crestron.Logos.SplusObjects.StringOutput PANDLISTLAYER;
        Crestron.Logos.SplusObjects.StringOutput PANDLISTNAME;
        Crestron.Logos.SplusObjects.StringOutput PANDLINE1TEXT;
        Crestron.Logos.SplusObjects.StringOutput PANDLINE2TEXT;
        Crestron.Logos.SplusObjects.StringOutput PANDLINE3TEXT;
        Crestron.Logos.SplusObjects.StringOutput PANDLINE4TEXT;
        Crestron.Logos.SplusObjects.StringOutput PANDLINE5TEXT;
        Crestron.Logos.SplusObjects.StringOutput PANDLINE6TEXT;
        Crestron.Logos.SplusObjects.StringOutput PANDLINE7TEXT;
        Crestron.Logos.SplusObjects.StringOutput PANDLINE8TEXT;
        Crestron.Logos.SplusObjects.StringOutput PANDCURRSONGTEXT;
        Crestron.Logos.SplusObjects.StringOutput PANDCURRALBUMTEXT;
        Crestron.Logos.SplusObjects.StringOutput PANDCURRSTATIONTEXT;
        Crestron.Logos.SplusObjects.StringOutput NAPLISTLAYER;
        Crestron.Logos.SplusObjects.StringOutput NAPLISTNAME;
        Crestron.Logos.SplusObjects.StringOutput NAPLINE1TEXT;
        Crestron.Logos.SplusObjects.StringOutput NAPLINE2TEXT;
        Crestron.Logos.SplusObjects.StringOutput NAPLINE3TEXT;
        Crestron.Logos.SplusObjects.StringOutput NAPLINE4TEXT;
        Crestron.Logos.SplusObjects.StringOutput NAPLINE5TEXT;
        Crestron.Logos.SplusObjects.StringOutput NAPLINE6TEXT;
        Crestron.Logos.SplusObjects.StringOutput NAPLINE7TEXT;
        Crestron.Logos.SplusObjects.StringOutput NAPLINE8TEXT;
        Crestron.Logos.SplusObjects.StringOutput NAPCURRSONGTEXT;
        Crestron.Logos.SplusObjects.StringOutput NAPCURRARTISTTEXT;
        Crestron.Logos.SplusObjects.StringOutput NAPCURRALBUMTEXT;
        Crestron.Logos.SplusObjects.StringOutput SIRIUSIRLISTLAYER;
        Crestron.Logos.SplusObjects.StringOutput SIRIUSIRLISTNAME;
        Crestron.Logos.SplusObjects.StringOutput SIRIUSIRLINE1TEXT;
        Crestron.Logos.SplusObjects.StringOutput SIRIUSIRLINE2TEXT;
        Crestron.Logos.SplusObjects.StringOutput SIRIUSIRLINE3TEXT;
        Crestron.Logos.SplusObjects.StringOutput SIRIUSIRLINE4TEXT;
        Crestron.Logos.SplusObjects.StringOutput SIRIUSIRLINE5TEXT;
        Crestron.Logos.SplusObjects.StringOutput SIRIUSIRLINE6TEXT;
        Crestron.Logos.SplusObjects.StringOutput SIRIUSIRLINE7TEXT;
        Crestron.Logos.SplusObjects.StringOutput SIRIUSIRLINE8TEXT;
        Crestron.Logos.SplusObjects.StringOutput SIRIUSIRCURRSONGTEXT;
        Crestron.Logos.SplusObjects.StringOutput SIRIUSIRCURRARTISTTEXT;
        Crestron.Logos.SplusObjects.StringOutput SIRIUSIRCURRALBUMTEXT;
        Crestron.Logos.SplusObjects.StringOutput SIRIUSIRCURRCHANNELTEXT;
        Crestron.Logos.SplusObjects.StringOutput RHAPLISTLAYER;
        Crestron.Logos.SplusObjects.StringOutput RHAPLISTNAME;
        Crestron.Logos.SplusObjects.StringOutput RHAPLINE1TEXT;
        Crestron.Logos.SplusObjects.StringOutput RHAPLINE2TEXT;
        Crestron.Logos.SplusObjects.StringOutput RHAPLINE3TEXT;
        Crestron.Logos.SplusObjects.StringOutput RHAPLINE4TEXT;
        Crestron.Logos.SplusObjects.StringOutput RHAPLINE5TEXT;
        Crestron.Logos.SplusObjects.StringOutput RHAPLINE6TEXT;
        Crestron.Logos.SplusObjects.StringOutput RHAPLINE7TEXT;
        Crestron.Logos.SplusObjects.StringOutput RHAPLINE8TEXT;
        Crestron.Logos.SplusObjects.StringOutput RHAPCURRSONGTEXT;
        Crestron.Logos.SplusObjects.StringOutput RHAPCURRARTISTTEXT;
        Crestron.Logos.SplusObjects.StringOutput RHAPCURRALBUMTEXT;
        Crestron.Logos.SplusObjects.StringOutput PCLISTLAYER;
        Crestron.Logos.SplusObjects.StringOutput PCLISTNAME;
        Crestron.Logos.SplusObjects.StringOutput PCLINE1TEXT;
        Crestron.Logos.SplusObjects.StringOutput PCLINE2TEXT;
        Crestron.Logos.SplusObjects.StringOutput PCLINE3TEXT;
        Crestron.Logos.SplusObjects.StringOutput PCLINE4TEXT;
        Crestron.Logos.SplusObjects.StringOutput PCLINE5TEXT;
        Crestron.Logos.SplusObjects.StringOutput PCLINE6TEXT;
        Crestron.Logos.SplusObjects.StringOutput PCLINE7TEXT;
        Crestron.Logos.SplusObjects.StringOutput PCLINE8TEXT;
        Crestron.Logos.SplusObjects.StringOutput PCCURRSONGTEXT;
        Crestron.Logos.SplusObjects.StringOutput PCCURRARTISTTEXT;
        Crestron.Logos.SplusObjects.StringOutput PCCURRALBUMTEXT;
        Crestron.Logos.SplusObjects.StringOutput NETRADIOLISTLAYER;
        Crestron.Logos.SplusObjects.StringOutput NETRADIOLISTNAME;
        Crestron.Logos.SplusObjects.StringOutput NETRADIOLINE1TEXT;
        Crestron.Logos.SplusObjects.StringOutput NETRADIOLINE2TEXT;
        Crestron.Logos.SplusObjects.StringOutput NETRADIOLINE3TEXT;
        Crestron.Logos.SplusObjects.StringOutput NETRADIOLINE4TEXT;
        Crestron.Logos.SplusObjects.StringOutput NETRADIOLINE5TEXT;
        Crestron.Logos.SplusObjects.StringOutput NETRADIOLINE6TEXT;
        Crestron.Logos.SplusObjects.StringOutput NETRADIOLINE7TEXT;
        Crestron.Logos.SplusObjects.StringOutput NETRADIOLINE8TEXT;
        Crestron.Logos.SplusObjects.StringOutput NETRADIOCURRSONGTEXT;
        Crestron.Logos.SplusObjects.StringOutput NETRADIOCURRARTISTTEXT;
        Crestron.Logos.SplusObjects.StringOutput NETRADIOCURRALBUMTEXT;
        Crestron.Logos.SplusObjects.StringOutput NETRADIOCURRCHANNELTEXT;
        Crestron.Logos.SplusObjects.StringOutput USBLISTLAYER;
        Crestron.Logos.SplusObjects.StringOutput USBLISTNAME;
        Crestron.Logos.SplusObjects.StringOutput USBLINE1TEXT;
        Crestron.Logos.SplusObjects.StringOutput USBLINE2TEXT;
        Crestron.Logos.SplusObjects.StringOutput USBLINE3TEXT;
        Crestron.Logos.SplusObjects.StringOutput USBLINE4TEXT;
        Crestron.Logos.SplusObjects.StringOutput USBLINE5TEXT;
        Crestron.Logos.SplusObjects.StringOutput USBLINE6TEXT;
        Crestron.Logos.SplusObjects.StringOutput USBLINE7TEXT;
        Crestron.Logos.SplusObjects.StringOutput USBLINE8TEXT;
        Crestron.Logos.SplusObjects.StringOutput USBCURRSONGTEXT;
        Crestron.Logos.SplusObjects.StringOutput USBCURRARTISTTEXT;
        Crestron.Logos.SplusObjects.StringOutput USBCURRALBUMTEXT;
        Crestron.Logos.SplusObjects.StringOutput IPODLISTLAYER;
        Crestron.Logos.SplusObjects.StringOutput IPODLISTNAME;
        Crestron.Logos.SplusObjects.StringOutput IPODLINE1TEXT;
        Crestron.Logos.SplusObjects.StringOutput IPODLINE2TEXT;
        Crestron.Logos.SplusObjects.StringOutput IPODLINE3TEXT;
        Crestron.Logos.SplusObjects.StringOutput IPODLINE4TEXT;
        Crestron.Logos.SplusObjects.StringOutput IPODLINE5TEXT;
        Crestron.Logos.SplusObjects.StringOutput IPODLINE6TEXT;
        Crestron.Logos.SplusObjects.StringOutput IPODLINE7TEXT;
        Crestron.Logos.SplusObjects.StringOutput IPODLINE8TEXT;
        Crestron.Logos.SplusObjects.StringOutput IPODCURRSONGTEXT;
        Crestron.Logos.SplusObjects.StringOutput IPODCURRARTISTTEXT;
        Crestron.Logos.SplusObjects.StringOutput IPODCURRALBUMTEXT;
        Crestron.Logos.SplusObjects.StringOutput SIRIUSANTLEVEL;
        Crestron.Logos.SplusObjects.StringOutput SIRIUSCURRCATTEXT;
        Crestron.Logos.SplusObjects.StringOutput SIRIUSCURRCHANNUMTEXT;
        Crestron.Logos.SplusObjects.StringOutput SIRIUSCURRCHANNAMETEXT;
        Crestron.Logos.SplusObjects.StringOutput SIRIUSCURRARTISTTEXT;
        Crestron.Logos.SplusObjects.StringOutput SIRIUSCURRSONGTEXT;
        Crestron.Logos.SplusObjects.StringOutput SIRIUSCURRCOMPTEXT;
        ushort G_BPARSING = 0;
        CrestronString CMDTOSEND;
        private CrestronString FN_PARSEDELIMITEDTEXT (  SplusExecutionContext __context__, CrestronString SZTEXT , CrestronString SZANCHOR , CrestronString SZDELIMITER , ushort BCASEMATCH ) 
            { 
            ushort NPOS = 0;
            
            ushort NSTART = 0;
            
            ushort NRANGE = 0;
            
            CrestronString SZVALUE;
            SZVALUE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 256, this );
            
            
            __context__.SourceCodeLine = 369;
            NPOS = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 370;
            NSTART = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 371;
            NRANGE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 373;
            if ( Functions.TestForTrue  ( ( BCASEMATCH)  ) ) 
                {
                __context__.SourceCodeLine = 373;
                NPOS = (ushort) ( Functions.Find( SZANCHOR , SZTEXT ) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 374;
                NPOS = (ushort) ( Functions.FindNoCase( SZANCHOR , SZTEXT ) ) ; 
                }
            
            __context__.SourceCodeLine = 376;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NPOS > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 378;
                NSTART = (ushort) ( (NPOS + Functions.Length( SZANCHOR )) ) ; 
                __context__.SourceCodeLine = 380;
                if ( Functions.TestForTrue  ( ( BCASEMATCH)  ) ) 
                    {
                    __context__.SourceCodeLine = 380;
                    NRANGE = (ushort) ( Functions.Find( SZDELIMITER , SZTEXT , NSTART ) ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 381;
                    NRANGE = (ushort) ( Functions.FindNoCase( SZDELIMITER , SZTEXT , NSTART ) ) ; 
                    }
                
                __context__.SourceCodeLine = 383;
                NRANGE = (ushort) ( (NRANGE - NSTART) ) ; 
                __context__.SourceCodeLine = 385;
                SZVALUE  .UpdateValue ( Functions.Mid ( SZTEXT ,  (int) ( NSTART ) ,  (int) ( NRANGE ) )  ) ; 
                __context__.SourceCodeLine = 386;
                return ( SZVALUE ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 388;
                return ( "" ) ; 
                }
            
            
            return ""; // default return value (none specified in module)
            }
            
        private void FN_PARSEMAIN (  SplusExecutionContext __context__, CrestronString MAINDATA ) 
            { 
            ushort SPOS = 0;
            
            ushort EPOS = 0;
            
            
            __context__.SourceCodeLine = 398;
            if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:SLEEP=" , MAINDATA ))  ) ) 
                { 
                __context__.SourceCodeLine = 400;
                SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                __context__.SourceCodeLine = 401;
                EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                __context__.SourceCodeLine = 402;
                MAIN_SLEEP_TIMER_TEXT  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 405;
                if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:VOL=" , MAINDATA ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 407;
                    SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                    __context__.SourceCodeLine = 408;
                    EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                    __context__.SourceCodeLine = 409;
                    MAIN_VOL_TEXT  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 412;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:AUDSEL=" , MAINDATA ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 414;
                        SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                        __context__.SourceCodeLine = 415;
                        EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                        __context__.SourceCodeLine = 416;
                        MAIN_CURR_INPUT_AUDIO_TYPE  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 419;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:DECODERSEL=" , MAINDATA ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 421;
                            SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                            __context__.SourceCodeLine = 422;
                            EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                            __context__.SourceCodeLine = 423;
                            MAIN_DECODER_MODE  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 426;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:PUREDIRMODE=" , MAINDATA ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 428;
                                SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                __context__.SourceCodeLine = 429;
                                EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                __context__.SourceCodeLine = 430;
                                MAIN_PURE_DIRECT_MODE  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 433;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:ADAPTIVEDRC=" , MAINDATA ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 435;
                                    SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                    __context__.SourceCodeLine = 436;
                                    EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                    __context__.SourceCodeLine = 437;
                                    MAIN_ADAPTIVE_DYNAMIC_RANGE_MODE  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 440;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:LIPSYNCMODE=" , MAINDATA ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 442;
                                        SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                        __context__.SourceCodeLine = 443;
                                        EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                        __context__.SourceCodeLine = 444;
                                        MAIN_LIP_SYNC_MODE  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 447;
                                        if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:STRAIGHT=" , MAINDATA ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 449;
                                            SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                            __context__.SourceCodeLine = 450;
                                            EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                            __context__.SourceCodeLine = 451;
                                            MAIN_STRAIGHT_MODE_STATUS  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 454;
                                            if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:ENHANCER=" , MAINDATA ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 456;
                                                SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                __context__.SourceCodeLine = 457;
                                                EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                __context__.SourceCodeLine = 458;
                                                MAIN_ENHANCER_STATUS  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 461;
                                                if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:SOUNDPRG=" , MAINDATA ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 463;
                                                    SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                    __context__.SourceCodeLine = 464;
                                                    EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                    __context__.SourceCodeLine = 465;
                                                    MAIN_SOUND_PROG_STATUS  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 468;
                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:ADAPTIVEDSP=" , MAINDATA ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 470;
                                                        SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                        __context__.SourceCodeLine = 471;
                                                        EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                        __context__.SourceCodeLine = 472;
                                                        MAIN_ADAPTIVE_DSP_MODE  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 475;
                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:ADAPTIVEDSP=" , MAINDATA ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 477;
                                                            SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                            __context__.SourceCodeLine = 478;
                                                            EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                            __context__.SourceCodeLine = 479;
                                                            MAIN_3D_CINEMA_MODE  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 482;
                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:EXSURDECODER=" , MAINDATA ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 484;
                                                                SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                                __context__.SourceCodeLine = 485;
                                                                EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                                __context__.SourceCodeLine = 486;
                                                                MAIN_EX_DECODER_MODE  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                } 
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 489;
                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:2CHDECODER=" , MAINDATA ))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 491;
                                                                    SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                                    __context__.SourceCodeLine = 492;
                                                                    EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                                    __context__.SourceCodeLine = 493;
                                                                    MAIN_2CHAN_DECODER_MODE  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                    } 
                                                                
                                                                else 
                                                                    {
                                                                    __context__.SourceCodeLine = 496;
                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:HDMIOUT=" , MAINDATA ))  ) ) 
                                                                        { 
                                                                        __context__.SourceCodeLine = 498;
                                                                        SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                                        __context__.SourceCodeLine = 499;
                                                                        EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                                        __context__.SourceCodeLine = 500;
                                                                        MAIN_CURR_HDMI_OUT_CONFIG  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                        } 
                                                                    
                                                                    else 
                                                                        {
                                                                        __context__.SourceCodeLine = 503;
                                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:HDMIPROCESSING=" , MAINDATA ))  ) ) 
                                                                            { 
                                                                            __context__.SourceCodeLine = 505;
                                                                            SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                                            __context__.SourceCodeLine = 506;
                                                                            EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                                            __context__.SourceCodeLine = 507;
                                                                            MAIN_HDMI_PROC_STATE  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                            } 
                                                                        
                                                                        else 
                                                                            {
                                                                            __context__.SourceCodeLine = 510;
                                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:HDMIASPECT=" , MAINDATA ))  ) ) 
                                                                                { 
                                                                                __context__.SourceCodeLine = 512;
                                                                                SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                                                __context__.SourceCodeLine = 513;
                                                                                EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                                                __context__.SourceCodeLine = 514;
                                                                                MAIN_HDMI_ASPECT  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                                } 
                                                                            
                                                                            else 
                                                                                {
                                                                                __context__.SourceCodeLine = 517;
                                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:HDMIRESOL=" , MAINDATA ))  ) ) 
                                                                                    { 
                                                                                    __context__.SourceCodeLine = 519;
                                                                                    SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                                                    __context__.SourceCodeLine = 520;
                                                                                    EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                                                    __context__.SourceCodeLine = 521;
                                                                                    MAIN_HDMI_RES  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                                    } 
                                                                                
                                                                                else 
                                                                                    {
                                                                                    __context__.SourceCodeLine = 524;
                                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:ZONENAME=" , MAINDATA ))  ) ) 
                                                                                        { 
                                                                                        __context__.SourceCodeLine = 526;
                                                                                        SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                                                        __context__.SourceCodeLine = 527;
                                                                                        EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                                                        __context__.SourceCodeLine = 528;
                                                                                        MAIN_ZONE_NAME  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                                        } 
                                                                                    
                                                                                    else 
                                                                                        {
                                                                                        __context__.SourceCodeLine = 531;
                                                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:SCENE1NAME=" , MAINDATA ))  ) ) 
                                                                                            { 
                                                                                            __context__.SourceCodeLine = 533;
                                                                                            SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                                                            __context__.SourceCodeLine = 534;
                                                                                            EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                                                            __context__.SourceCodeLine = 535;
                                                                                            MAIN_SCENE1_NAME  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                                            } 
                                                                                        
                                                                                        else 
                                                                                            {
                                                                                            __context__.SourceCodeLine = 538;
                                                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:SCENE2NAME=" , MAINDATA ))  ) ) 
                                                                                                { 
                                                                                                __context__.SourceCodeLine = 540;
                                                                                                SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                                                                __context__.SourceCodeLine = 541;
                                                                                                EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                                                                __context__.SourceCodeLine = 542;
                                                                                                MAIN_SCENE2_NAME  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                                                } 
                                                                                            
                                                                                            else 
                                                                                                {
                                                                                                __context__.SourceCodeLine = 545;
                                                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:SCENE3NAME=" , MAINDATA ))  ) ) 
                                                                                                    { 
                                                                                                    __context__.SourceCodeLine = 547;
                                                                                                    SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                                                                    __context__.SourceCodeLine = 548;
                                                                                                    EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                                                                    __context__.SourceCodeLine = 549;
                                                                                                    MAIN_SCENE3_NAME  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                                                    } 
                                                                                                
                                                                                                else 
                                                                                                    {
                                                                                                    __context__.SourceCodeLine = 552;
                                                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:SCENE4NAME=" , MAINDATA ))  ) ) 
                                                                                                        { 
                                                                                                        __context__.SourceCodeLine = 554;
                                                                                                        SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                                                                        __context__.SourceCodeLine = 555;
                                                                                                        EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                                                                        __context__.SourceCodeLine = 556;
                                                                                                        MAIN_SCENE4_NAME  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                                                        } 
                                                                                                    
                                                                                                    else 
                                                                                                        {
                                                                                                        __context__.SourceCodeLine = 559;
                                                                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:SCENE5NAME=" , MAINDATA ))  ) ) 
                                                                                                            { 
                                                                                                            __context__.SourceCodeLine = 561;
                                                                                                            SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                                                                            __context__.SourceCodeLine = 562;
                                                                                                            EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                                                                            __context__.SourceCodeLine = 563;
                                                                                                            MAIN_SCENE5_NAME  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                                                            } 
                                                                                                        
                                                                                                        else 
                                                                                                            {
                                                                                                            __context__.SourceCodeLine = 566;
                                                                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:SCENE6NAME=" , MAINDATA ))  ) ) 
                                                                                                                { 
                                                                                                                __context__.SourceCodeLine = 568;
                                                                                                                SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                                                                                __context__.SourceCodeLine = 569;
                                                                                                                EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                                                                                __context__.SourceCodeLine = 570;
                                                                                                                MAIN_SCENE6_NAME  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                                                                } 
                                                                                                            
                                                                                                            else 
                                                                                                                {
                                                                                                                __context__.SourceCodeLine = 573;
                                                                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:SCENE7NAME=" , MAINDATA ))  ) ) 
                                                                                                                    { 
                                                                                                                    __context__.SourceCodeLine = 575;
                                                                                                                    SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                                                                                    __context__.SourceCodeLine = 576;
                                                                                                                    EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                                                                                    __context__.SourceCodeLine = 577;
                                                                                                                    MAIN_SCENE7_NAME  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                                                                    } 
                                                                                                                
                                                                                                                else 
                                                                                                                    {
                                                                                                                    __context__.SourceCodeLine = 580;
                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:SCENE8NAME=" , MAINDATA ))  ) ) 
                                                                                                                        { 
                                                                                                                        __context__.SourceCodeLine = 582;
                                                                                                                        SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                                                                                        __context__.SourceCodeLine = 583;
                                                                                                                        EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                                                                                        __context__.SourceCodeLine = 584;
                                                                                                                        MAIN_SCENE8_NAME  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                                                                        } 
                                                                                                                    
                                                                                                                    else 
                                                                                                                        {
                                                                                                                        __context__.SourceCodeLine = 587;
                                                                                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:SCENE9NAME=" , MAINDATA ))  ) ) 
                                                                                                                            { 
                                                                                                                            __context__.SourceCodeLine = 589;
                                                                                                                            SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                                                                                            __context__.SourceCodeLine = 590;
                                                                                                                            EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                                                                                            __context__.SourceCodeLine = 591;
                                                                                                                            MAIN_SCENE9_NAME  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                                                                            } 
                                                                                                                        
                                                                                                                        else 
                                                                                                                            {
                                                                                                                            __context__.SourceCodeLine = 594;
                                                                                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:SCENE10NAME=" , MAINDATA ))  ) ) 
                                                                                                                                { 
                                                                                                                                __context__.SourceCodeLine = 596;
                                                                                                                                SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                                                                                                __context__.SourceCodeLine = 597;
                                                                                                                                EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                                                                                                __context__.SourceCodeLine = 598;
                                                                                                                                MAIN_SCENE10_NAME  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                                                                                } 
                                                                                                                            
                                                                                                                            else 
                                                                                                                                {
                                                                                                                                __context__.SourceCodeLine = 601;
                                                                                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:SCENE11NAME=" , MAINDATA ))  ) ) 
                                                                                                                                    { 
                                                                                                                                    __context__.SourceCodeLine = 603;
                                                                                                                                    SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                                                                                                    __context__.SourceCodeLine = 604;
                                                                                                                                    EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                                                                                                    __context__.SourceCodeLine = 605;
                                                                                                                                    MAIN_SCENE11_NAME  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                                                                                    } 
                                                                                                                                
                                                                                                                                else 
                                                                                                                                    {
                                                                                                                                    __context__.SourceCodeLine = 608;
                                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "MAIN:SCENE12NAME=" , MAINDATA ))  ) ) 
                                                                                                                                        { 
                                                                                                                                        __context__.SourceCodeLine = 610;
                                                                                                                                        SPOS = (ushort) ( Functions.Find( "=" , MAINDATA ) ) ; 
                                                                                                                                        __context__.SourceCodeLine = 611;
                                                                                                                                        EPOS = (ushort) ( Functions.Length( MAINDATA ) ) ; 
                                                                                                                                        __context__.SourceCodeLine = 612;
                                                                                                                                        MAIN_SCENE12_NAME  .UpdateValue ( Functions.Mid ( MAINDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                                                                                        } 
                                                                                                                                    
                                                                                                                                    }
                                                                                                                                
                                                                                                                                }
                                                                                                                            
                                                                                                                            }
                                                                                                                        
                                                                                                                        }
                                                                                                                    
                                                                                                                    }
                                                                                                                
                                                                                                                }
                                                                                                            
                                                                                                            }
                                                                                                        
                                                                                                        }
                                                                                                    
                                                                                                    }
                                                                                                
                                                                                                }
                                                                                            
                                                                                            }
                                                                                        
                                                                                        }
                                                                                    
                                                                                    }
                                                                                
                                                                                }
                                                                            
                                                                            }
                                                                        
                                                                        }
                                                                    
                                                                    }
                                                                
                                                                }
                                                            
                                                            }
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            
            }
            
        private void FN_PARSEZONE2 (  SplusExecutionContext __context__, CrestronString ZONE2DATA ) 
            { 
            ushort SPOS = 0;
            
            ushort EPOS = 0;
            
            
            __context__.SourceCodeLine = 623;
            if ( Functions.TestForTrue  ( ( Functions.Find( "ZONE2:SLEEP=" , ZONE2DATA ))  ) ) 
                { 
                __context__.SourceCodeLine = 625;
                SPOS = (ushort) ( Functions.Find( "=" , ZONE2DATA ) ) ; 
                __context__.SourceCodeLine = 626;
                EPOS = (ushort) ( Functions.Length( ZONE2DATA ) ) ; 
                __context__.SourceCodeLine = 627;
                ZONE2_SLEEP_TIMER_TEXT  .UpdateValue ( Functions.Mid ( ZONE2DATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 630;
                if ( Functions.TestForTrue  ( ( Functions.Find( "ZONE2:VOL=" , ZONE2DATA ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 632;
                    SPOS = (ushort) ( Functions.Find( "=" , ZONE2DATA ) ) ; 
                    __context__.SourceCodeLine = 633;
                    EPOS = (ushort) ( Functions.Length( ZONE2DATA ) ) ; 
                    __context__.SourceCodeLine = 634;
                    ZONE2_VOL_TEXT  .UpdateValue ( Functions.Mid ( ZONE2DATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 637;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "ZONE2:ZONENAME=" , ZONE2DATA ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 639;
                        SPOS = (ushort) ( Functions.Find( "=" , ZONE2DATA ) ) ; 
                        __context__.SourceCodeLine = 640;
                        EPOS = (ushort) ( Functions.Length( ZONE2DATA ) ) ; 
                        __context__.SourceCodeLine = 641;
                        ZONE2_NAME  .UpdateValue ( Functions.Mid ( ZONE2DATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 644;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "ZONE2:SCENE1NAME=" , ZONE2DATA ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 646;
                            SPOS = (ushort) ( Functions.Find( "=" , ZONE2DATA ) ) ; 
                            __context__.SourceCodeLine = 647;
                            EPOS = (ushort) ( Functions.Length( ZONE2DATA ) ) ; 
                            __context__.SourceCodeLine = 648;
                            ZONE2_SCENE1_NAME  .UpdateValue ( Functions.Mid ( ZONE2DATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 651;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "ZONE2:SCENE2NAME=" , ZONE2DATA ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 653;
                                SPOS = (ushort) ( Functions.Find( "=" , ZONE2DATA ) ) ; 
                                __context__.SourceCodeLine = 654;
                                EPOS = (ushort) ( Functions.Length( ZONE2DATA ) ) ; 
                                __context__.SourceCodeLine = 655;
                                ZONE2_SCENE2_NAME  .UpdateValue ( Functions.Mid ( ZONE2DATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 658;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "ZONE2:SCENE3NAME=" , ZONE2DATA ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 660;
                                    SPOS = (ushort) ( Functions.Find( "=" , ZONE2DATA ) ) ; 
                                    __context__.SourceCodeLine = 661;
                                    EPOS = (ushort) ( Functions.Length( ZONE2DATA ) ) ; 
                                    __context__.SourceCodeLine = 662;
                                    ZONE2_SCENE3_NAME  .UpdateValue ( Functions.Mid ( ZONE2DATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 665;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "ZONE2:SCENE4NAME=" , ZONE2DATA ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 667;
                                        SPOS = (ushort) ( Functions.Find( "=" , ZONE2DATA ) ) ; 
                                        __context__.SourceCodeLine = 668;
                                        EPOS = (ushort) ( Functions.Length( ZONE2DATA ) ) ; 
                                        __context__.SourceCodeLine = 669;
                                        ZONE2_SCENE4_NAME  .UpdateValue ( Functions.Mid ( ZONE2DATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                        } 
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            
            }
            
        private void FN_PARSEZONE3 (  SplusExecutionContext __context__, CrestronString ZONE3DATA ) 
            { 
            ushort SPOS = 0;
            
            ushort EPOS = 0;
            
            
            __context__.SourceCodeLine = 679;
            if ( Functions.TestForTrue  ( ( Functions.Find( "ZONE3:SLEEP=" , ZONE3DATA ))  ) ) 
                { 
                __context__.SourceCodeLine = 681;
                SPOS = (ushort) ( Functions.Find( "=" , ZONE3DATA ) ) ; 
                __context__.SourceCodeLine = 682;
                EPOS = (ushort) ( Functions.Length( ZONE3DATA ) ) ; 
                __context__.SourceCodeLine = 683;
                ZONE3_SLEEP_TIMER_TEXT  .UpdateValue ( Functions.Mid ( ZONE3DATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 686;
                if ( Functions.TestForTrue  ( ( Functions.Find( "ZONE3:VOL=" , ZONE3DATA ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 688;
                    SPOS = (ushort) ( Functions.Find( "=" , ZONE3DATA ) ) ; 
                    __context__.SourceCodeLine = 689;
                    EPOS = (ushort) ( Functions.Length( ZONE3DATA ) ) ; 
                    __context__.SourceCodeLine = 690;
                    ZONE3_VOL_TEXT  .UpdateValue ( Functions.Mid ( ZONE3DATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 693;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "ZONE3:ZONENAME=" , ZONE3DATA ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 695;
                        SPOS = (ushort) ( Functions.Find( "=" , ZONE3DATA ) ) ; 
                        __context__.SourceCodeLine = 696;
                        EPOS = (ushort) ( Functions.Length( ZONE3DATA ) ) ; 
                        __context__.SourceCodeLine = 697;
                        ZONE3_NAME  .UpdateValue ( Functions.Mid ( ZONE3DATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 700;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "ZONE3:SCENE1NAME=" , ZONE3DATA ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 702;
                            SPOS = (ushort) ( Functions.Find( "=" , ZONE3DATA ) ) ; 
                            __context__.SourceCodeLine = 703;
                            EPOS = (ushort) ( Functions.Length( ZONE3DATA ) ) ; 
                            __context__.SourceCodeLine = 704;
                            ZONE3_SCENE1_NAME  .UpdateValue ( Functions.Mid ( ZONE3DATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 707;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "ZONE3:SCENE2NAME=" , ZONE3DATA ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 709;
                                SPOS = (ushort) ( Functions.Find( "=" , ZONE3DATA ) ) ; 
                                __context__.SourceCodeLine = 710;
                                EPOS = (ushort) ( Functions.Length( ZONE3DATA ) ) ; 
                                __context__.SourceCodeLine = 711;
                                ZONE3_SCENE2_NAME  .UpdateValue ( Functions.Mid ( ZONE3DATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 714;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "ZONE3:SCENE3NAME=" , ZONE3DATA ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 716;
                                    SPOS = (ushort) ( Functions.Find( "=" , ZONE3DATA ) ) ; 
                                    __context__.SourceCodeLine = 717;
                                    EPOS = (ushort) ( Functions.Length( ZONE3DATA ) ) ; 
                                    __context__.SourceCodeLine = 718;
                                    ZONE3_SCENE3_NAME  .UpdateValue ( Functions.Mid ( ZONE3DATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 721;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "ZONE3:SCENE4NAME=" , ZONE3DATA ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 723;
                                        SPOS = (ushort) ( Functions.Find( "=" , ZONE3DATA ) ) ; 
                                        __context__.SourceCodeLine = 724;
                                        EPOS = (ushort) ( Functions.Length( ZONE3DATA ) ) ; 
                                        __context__.SourceCodeLine = 725;
                                        ZONE3_SCENE4_NAME  .UpdateValue ( Functions.Mid ( ZONE3DATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                        } 
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            
            }
            
        private void FN_PARSEZONE4 (  SplusExecutionContext __context__, CrestronString ZONE4DATA ) 
            { 
            ushort SPOS = 0;
            
            ushort EPOS = 0;
            
            
            __context__.SourceCodeLine = 736;
            if ( Functions.TestForTrue  ( ( Functions.Find( "ZONE4:SLEEP=" , ZONE4DATA ))  ) ) 
                { 
                __context__.SourceCodeLine = 738;
                SPOS = (ushort) ( Functions.Find( "=" , ZONE4DATA ) ) ; 
                __context__.SourceCodeLine = 739;
                EPOS = (ushort) ( Functions.Length( ZONE4DATA ) ) ; 
                __context__.SourceCodeLine = 740;
                ZONE3_SLEEP_TIMER_TEXT  .UpdateValue ( Functions.Mid ( ZONE4DATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 743;
                if ( Functions.TestForTrue  ( ( Functions.Find( "ZONE4:ZONENAME=" , ZONE4DATA ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 745;
                    SPOS = (ushort) ( Functions.Find( "=" , ZONE4DATA ) ) ; 
                    __context__.SourceCodeLine = 746;
                    EPOS = (ushort) ( Functions.Length( ZONE4DATA ) ) ; 
                    __context__.SourceCodeLine = 747;
                    ZONE4_NAME  .UpdateValue ( Functions.Mid ( ZONE4DATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 750;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "ZONE4:SCENE1NAME=" , ZONE4DATA ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 752;
                        SPOS = (ushort) ( Functions.Find( "=" , ZONE4DATA ) ) ; 
                        __context__.SourceCodeLine = 753;
                        EPOS = (ushort) ( Functions.Length( ZONE4DATA ) ) ; 
                        __context__.SourceCodeLine = 754;
                        ZONE4_SCENE1_NAME  .UpdateValue ( Functions.Mid ( ZONE4DATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 757;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "ZONE4:SCENE2NAME=" , ZONE4DATA ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 759;
                            SPOS = (ushort) ( Functions.Find( "=" , ZONE4DATA ) ) ; 
                            __context__.SourceCodeLine = 760;
                            EPOS = (ushort) ( Functions.Length( ZONE4DATA ) ) ; 
                            __context__.SourceCodeLine = 761;
                            ZONE4_SCENE2_NAME  .UpdateValue ( Functions.Mid ( ZONE4DATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 764;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "ZONE4:SCENE3NAME=" , ZONE4DATA ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 766;
                                SPOS = (ushort) ( Functions.Find( "=" , ZONE4DATA ) ) ; 
                                __context__.SourceCodeLine = 767;
                                EPOS = (ushort) ( Functions.Length( ZONE4DATA ) ) ; 
                                __context__.SourceCodeLine = 768;
                                ZONE4_SCENE3_NAME  .UpdateValue ( Functions.Mid ( ZONE4DATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 771;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "ZONE4:SCENE4NAME=" , ZONE4DATA ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 773;
                                    SPOS = (ushort) ( Functions.Find( "=" , ZONE4DATA ) ) ; 
                                    __context__.SourceCodeLine = 774;
                                    EPOS = (ushort) ( Functions.Length( ZONE4DATA ) ) ; 
                                    __context__.SourceCodeLine = 775;
                                    ZONE4_SCENE4_NAME  .UpdateValue ( Functions.Mid ( ZONE4DATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                    } 
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            
            }
            
        private void FN_PARSETUNER (  SplusExecutionContext __context__, CrestronString TUNERDATA ) 
            { 
            ushort SPOS = 0;
            
            ushort EPOS = 0;
            
            
            __context__.SourceCodeLine = 786;
            if ( Functions.TestForTrue  ( ( Functions.Find( "HDRADIO:FMFREQ=" , TUNERDATA ))  ) ) 
                { 
                __context__.SourceCodeLine = 788;
                SPOS = (ushort) ( Functions.Find( "=" , TUNERDATA ) ) ; 
                __context__.SourceCodeLine = 789;
                EPOS = (ushort) ( Functions.Length( TUNERDATA ) ) ; 
                __context__.SourceCodeLine = 790;
                TUNER_CURR_STATION  .UpdateValue ( Functions.Mid ( TUNERDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 793;
                if ( Functions.TestForTrue  ( ( Functions.Find( "HDRADIO:PRGNUM=" , TUNERDATA ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 795;
                    SPOS = (ushort) ( Functions.Find( "=" , TUNERDATA ) ) ; 
                    __context__.SourceCodeLine = 796;
                    EPOS = (ushort) ( Functions.Length( TUNERDATA ) ) ; 
                    __context__.SourceCodeLine = 797;
                    TUNER_CURR_PROGRAM_NUMBER  .UpdateValue ( Functions.Mid ( TUNERDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 800;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "HDRADIO:PRGTYPE=" , TUNERDATA ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 802;
                        SPOS = (ushort) ( Functions.Find( "=" , TUNERDATA ) ) ; 
                        __context__.SourceCodeLine = 803;
                        EPOS = (ushort) ( Functions.Length( TUNERDATA ) ) ; 
                        __context__.SourceCodeLine = 804;
                        TUNER_CURR_PROGRAM_TYPE  .UpdateValue ( Functions.Mid ( TUNERDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 807;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "HDRADIO:SONG=" , TUNERDATA ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 809;
                            SPOS = (ushort) ( Functions.Find( "=" , TUNERDATA ) ) ; 
                            __context__.SourceCodeLine = 810;
                            EPOS = (ushort) ( Functions.Length( TUNERDATA ) ) ; 
                            __context__.SourceCodeLine = 811;
                            TUNER_CURR_SONG  .UpdateValue ( Functions.Mid ( TUNERDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 814;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "HDRADIO:ARTIST=" , TUNERDATA ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 816;
                                SPOS = (ushort) ( Functions.Find( "=" , TUNERDATA ) ) ; 
                                __context__.SourceCodeLine = 817;
                                EPOS = (ushort) ( Functions.Length( TUNERDATA ) ) ; 
                                __context__.SourceCodeLine = 818;
                                TUNER_CURR_ARTIST  .UpdateValue ( Functions.Mid ( TUNERDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 821;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "HDRADIO:ALBUM=" , TUNERDATA ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 823;
                                    SPOS = (ushort) ( Functions.Find( "=" , TUNERDATA ) ) ; 
                                    __context__.SourceCodeLine = 824;
                                    EPOS = (ushort) ( Functions.Length( TUNERDATA ) ) ; 
                                    __context__.SourceCodeLine = 825;
                                    TUNER_CURR_ALBUM  .UpdateValue ( Functions.Mid ( TUNERDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 828;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "HDRADIO:AVAILPRG1=Available" , TUNERDATA ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 830;
                                        SPOS = (ushort) ( Functions.Find( "=" , TUNERDATA ) ) ; 
                                        __context__.SourceCodeLine = 831;
                                        EPOS = (ushort) ( Functions.Length( TUNERDATA ) ) ; 
                                        __context__.SourceCodeLine = 832;
                                        TUNER_PROGRAM1_AVAIL  .Value = (ushort) ( 1 ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 835;
                                        if ( Functions.TestForTrue  ( ( Functions.Find( "HDRADIO:AVAILPRG2=Available" , TUNERDATA ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 837;
                                            SPOS = (ushort) ( Functions.Find( "=" , TUNERDATA ) ) ; 
                                            __context__.SourceCodeLine = 838;
                                            EPOS = (ushort) ( Functions.Length( TUNERDATA ) ) ; 
                                            __context__.SourceCodeLine = 839;
                                            TUNER_PROGRAM2_AVAIL  .Value = (ushort) ( 1 ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 842;
                                            if ( Functions.TestForTrue  ( ( Functions.Find( "HDRADIO:AVAILPRG3=Available" , TUNERDATA ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 844;
                                                SPOS = (ushort) ( Functions.Find( "=" , TUNERDATA ) ) ; 
                                                __context__.SourceCodeLine = 845;
                                                EPOS = (ushort) ( Functions.Length( TUNERDATA ) ) ; 
                                                __context__.SourceCodeLine = 846;
                                                TUNER_PROGRAM3_AVAIL  .Value = (ushort) ( 1 ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 849;
                                                if ( Functions.TestForTrue  ( ( Functions.Find( "HDRADIO:AVAILPRG4=Available" , TUNERDATA ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 851;
                                                    SPOS = (ushort) ( Functions.Find( "=" , TUNERDATA ) ) ; 
                                                    __context__.SourceCodeLine = 852;
                                                    EPOS = (ushort) ( Functions.Length( TUNERDATA ) ) ; 
                                                    __context__.SourceCodeLine = 853;
                                                    TUNER_PROGRAM4_AVAIL  .Value = (ushort) ( 1 ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 856;
                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "HDRADIO:AVAILPRG5=Available" , TUNERDATA ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 858;
                                                        SPOS = (ushort) ( Functions.Find( "=" , TUNERDATA ) ) ; 
                                                        __context__.SourceCodeLine = 859;
                                                        EPOS = (ushort) ( Functions.Length( TUNERDATA ) ) ; 
                                                        __context__.SourceCodeLine = 860;
                                                        TUNER_PROGRAM5_AVAIL  .Value = (ushort) ( 1 ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 863;
                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "HDRADIO:AVAILPRG6=Available" , TUNERDATA ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 865;
                                                            SPOS = (ushort) ( Functions.Find( "=" , TUNERDATA ) ) ; 
                                                            __context__.SourceCodeLine = 866;
                                                            EPOS = (ushort) ( Functions.Length( TUNERDATA ) ) ; 
                                                            __context__.SourceCodeLine = 867;
                                                            TUNER_PROGRAM6_AVAIL  .Value = (ushort) ( 1 ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 870;
                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "HDRADIO:AVAILPRG7=Available" , TUNERDATA ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 872;
                                                                SPOS = (ushort) ( Functions.Find( "=" , TUNERDATA ) ) ; 
                                                                __context__.SourceCodeLine = 873;
                                                                EPOS = (ushort) ( Functions.Length( TUNERDATA ) ) ; 
                                                                __context__.SourceCodeLine = 874;
                                                                TUNER_PROGRAM7_AVAIL  .Value = (ushort) ( 1 ) ; 
                                                                } 
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 877;
                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "HDRADIO:AVAILPRG8=Available" , TUNERDATA ))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 879;
                                                                    SPOS = (ushort) ( Functions.Find( "=" , TUNERDATA ) ) ; 
                                                                    __context__.SourceCodeLine = 880;
                                                                    EPOS = (ushort) ( Functions.Length( TUNERDATA ) ) ; 
                                                                    __context__.SourceCodeLine = 881;
                                                                    TUNER_PROGRAM8_AVAIL  .Value = (ushort) ( 1 ) ; 
                                                                    } 
                                                                
                                                                }
                                                            
                                                            }
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            
            }
            
        private void FN_PARSENAPSTER (  SplusExecutionContext __context__, CrestronString NAPSTERDATA ) 
            { 
            ushort SPOS = 0;
            
            ushort EPOS = 0;
            
            
            __context__.SourceCodeLine = 893;
            if ( Functions.TestForTrue  ( ( Functions.Find( "NAPSTER:LISTLAYER=" , NAPSTERDATA ))  ) ) 
                { 
                __context__.SourceCodeLine = 895;
                SPOS = (ushort) ( Functions.Find( "=" , NAPSTERDATA ) ) ; 
                __context__.SourceCodeLine = 896;
                EPOS = (ushort) ( Functions.Length( NAPSTERDATA ) ) ; 
                __context__.SourceCodeLine = 897;
                NAPLISTLAYER  .UpdateValue ( Functions.Mid ( NAPSTERDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 900;
                if ( Functions.TestForTrue  ( ( Functions.Find( "NAPSTER:LISTLAYERNAME=" , NAPSTERDATA ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 902;
                    SPOS = (ushort) ( Functions.Find( "=" , NAPSTERDATA ) ) ; 
                    __context__.SourceCodeLine = 903;
                    EPOS = (ushort) ( Functions.Length( NAPSTERDATA ) ) ; 
                    __context__.SourceCodeLine = 904;
                    NAPLISTNAME  .UpdateValue ( Functions.Mid ( NAPSTERDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 907;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "NAPSTER:LINE1TXT=" , NAPSTERDATA ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 909;
                        SPOS = (ushort) ( Functions.Find( "=" , NAPSTERDATA ) ) ; 
                        __context__.SourceCodeLine = 910;
                        EPOS = (ushort) ( Functions.Length( NAPSTERDATA ) ) ; 
                        __context__.SourceCodeLine = 911;
                        NAPLINE1TEXT  .UpdateValue ( Functions.Mid ( NAPSTERDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 914;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "NAPSTER:LINE2TXT=" , NAPSTERDATA ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 916;
                            SPOS = (ushort) ( Functions.Find( "=" , NAPSTERDATA ) ) ; 
                            __context__.SourceCodeLine = 917;
                            EPOS = (ushort) ( Functions.Length( NAPSTERDATA ) ) ; 
                            __context__.SourceCodeLine = 918;
                            NAPLINE2TEXT  .UpdateValue ( Functions.Mid ( NAPSTERDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 921;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "NAPSTER:LINE3TXT=" , NAPSTERDATA ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 923;
                                SPOS = (ushort) ( Functions.Find( "=" , NAPSTERDATA ) ) ; 
                                __context__.SourceCodeLine = 924;
                                EPOS = (ushort) ( Functions.Length( NAPSTERDATA ) ) ; 
                                __context__.SourceCodeLine = 925;
                                NAPLINE3TEXT  .UpdateValue ( Functions.Mid ( NAPSTERDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 928;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "NAPSTER:LINE4TXT=" , NAPSTERDATA ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 930;
                                    SPOS = (ushort) ( Functions.Find( "=" , NAPSTERDATA ) ) ; 
                                    __context__.SourceCodeLine = 931;
                                    EPOS = (ushort) ( Functions.Length( NAPSTERDATA ) ) ; 
                                    __context__.SourceCodeLine = 932;
                                    NAPLINE4TEXT  .UpdateValue ( Functions.Mid ( NAPSTERDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 935;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "NAPSTER:LINE5TXT=" , NAPSTERDATA ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 937;
                                        SPOS = (ushort) ( Functions.Find( "=" , NAPSTERDATA ) ) ; 
                                        __context__.SourceCodeLine = 938;
                                        EPOS = (ushort) ( Functions.Length( NAPSTERDATA ) ) ; 
                                        __context__.SourceCodeLine = 939;
                                        NAPLINE5TEXT  .UpdateValue ( Functions.Mid ( NAPSTERDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 942;
                                        if ( Functions.TestForTrue  ( ( Functions.Find( "NAPSTER:LINE6TXT=" , NAPSTERDATA ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 944;
                                            SPOS = (ushort) ( Functions.Find( "=" , NAPSTERDATA ) ) ; 
                                            __context__.SourceCodeLine = 945;
                                            EPOS = (ushort) ( Functions.Length( NAPSTERDATA ) ) ; 
                                            __context__.SourceCodeLine = 946;
                                            NAPLINE6TEXT  .UpdateValue ( Functions.Mid ( NAPSTERDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 949;
                                            if ( Functions.TestForTrue  ( ( Functions.Find( "NAPSTER:LINE7TXT=" , NAPSTERDATA ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 951;
                                                SPOS = (ushort) ( Functions.Find( "=" , NAPSTERDATA ) ) ; 
                                                __context__.SourceCodeLine = 952;
                                                EPOS = (ushort) ( Functions.Length( NAPSTERDATA ) ) ; 
                                                __context__.SourceCodeLine = 953;
                                                NAPLINE7TEXT  .UpdateValue ( Functions.Mid ( NAPSTERDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 956;
                                                if ( Functions.TestForTrue  ( ( Functions.Find( "NAPSTER:LINE8TXT=" , NAPSTERDATA ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 958;
                                                    SPOS = (ushort) ( Functions.Find( "=" , NAPSTERDATA ) ) ; 
                                                    __context__.SourceCodeLine = 959;
                                                    EPOS = (ushort) ( Functions.Length( NAPSTERDATA ) ) ; 
                                                    __context__.SourceCodeLine = 960;
                                                    NAPLINE8TEXT  .UpdateValue ( Functions.Mid ( NAPSTERDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 963;
                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "NAPSTER:SONG=" , NAPSTERDATA ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 965;
                                                        SPOS = (ushort) ( Functions.Find( "=" , NAPSTERDATA ) ) ; 
                                                        __context__.SourceCodeLine = 966;
                                                        EPOS = (ushort) ( Functions.Length( NAPSTERDATA ) ) ; 
                                                        __context__.SourceCodeLine = 967;
                                                        NAPCURRSONGTEXT  .UpdateValue ( Functions.Mid ( NAPSTERDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 970;
                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "NAPSTER:ARTIST=" , NAPSTERDATA ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 972;
                                                            SPOS = (ushort) ( Functions.Find( "=" , NAPSTERDATA ) ) ; 
                                                            __context__.SourceCodeLine = 973;
                                                            EPOS = (ushort) ( Functions.Length( NAPSTERDATA ) ) ; 
                                                            __context__.SourceCodeLine = 974;
                                                            NAPCURRARTISTTEXT  .UpdateValue ( Functions.Mid ( NAPSTERDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 977;
                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "NAPSTER:ALBUM=" , NAPSTERDATA ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 979;
                                                                SPOS = (ushort) ( Functions.Find( "=" , NAPSTERDATA ) ) ; 
                                                                __context__.SourceCodeLine = 980;
                                                                EPOS = (ushort) ( Functions.Length( NAPSTERDATA ) ) ; 
                                                                __context__.SourceCodeLine = 981;
                                                                NAPCURRALBUMTEXT  .UpdateValue ( Functions.Mid ( NAPSTERDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                } 
                                                            
                                                            }
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            
            }
            
        private void FN_PARSESIRIUSIR (  SplusExecutionContext __context__, CrestronString SIRIUSIRDATA ) 
            { 
            ushort SPOS = 0;
            
            ushort EPOS = 0;
            
            
            __context__.SourceCodeLine = 992;
            if ( Functions.TestForTrue  ( ( Functions.Find( "SIRIUSIR:LISTLAYER=" , SIRIUSIRDATA ))  ) ) 
                { 
                __context__.SourceCodeLine = 994;
                SPOS = (ushort) ( Functions.Find( "=" , SIRIUSIRDATA ) ) ; 
                __context__.SourceCodeLine = 995;
                EPOS = (ushort) ( Functions.Length( SIRIUSIRDATA ) ) ; 
                __context__.SourceCodeLine = 996;
                SIRIUSIRLISTLAYER  .UpdateValue ( Functions.Mid ( SIRIUSIRDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 999;
                if ( Functions.TestForTrue  ( ( Functions.Find( "SIRIUSIR:LISTLAYERNAME=" , SIRIUSIRDATA ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1001;
                    SPOS = (ushort) ( Functions.Find( "=" , SIRIUSIRDATA ) ) ; 
                    __context__.SourceCodeLine = 1002;
                    EPOS = (ushort) ( Functions.Length( SIRIUSIRDATA ) ) ; 
                    __context__.SourceCodeLine = 1003;
                    SIRIUSIRLISTNAME  .UpdateValue ( Functions.Mid ( SIRIUSIRDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 1006;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "SIRIUSIR:LINE1TXT=" , SIRIUSIRDATA ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1008;
                        SPOS = (ushort) ( Functions.Find( "=" , SIRIUSIRDATA ) ) ; 
                        __context__.SourceCodeLine = 1009;
                        EPOS = (ushort) ( Functions.Length( SIRIUSIRDATA ) ) ; 
                        __context__.SourceCodeLine = 1010;
                        SIRIUSIRLINE1TEXT  .UpdateValue ( Functions.Mid ( SIRIUSIRDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1013;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "SIRIUSIR:LINE2TXT=" , SIRIUSIRDATA ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1015;
                            SPOS = (ushort) ( Functions.Find( "=" , SIRIUSIRDATA ) ) ; 
                            __context__.SourceCodeLine = 1016;
                            EPOS = (ushort) ( Functions.Length( SIRIUSIRDATA ) ) ; 
                            __context__.SourceCodeLine = 1017;
                            SIRIUSIRLINE2TEXT  .UpdateValue ( Functions.Mid ( SIRIUSIRDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 1020;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "SIRIUSIR:LINE3TXT=" , SIRIUSIRDATA ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1022;
                                SPOS = (ushort) ( Functions.Find( "=" , SIRIUSIRDATA ) ) ; 
                                __context__.SourceCodeLine = 1023;
                                EPOS = (ushort) ( Functions.Length( SIRIUSIRDATA ) ) ; 
                                __context__.SourceCodeLine = 1024;
                                SIRIUSIRLINE3TEXT  .UpdateValue ( Functions.Mid ( SIRIUSIRDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 1027;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "SIRIUSIR:LINE4TXT=" , SIRIUSIRDATA ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 1029;
                                    SPOS = (ushort) ( Functions.Find( "=" , SIRIUSIRDATA ) ) ; 
                                    __context__.SourceCodeLine = 1030;
                                    EPOS = (ushort) ( Functions.Length( SIRIUSIRDATA ) ) ; 
                                    __context__.SourceCodeLine = 1031;
                                    SIRIUSIRLINE4TEXT  .UpdateValue ( Functions.Mid ( SIRIUSIRDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 1034;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "SIRIUSIR:LINE5TXT=" , SIRIUSIRDATA ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 1036;
                                        SPOS = (ushort) ( Functions.Find( "=" , SIRIUSIRDATA ) ) ; 
                                        __context__.SourceCodeLine = 1037;
                                        EPOS = (ushort) ( Functions.Length( SIRIUSIRDATA ) ) ; 
                                        __context__.SourceCodeLine = 1038;
                                        SIRIUSIRLINE5TEXT  .UpdateValue ( Functions.Mid ( SIRIUSIRDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 1041;
                                        if ( Functions.TestForTrue  ( ( Functions.Find( "SIRIUSIR:LINE6TXT=" , SIRIUSIRDATA ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 1043;
                                            SPOS = (ushort) ( Functions.Find( "=" , SIRIUSIRDATA ) ) ; 
                                            __context__.SourceCodeLine = 1044;
                                            EPOS = (ushort) ( Functions.Length( SIRIUSIRDATA ) ) ; 
                                            __context__.SourceCodeLine = 1045;
                                            SIRIUSIRLINE6TEXT  .UpdateValue ( Functions.Mid ( SIRIUSIRDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 1048;
                                            if ( Functions.TestForTrue  ( ( Functions.Find( "SIRIUSIR:LINE7TXT=" , SIRIUSIRDATA ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 1050;
                                                SPOS = (ushort) ( Functions.Find( "=" , SIRIUSIRDATA ) ) ; 
                                                __context__.SourceCodeLine = 1051;
                                                EPOS = (ushort) ( Functions.Length( SIRIUSIRDATA ) ) ; 
                                                __context__.SourceCodeLine = 1052;
                                                SIRIUSIRLINE7TEXT  .UpdateValue ( Functions.Mid ( SIRIUSIRDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 1055;
                                                if ( Functions.TestForTrue  ( ( Functions.Find( "SIRIUSIR:LINE8TXT=" , SIRIUSIRDATA ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 1057;
                                                    SPOS = (ushort) ( Functions.Find( "=" , SIRIUSIRDATA ) ) ; 
                                                    __context__.SourceCodeLine = 1058;
                                                    EPOS = (ushort) ( Functions.Length( SIRIUSIRDATA ) ) ; 
                                                    __context__.SourceCodeLine = 1059;
                                                    SIRIUSIRLINE8TEXT  .UpdateValue ( Functions.Mid ( SIRIUSIRDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 1062;
                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "SIRIUSIR:SONG=" , SIRIUSIRDATA ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 1064;
                                                        SPOS = (ushort) ( Functions.Find( "=" , SIRIUSIRDATA ) ) ; 
                                                        __context__.SourceCodeLine = 1065;
                                                        EPOS = (ushort) ( Functions.Length( SIRIUSIRDATA ) ) ; 
                                                        __context__.SourceCodeLine = 1066;
                                                        SIRIUSIRCURRSONGTEXT  .UpdateValue ( Functions.Mid ( SIRIUSIRDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 1069;
                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "SIRIUSIR:ARTIST=" , SIRIUSIRDATA ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 1071;
                                                            SPOS = (ushort) ( Functions.Find( "=" , SIRIUSIRDATA ) ) ; 
                                                            __context__.SourceCodeLine = 1072;
                                                            EPOS = (ushort) ( Functions.Length( SIRIUSIRDATA ) ) ; 
                                                            __context__.SourceCodeLine = 1073;
                                                            SIRIUSIRCURRARTISTTEXT  .UpdateValue ( Functions.Mid ( SIRIUSIRDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 1076;
                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "SIRIUSIR:ALBUM=" , SIRIUSIRDATA ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 1078;
                                                                SPOS = (ushort) ( Functions.Find( "=" , SIRIUSIRDATA ) ) ; 
                                                                __context__.SourceCodeLine = 1079;
                                                                EPOS = (ushort) ( Functions.Length( SIRIUSIRDATA ) ) ; 
                                                                __context__.SourceCodeLine = 1080;
                                                                SIRIUSIRCURRALBUMTEXT  .UpdateValue ( Functions.Mid ( SIRIUSIRDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                } 
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 1083;
                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "SIRIUSIR:CHNAME=" , SIRIUSIRDATA ))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 1085;
                                                                    SPOS = (ushort) ( Functions.Find( "=" , SIRIUSIRDATA ) ) ; 
                                                                    __context__.SourceCodeLine = 1086;
                                                                    EPOS = (ushort) ( Functions.Length( SIRIUSIRDATA ) ) ; 
                                                                    __context__.SourceCodeLine = 1087;
                                                                    SIRIUSIRCURRCHANNELTEXT  .UpdateValue ( Functions.Mid ( SIRIUSIRDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                    } 
                                                                
                                                                }
                                                            
                                                            }
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            
            }
            
        private void FN_PARSERHAP (  SplusExecutionContext __context__, CrestronString RHAPDATA ) 
            { 
            ushort SPOS = 0;
            
            ushort EPOS = 0;
            
            
            __context__.SourceCodeLine = 1098;
            if ( Functions.TestForTrue  ( ( Functions.Find( "RHAP:LISTLAYER=" , RHAPDATA ))  ) ) 
                { 
                __context__.SourceCodeLine = 1100;
                SPOS = (ushort) ( Functions.Find( "=" , RHAPDATA ) ) ; 
                __context__.SourceCodeLine = 1101;
                EPOS = (ushort) ( Functions.Length( RHAPDATA ) ) ; 
                __context__.SourceCodeLine = 1102;
                RHAPLISTLAYER  .UpdateValue ( Functions.Mid ( RHAPDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 1105;
                if ( Functions.TestForTrue  ( ( Functions.Find( "RHAP:LISTLAYERNAME=" , RHAPDATA ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1107;
                    SPOS = (ushort) ( Functions.Find( "=" , RHAPDATA ) ) ; 
                    __context__.SourceCodeLine = 1108;
                    EPOS = (ushort) ( Functions.Length( RHAPDATA ) ) ; 
                    __context__.SourceCodeLine = 1109;
                    RHAPLISTNAME  .UpdateValue ( Functions.Mid ( RHAPDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 1112;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "RHAP:LINE1TXT=" , RHAPDATA ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1114;
                        SPOS = (ushort) ( Functions.Find( "=" , RHAPDATA ) ) ; 
                        __context__.SourceCodeLine = 1115;
                        EPOS = (ushort) ( Functions.Length( RHAPDATA ) ) ; 
                        __context__.SourceCodeLine = 1116;
                        RHAPLINE1TEXT  .UpdateValue ( Functions.Mid ( RHAPDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1119;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "RHAP:LINE2TXT=" , RHAPDATA ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1121;
                            SPOS = (ushort) ( Functions.Find( "=" , RHAPDATA ) ) ; 
                            __context__.SourceCodeLine = 1122;
                            EPOS = (ushort) ( Functions.Length( RHAPDATA ) ) ; 
                            __context__.SourceCodeLine = 1123;
                            RHAPLINE2TEXT  .UpdateValue ( Functions.Mid ( RHAPDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 1126;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "RHAP:LINE3TXT=" , RHAPDATA ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1128;
                                SPOS = (ushort) ( Functions.Find( "=" , RHAPDATA ) ) ; 
                                __context__.SourceCodeLine = 1129;
                                EPOS = (ushort) ( Functions.Length( RHAPDATA ) ) ; 
                                __context__.SourceCodeLine = 1130;
                                RHAPLINE3TEXT  .UpdateValue ( Functions.Mid ( RHAPDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 1133;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "RHAP:LINE4TXT=" , RHAPDATA ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 1135;
                                    SPOS = (ushort) ( Functions.Find( "=" , RHAPDATA ) ) ; 
                                    __context__.SourceCodeLine = 1136;
                                    EPOS = (ushort) ( Functions.Length( RHAPDATA ) ) ; 
                                    __context__.SourceCodeLine = 1137;
                                    RHAPLINE4TEXT  .UpdateValue ( Functions.Mid ( RHAPDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 1140;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "RHAP:LINE5TXT=" , RHAPDATA ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 1142;
                                        SPOS = (ushort) ( Functions.Find( "=" , RHAPDATA ) ) ; 
                                        __context__.SourceCodeLine = 1143;
                                        EPOS = (ushort) ( Functions.Length( RHAPDATA ) ) ; 
                                        __context__.SourceCodeLine = 1144;
                                        RHAPLINE5TEXT  .UpdateValue ( Functions.Mid ( RHAPDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 1147;
                                        if ( Functions.TestForTrue  ( ( Functions.Find( "RHAP:LINE6TXT=" , RHAPDATA ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 1149;
                                            SPOS = (ushort) ( Functions.Find( "=" , RHAPDATA ) ) ; 
                                            __context__.SourceCodeLine = 1150;
                                            EPOS = (ushort) ( Functions.Length( RHAPDATA ) ) ; 
                                            __context__.SourceCodeLine = 1151;
                                            RHAPLINE6TEXT  .UpdateValue ( Functions.Mid ( RHAPDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 1154;
                                            if ( Functions.TestForTrue  ( ( Functions.Find( "RHAP:LINE7TXT=" , RHAPDATA ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 1156;
                                                SPOS = (ushort) ( Functions.Find( "=" , RHAPDATA ) ) ; 
                                                __context__.SourceCodeLine = 1157;
                                                EPOS = (ushort) ( Functions.Length( RHAPDATA ) ) ; 
                                                __context__.SourceCodeLine = 1158;
                                                RHAPLINE7TEXT  .UpdateValue ( Functions.Mid ( RHAPDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 1161;
                                                if ( Functions.TestForTrue  ( ( Functions.Find( "RHAP:LINE8TXT=" , RHAPDATA ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 1163;
                                                    SPOS = (ushort) ( Functions.Find( "=" , RHAPDATA ) ) ; 
                                                    __context__.SourceCodeLine = 1164;
                                                    EPOS = (ushort) ( Functions.Length( RHAPDATA ) ) ; 
                                                    __context__.SourceCodeLine = 1165;
                                                    RHAPLINE8TEXT  .UpdateValue ( Functions.Mid ( RHAPDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 1168;
                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "RHAP:SONG=" , RHAPDATA ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 1170;
                                                        SPOS = (ushort) ( Functions.Find( "=" , RHAPDATA ) ) ; 
                                                        __context__.SourceCodeLine = 1171;
                                                        EPOS = (ushort) ( Functions.Length( RHAPDATA ) ) ; 
                                                        __context__.SourceCodeLine = 1172;
                                                        RHAPCURRSONGTEXT  .UpdateValue ( Functions.Mid ( RHAPDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 1175;
                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "RHAP:ARTIST=" , RHAPDATA ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 1177;
                                                            SPOS = (ushort) ( Functions.Find( "=" , RHAPDATA ) ) ; 
                                                            __context__.SourceCodeLine = 1178;
                                                            EPOS = (ushort) ( Functions.Length( RHAPDATA ) ) ; 
                                                            __context__.SourceCodeLine = 1179;
                                                            RHAPCURRARTISTTEXT  .UpdateValue ( Functions.Mid ( RHAPDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 1182;
                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "RHAP:ALBUM=" , RHAPDATA ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 1184;
                                                                SPOS = (ushort) ( Functions.Find( "=" , RHAPDATA ) ) ; 
                                                                __context__.SourceCodeLine = 1185;
                                                                EPOS = (ushort) ( Functions.Length( RHAPDATA ) ) ; 
                                                                __context__.SourceCodeLine = 1186;
                                                                RHAPCURRALBUMTEXT  .UpdateValue ( Functions.Mid ( RHAPDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                } 
                                                            
                                                            }
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            
            }
            
        private void FN_PARSEPC (  SplusExecutionContext __context__, CrestronString PCINFO ) 
            { 
            ushort SPOS = 0;
            
            ushort EPOS = 0;
            
            
            __context__.SourceCodeLine = 1196;
            if ( Functions.TestForTrue  ( ( Functions.Find( "PC:LISTLAYER=" , PCINFO ))  ) ) 
                { 
                __context__.SourceCodeLine = 1198;
                SPOS = (ushort) ( Functions.Find( "=" , PCINFO ) ) ; 
                __context__.SourceCodeLine = 1199;
                EPOS = (ushort) ( Functions.Length( PCINFO ) ) ; 
                __context__.SourceCodeLine = 1200;
                PCLISTLAYER  .UpdateValue ( Functions.Mid ( PCINFO ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 1203;
                if ( Functions.TestForTrue  ( ( Functions.Find( "PC:LISTLAYERNAME=" , PCINFO ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1205;
                    SPOS = (ushort) ( Functions.Find( "=" , PCINFO ) ) ; 
                    __context__.SourceCodeLine = 1206;
                    EPOS = (ushort) ( Functions.Length( PCINFO ) ) ; 
                    __context__.SourceCodeLine = 1207;
                    PCLISTNAME  .UpdateValue ( Functions.Mid ( PCINFO ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 1210;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "PC:LINE1TXT=" , PCINFO ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1212;
                        SPOS = (ushort) ( Functions.Find( "=" , PCINFO ) ) ; 
                        __context__.SourceCodeLine = 1213;
                        EPOS = (ushort) ( Functions.Length( PCINFO ) ) ; 
                        __context__.SourceCodeLine = 1214;
                        PCLINE1TEXT  .UpdateValue ( Functions.Mid ( PCINFO ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1217;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "PC:LINE2TXT=" , PCINFO ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1219;
                            SPOS = (ushort) ( Functions.Find( "=" , PCINFO ) ) ; 
                            __context__.SourceCodeLine = 1220;
                            EPOS = (ushort) ( Functions.Length( PCINFO ) ) ; 
                            __context__.SourceCodeLine = 1221;
                            PCLINE2TEXT  .UpdateValue ( Functions.Mid ( PCINFO ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 1224;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "PC:LINE3TXT=" , PCINFO ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1226;
                                SPOS = (ushort) ( Functions.Find( "=" , PCINFO ) ) ; 
                                __context__.SourceCodeLine = 1227;
                                EPOS = (ushort) ( Functions.Length( PCINFO ) ) ; 
                                __context__.SourceCodeLine = 1228;
                                PCLINE3TEXT  .UpdateValue ( Functions.Mid ( PCINFO ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 1231;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "PC:LINE4TXT=" , PCINFO ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 1233;
                                    SPOS = (ushort) ( Functions.Find( "=" , PCINFO ) ) ; 
                                    __context__.SourceCodeLine = 1234;
                                    EPOS = (ushort) ( Functions.Length( PCINFO ) ) ; 
                                    __context__.SourceCodeLine = 1235;
                                    PCLINE4TEXT  .UpdateValue ( Functions.Mid ( PCINFO ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 1238;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "PC:LINE5TXT=" , PCINFO ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 1240;
                                        SPOS = (ushort) ( Functions.Find( "=" , PCINFO ) ) ; 
                                        __context__.SourceCodeLine = 1241;
                                        EPOS = (ushort) ( Functions.Length( PCINFO ) ) ; 
                                        __context__.SourceCodeLine = 1242;
                                        PCLINE5TEXT  .UpdateValue ( Functions.Mid ( PCINFO ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 1245;
                                        if ( Functions.TestForTrue  ( ( Functions.Find( "PC:LINE6TXT=" , PCINFO ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 1247;
                                            SPOS = (ushort) ( Functions.Find( "=" , PCINFO ) ) ; 
                                            __context__.SourceCodeLine = 1248;
                                            EPOS = (ushort) ( Functions.Length( PCINFO ) ) ; 
                                            __context__.SourceCodeLine = 1249;
                                            PCLINE6TEXT  .UpdateValue ( Functions.Mid ( PCINFO ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 1252;
                                            if ( Functions.TestForTrue  ( ( Functions.Find( "PC:LINE7TXT=" , PCINFO ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 1254;
                                                SPOS = (ushort) ( Functions.Find( "=" , PCINFO ) ) ; 
                                                __context__.SourceCodeLine = 1255;
                                                EPOS = (ushort) ( Functions.Length( PCINFO ) ) ; 
                                                __context__.SourceCodeLine = 1256;
                                                PCLINE7TEXT  .UpdateValue ( Functions.Mid ( PCINFO ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 1259;
                                                if ( Functions.TestForTrue  ( ( Functions.Find( "PC:LINE8TXT=" , PCINFO ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 1261;
                                                    SPOS = (ushort) ( Functions.Find( "=" , PCINFO ) ) ; 
                                                    __context__.SourceCodeLine = 1262;
                                                    EPOS = (ushort) ( Functions.Length( PCINFO ) ) ; 
                                                    __context__.SourceCodeLine = 1263;
                                                    PCLINE8TEXT  .UpdateValue ( Functions.Mid ( PCINFO ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 1266;
                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "PC:SONG=" , PCINFO ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 1268;
                                                        SPOS = (ushort) ( Functions.Find( "=" , PCINFO ) ) ; 
                                                        __context__.SourceCodeLine = 1269;
                                                        EPOS = (ushort) ( Functions.Length( PCINFO ) ) ; 
                                                        __context__.SourceCodeLine = 1270;
                                                        PCCURRSONGTEXT  .UpdateValue ( Functions.Mid ( PCINFO ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 1273;
                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "PC:ARTIST=" , PCINFO ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 1275;
                                                            SPOS = (ushort) ( Functions.Find( "=" , PCINFO ) ) ; 
                                                            __context__.SourceCodeLine = 1276;
                                                            EPOS = (ushort) ( Functions.Length( PCINFO ) ) ; 
                                                            __context__.SourceCodeLine = 1277;
                                                            PCCURRARTISTTEXT  .UpdateValue ( Functions.Mid ( PCINFO ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 1280;
                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "PC:ALBUM=" , PCINFO ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 1282;
                                                                SPOS = (ushort) ( Functions.Find( "=" , PCINFO ) ) ; 
                                                                __context__.SourceCodeLine = 1283;
                                                                EPOS = (ushort) ( Functions.Length( PCINFO ) ) ; 
                                                                __context__.SourceCodeLine = 1284;
                                                                PCCURRALBUMTEXT  .UpdateValue ( Functions.Mid ( PCINFO ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                } 
                                                            
                                                            }
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            
            }
            
        private void FN_PARSENETRADIO (  SplusExecutionContext __context__, CrestronString NETRADIODATA ) 
            { 
            ushort SPOS = 0;
            
            ushort EPOS = 0;
            
            
            __context__.SourceCodeLine = 1297;
            if ( Functions.TestForTrue  ( ( Functions.Find( "NETRADIO:LISTLAYER=" , NETRADIODATA ))  ) ) 
                { 
                __context__.SourceCodeLine = 1299;
                SPOS = (ushort) ( Functions.Find( "=" , NETRADIODATA ) ) ; 
                __context__.SourceCodeLine = 1300;
                EPOS = (ushort) ( Functions.Length( NETRADIODATA ) ) ; 
                __context__.SourceCodeLine = 1301;
                NETRADIOLISTLAYER  .UpdateValue ( Functions.Mid ( NETRADIODATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 1304;
                if ( Functions.TestForTrue  ( ( Functions.Find( "NETRADIO:LISTLAYERNAME=" , NETRADIODATA ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1306;
                    SPOS = (ushort) ( Functions.Find( "=" , NETRADIODATA ) ) ; 
                    __context__.SourceCodeLine = 1307;
                    EPOS = (ushort) ( Functions.Length( NETRADIODATA ) ) ; 
                    __context__.SourceCodeLine = 1308;
                    NETRADIOLISTNAME  .UpdateValue ( Functions.Mid ( NETRADIODATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 1311;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "NETRADIO:LINE1TXT=" , NETRADIODATA ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1313;
                        SPOS = (ushort) ( Functions.Find( "=" , NETRADIODATA ) ) ; 
                        __context__.SourceCodeLine = 1314;
                        EPOS = (ushort) ( Functions.Length( NETRADIODATA ) ) ; 
                        __context__.SourceCodeLine = 1315;
                        NETRADIOLINE1TEXT  .UpdateValue ( Functions.Mid ( NETRADIODATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1318;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "NETRADIO:LINE2TXT=" , NETRADIODATA ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1320;
                            SPOS = (ushort) ( Functions.Find( "=" , NETRADIODATA ) ) ; 
                            __context__.SourceCodeLine = 1321;
                            EPOS = (ushort) ( Functions.Length( NETRADIODATA ) ) ; 
                            __context__.SourceCodeLine = 1322;
                            NETRADIOLINE2TEXT  .UpdateValue ( Functions.Mid ( NETRADIODATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 1325;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "NETRADIO:LINE3TXT=" , NETRADIODATA ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1327;
                                SPOS = (ushort) ( Functions.Find( "=" , NETRADIODATA ) ) ; 
                                __context__.SourceCodeLine = 1328;
                                EPOS = (ushort) ( Functions.Length( NETRADIODATA ) ) ; 
                                __context__.SourceCodeLine = 1329;
                                NETRADIOLINE3TEXT  .UpdateValue ( Functions.Mid ( NETRADIODATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 1332;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "NETRADIO:LINE4TXT=" , NETRADIODATA ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 1334;
                                    SPOS = (ushort) ( Functions.Find( "=" , NETRADIODATA ) ) ; 
                                    __context__.SourceCodeLine = 1335;
                                    EPOS = (ushort) ( Functions.Length( NETRADIODATA ) ) ; 
                                    __context__.SourceCodeLine = 1336;
                                    NETRADIOLINE4TEXT  .UpdateValue ( Functions.Mid ( NETRADIODATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 1339;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "NETRADIO:LINE5TXT=" , NETRADIODATA ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 1341;
                                        SPOS = (ushort) ( Functions.Find( "=" , NETRADIODATA ) ) ; 
                                        __context__.SourceCodeLine = 1342;
                                        EPOS = (ushort) ( Functions.Length( NETRADIODATA ) ) ; 
                                        __context__.SourceCodeLine = 1343;
                                        NETRADIOLINE5TEXT  .UpdateValue ( Functions.Mid ( NETRADIODATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 1346;
                                        if ( Functions.TestForTrue  ( ( Functions.Find( "NETRADIO:LINE6TXT=" , NETRADIODATA ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 1348;
                                            SPOS = (ushort) ( Functions.Find( "=" , NETRADIODATA ) ) ; 
                                            __context__.SourceCodeLine = 1349;
                                            EPOS = (ushort) ( Functions.Length( NETRADIODATA ) ) ; 
                                            __context__.SourceCodeLine = 1350;
                                            NETRADIOLINE6TEXT  .UpdateValue ( Functions.Mid ( NETRADIODATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 1353;
                                            if ( Functions.TestForTrue  ( ( Functions.Find( "NETRADIO:LINE7TXT=" , NETRADIODATA ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 1355;
                                                SPOS = (ushort) ( Functions.Find( "=" , NETRADIODATA ) ) ; 
                                                __context__.SourceCodeLine = 1356;
                                                EPOS = (ushort) ( Functions.Length( NETRADIODATA ) ) ; 
                                                __context__.SourceCodeLine = 1357;
                                                NETRADIOLINE7TEXT  .UpdateValue ( Functions.Mid ( NETRADIODATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 1360;
                                                if ( Functions.TestForTrue  ( ( Functions.Find( "NETRADIO:LINE8TXT=" , NETRADIODATA ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 1362;
                                                    SPOS = (ushort) ( Functions.Find( "=" , NETRADIODATA ) ) ; 
                                                    __context__.SourceCodeLine = 1363;
                                                    EPOS = (ushort) ( Functions.Length( NETRADIODATA ) ) ; 
                                                    __context__.SourceCodeLine = 1364;
                                                    NETRADIOLINE8TEXT  .UpdateValue ( Functions.Mid ( NETRADIODATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 1367;
                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "NETRADIO:SONG=" , NETRADIODATA ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 1369;
                                                        SPOS = (ushort) ( Functions.Find( "=" , NETRADIODATA ) ) ; 
                                                        __context__.SourceCodeLine = 1370;
                                                        EPOS = (ushort) ( Functions.Length( NETRADIODATA ) ) ; 
                                                        __context__.SourceCodeLine = 1371;
                                                        NETRADIOCURRSONGTEXT  .UpdateValue ( Functions.Mid ( NETRADIODATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 1374;
                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "NETRADIO:ARTIST=" , NETRADIODATA ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 1376;
                                                            SPOS = (ushort) ( Functions.Find( "=" , NETRADIODATA ) ) ; 
                                                            __context__.SourceCodeLine = 1377;
                                                            EPOS = (ushort) ( Functions.Length( NETRADIODATA ) ) ; 
                                                            __context__.SourceCodeLine = 1378;
                                                            NETRADIOCURRARTISTTEXT  .UpdateValue ( Functions.Mid ( NETRADIODATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 1381;
                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "NETRADIO:ALBUM=" , NETRADIODATA ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 1383;
                                                                SPOS = (ushort) ( Functions.Find( "=" , NETRADIODATA ) ) ; 
                                                                __context__.SourceCodeLine = 1384;
                                                                EPOS = (ushort) ( Functions.Length( NETRADIODATA ) ) ; 
                                                                __context__.SourceCodeLine = 1385;
                                                                NETRADIOCURRALBUMTEXT  .UpdateValue ( Functions.Mid ( NETRADIODATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                } 
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 1388;
                                                                if ( Functions.TestForTrue  ( ( Functions.Find( "NETRADIO:STATION=" , NETRADIODATA ))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 1390;
                                                                    SPOS = (ushort) ( Functions.Find( "=" , NETRADIODATA ) ) ; 
                                                                    __context__.SourceCodeLine = 1391;
                                                                    EPOS = (ushort) ( Functions.Length( NETRADIODATA ) ) ; 
                                                                    __context__.SourceCodeLine = 1392;
                                                                    NETRADIOCURRCHANNELTEXT  .UpdateValue ( Functions.Mid ( NETRADIODATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                    } 
                                                                
                                                                }
                                                            
                                                            }
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            
            }
            
        private void FN_PARSEUSB (  SplusExecutionContext __context__, CrestronString USBDATA ) 
            { 
            ushort SPOS = 0;
            
            ushort EPOS = 0;
            
            
            __context__.SourceCodeLine = 1403;
            if ( Functions.TestForTrue  ( ( Functions.Find( "USB:LISTLAYER=" , USBDATA ))  ) ) 
                { 
                __context__.SourceCodeLine = 1405;
                SPOS = (ushort) ( Functions.Find( "=" , USBDATA ) ) ; 
                __context__.SourceCodeLine = 1406;
                EPOS = (ushort) ( Functions.Length( USBDATA ) ) ; 
                __context__.SourceCodeLine = 1407;
                USBLISTLAYER  .UpdateValue ( Functions.Mid ( USBDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 1410;
                if ( Functions.TestForTrue  ( ( Functions.Find( "USB:LISTLAYERNAME=" , USBDATA ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1412;
                    SPOS = (ushort) ( Functions.Find( "=" , USBDATA ) ) ; 
                    __context__.SourceCodeLine = 1413;
                    EPOS = (ushort) ( Functions.Length( USBDATA ) ) ; 
                    __context__.SourceCodeLine = 1414;
                    USBLISTNAME  .UpdateValue ( Functions.Mid ( USBDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 1417;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "USB:LINE1TXT=" , USBDATA ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1419;
                        SPOS = (ushort) ( Functions.Find( "=" , USBDATA ) ) ; 
                        __context__.SourceCodeLine = 1420;
                        EPOS = (ushort) ( Functions.Length( USBDATA ) ) ; 
                        __context__.SourceCodeLine = 1421;
                        USBLINE1TEXT  .UpdateValue ( Functions.Mid ( USBDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1424;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "USB:LINE2TXT=" , USBDATA ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1426;
                            SPOS = (ushort) ( Functions.Find( "=" , USBDATA ) ) ; 
                            __context__.SourceCodeLine = 1427;
                            EPOS = (ushort) ( Functions.Length( USBDATA ) ) ; 
                            __context__.SourceCodeLine = 1428;
                            USBLINE2TEXT  .UpdateValue ( Functions.Mid ( USBDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 1431;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "USB:LINE3TXT=" , USBDATA ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1433;
                                SPOS = (ushort) ( Functions.Find( "=" , USBDATA ) ) ; 
                                __context__.SourceCodeLine = 1434;
                                EPOS = (ushort) ( Functions.Length( USBDATA ) ) ; 
                                __context__.SourceCodeLine = 1435;
                                USBLINE3TEXT  .UpdateValue ( Functions.Mid ( USBDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 1438;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "USB:LINE4TXT=" , USBDATA ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 1440;
                                    SPOS = (ushort) ( Functions.Find( "=" , USBDATA ) ) ; 
                                    __context__.SourceCodeLine = 1441;
                                    EPOS = (ushort) ( Functions.Length( USBDATA ) ) ; 
                                    __context__.SourceCodeLine = 1442;
                                    USBLINE4TEXT  .UpdateValue ( Functions.Mid ( USBDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 1445;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "USB:LINE5TXT=" , USBDATA ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 1447;
                                        SPOS = (ushort) ( Functions.Find( "=" , USBDATA ) ) ; 
                                        __context__.SourceCodeLine = 1448;
                                        EPOS = (ushort) ( Functions.Length( USBDATA ) ) ; 
                                        __context__.SourceCodeLine = 1449;
                                        USBLINE5TEXT  .UpdateValue ( Functions.Mid ( USBDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 1452;
                                        if ( Functions.TestForTrue  ( ( Functions.Find( "USB:LINE6TXT=" , USBDATA ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 1454;
                                            SPOS = (ushort) ( Functions.Find( "=" , USBDATA ) ) ; 
                                            __context__.SourceCodeLine = 1455;
                                            EPOS = (ushort) ( Functions.Length( USBDATA ) ) ; 
                                            __context__.SourceCodeLine = 1456;
                                            USBLINE6TEXT  .UpdateValue ( Functions.Mid ( USBDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 1459;
                                            if ( Functions.TestForTrue  ( ( Functions.Find( "USB:LINE7TXT=" , USBDATA ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 1461;
                                                SPOS = (ushort) ( Functions.Find( "=" , USBDATA ) ) ; 
                                                __context__.SourceCodeLine = 1462;
                                                EPOS = (ushort) ( Functions.Length( USBDATA ) ) ; 
                                                __context__.SourceCodeLine = 1463;
                                                USBLINE7TEXT  .UpdateValue ( Functions.Mid ( USBDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 1466;
                                                if ( Functions.TestForTrue  ( ( Functions.Find( "USB:LINE8TXT=" , USBDATA ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 1468;
                                                    SPOS = (ushort) ( Functions.Find( "=" , USBDATA ) ) ; 
                                                    __context__.SourceCodeLine = 1469;
                                                    EPOS = (ushort) ( Functions.Length( USBDATA ) ) ; 
                                                    __context__.SourceCodeLine = 1470;
                                                    USBLINE8TEXT  .UpdateValue ( Functions.Mid ( USBDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 1473;
                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "USB:SONG=" , USBDATA ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 1475;
                                                        SPOS = (ushort) ( Functions.Find( "=" , USBDATA ) ) ; 
                                                        __context__.SourceCodeLine = 1476;
                                                        EPOS = (ushort) ( Functions.Length( USBDATA ) ) ; 
                                                        __context__.SourceCodeLine = 1477;
                                                        USBCURRSONGTEXT  .UpdateValue ( Functions.Mid ( USBDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 1480;
                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "USB:ARTIST=" , USBDATA ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 1482;
                                                            SPOS = (ushort) ( Functions.Find( "=" , USBDATA ) ) ; 
                                                            __context__.SourceCodeLine = 1483;
                                                            EPOS = (ushort) ( Functions.Length( USBDATA ) ) ; 
                                                            __context__.SourceCodeLine = 1484;
                                                            USBCURRARTISTTEXT  .UpdateValue ( Functions.Mid ( USBDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 1487;
                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "USB:ALBUM=" , USBDATA ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 1489;
                                                                SPOS = (ushort) ( Functions.Find( "=" , USBDATA ) ) ; 
                                                                __context__.SourceCodeLine = 1490;
                                                                EPOS = (ushort) ( Functions.Length( USBDATA ) ) ; 
                                                                __context__.SourceCodeLine = 1491;
                                                                USBCURRALBUMTEXT  .UpdateValue ( Functions.Mid ( USBDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                } 
                                                            
                                                            }
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            
            }
            
        private void FN_PARSEPANDORA (  SplusExecutionContext __context__, CrestronString PANDORADATA ) 
            { 
            ushort SPOS = 0;
            
            ushort EPOS = 0;
            
            
            __context__.SourceCodeLine = 1504;
            if ( Functions.TestForTrue  ( ( Functions.Find( "PANDORA:LISTLAYER=" , PANDORADATA ))  ) ) 
                { 
                __context__.SourceCodeLine = 1506;
                SPOS = (ushort) ( Functions.Find( "=" , PANDORADATA ) ) ; 
                __context__.SourceCodeLine = 1507;
                EPOS = (ushort) ( Functions.Length( PANDORADATA ) ) ; 
                __context__.SourceCodeLine = 1508;
                PANDLISTLAYER  .UpdateValue ( Functions.Mid ( PANDORADATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 1511;
                if ( Functions.TestForTrue  ( ( Functions.Find( "PANDORA:LISTLAYERNAME=" , PANDORADATA ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1513;
                    SPOS = (ushort) ( Functions.Find( "=" , PANDORADATA ) ) ; 
                    __context__.SourceCodeLine = 1514;
                    EPOS = (ushort) ( Functions.Length( PANDORADATA ) ) ; 
                    __context__.SourceCodeLine = 1515;
                    PANDLISTNAME  .UpdateValue ( Functions.Mid ( PANDORADATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 1518;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "PANDORA:LINE1TXT=" , PANDORADATA ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1520;
                        SPOS = (ushort) ( Functions.Find( "=" , PANDORADATA ) ) ; 
                        __context__.SourceCodeLine = 1521;
                        EPOS = (ushort) ( Functions.Length( PANDORADATA ) ) ; 
                        __context__.SourceCodeLine = 1522;
                        PANDLINE1TEXT  .UpdateValue ( Functions.Mid ( PANDORADATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1525;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "PANDORA:LINE2TXT=" , PANDORADATA ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1527;
                            SPOS = (ushort) ( Functions.Find( "=" , PANDORADATA ) ) ; 
                            __context__.SourceCodeLine = 1528;
                            EPOS = (ushort) ( Functions.Length( PANDORADATA ) ) ; 
                            __context__.SourceCodeLine = 1529;
                            PANDLINE2TEXT  .UpdateValue ( Functions.Mid ( PANDORADATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 1532;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "PANDORA:LINE3TXT=" , PANDORADATA ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1534;
                                SPOS = (ushort) ( Functions.Find( "=" , PANDORADATA ) ) ; 
                                __context__.SourceCodeLine = 1535;
                                EPOS = (ushort) ( Functions.Length( PANDORADATA ) ) ; 
                                __context__.SourceCodeLine = 1536;
                                PANDLINE3TEXT  .UpdateValue ( Functions.Mid ( PANDORADATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 1539;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "PANDORA:LINE4TXT=" , PANDORADATA ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 1541;
                                    SPOS = (ushort) ( Functions.Find( "=" , PANDORADATA ) ) ; 
                                    __context__.SourceCodeLine = 1542;
                                    EPOS = (ushort) ( Functions.Length( PANDORADATA ) ) ; 
                                    __context__.SourceCodeLine = 1543;
                                    PANDLINE4TEXT  .UpdateValue ( Functions.Mid ( PANDORADATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 1546;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "PANDORA:LINE5TXT=" , PANDORADATA ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 1548;
                                        SPOS = (ushort) ( Functions.Find( "=" , PANDORADATA ) ) ; 
                                        __context__.SourceCodeLine = 1549;
                                        EPOS = (ushort) ( Functions.Length( PANDORADATA ) ) ; 
                                        __context__.SourceCodeLine = 1550;
                                        PANDLINE5TEXT  .UpdateValue ( Functions.Mid ( PANDORADATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 1553;
                                        if ( Functions.TestForTrue  ( ( Functions.Find( "PANDORA:LINE6TXT=" , PANDORADATA ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 1555;
                                            SPOS = (ushort) ( Functions.Find( "=" , PANDORADATA ) ) ; 
                                            __context__.SourceCodeLine = 1556;
                                            EPOS = (ushort) ( Functions.Length( PANDORADATA ) ) ; 
                                            __context__.SourceCodeLine = 1557;
                                            PANDLINE6TEXT  .UpdateValue ( Functions.Mid ( PANDORADATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 1560;
                                            if ( Functions.TestForTrue  ( ( Functions.Find( "PANDORA:LINE7TXT=" , PANDORADATA ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 1562;
                                                SPOS = (ushort) ( Functions.Find( "=" , PANDORADATA ) ) ; 
                                                __context__.SourceCodeLine = 1563;
                                                EPOS = (ushort) ( Functions.Length( PANDORADATA ) ) ; 
                                                __context__.SourceCodeLine = 1564;
                                                PANDLINE7TEXT  .UpdateValue ( Functions.Mid ( PANDORADATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 1567;
                                                if ( Functions.TestForTrue  ( ( Functions.Find( "PANDORA:LINE8TXT=" , PANDORADATA ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 1569;
                                                    SPOS = (ushort) ( Functions.Find( "=" , PANDORADATA ) ) ; 
                                                    __context__.SourceCodeLine = 1570;
                                                    EPOS = (ushort) ( Functions.Length( PANDORADATA ) ) ; 
                                                    __context__.SourceCodeLine = 1571;
                                                    PANDLINE8TEXT  .UpdateValue ( Functions.Mid ( PANDORADATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 1574;
                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "PANDORA:SONG=" , PANDORADATA ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 1576;
                                                        SPOS = (ushort) ( Functions.Find( "=" , PANDORADATA ) ) ; 
                                                        __context__.SourceCodeLine = 1577;
                                                        EPOS = (ushort) ( Functions.Length( PANDORADATA ) ) ; 
                                                        __context__.SourceCodeLine = 1578;
                                                        PANDCURRSONGTEXT  .UpdateValue ( Functions.Mid ( PANDORADATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 1581;
                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "PANDORA:ALBUM=" , PANDORADATA ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 1583;
                                                            SPOS = (ushort) ( Functions.Find( "=" , PANDORADATA ) ) ; 
                                                            __context__.SourceCodeLine = 1584;
                                                            EPOS = (ushort) ( Functions.Length( PANDORADATA ) ) ; 
                                                            __context__.SourceCodeLine = 1585;
                                                            PANDCURRALBUMTEXT  .UpdateValue ( Functions.Mid ( PANDORADATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 1588;
                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "PANDORA:STATION=" , PANDORADATA ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 1590;
                                                                SPOS = (ushort) ( Functions.Find( "=" , PANDORADATA ) ) ; 
                                                                __context__.SourceCodeLine = 1591;
                                                                EPOS = (ushort) ( Functions.Length( PANDORADATA ) ) ; 
                                                                __context__.SourceCodeLine = 1592;
                                                                PANDCURRSTATIONTEXT  .UpdateValue ( Functions.Mid ( PANDORADATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                } 
                                                            
                                                            }
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            
            }
            
        private void FN_PARSEIPOD (  SplusExecutionContext __context__, CrestronString IPODDATA ) 
            { 
            ushort SPOS = 0;
            
            ushort EPOS = 0;
            
            
            __context__.SourceCodeLine = 1604;
            if ( Functions.TestForTrue  ( ( Functions.Find( "IPOD:LISTLAYER=" , IPODDATA ))  ) ) 
                { 
                __context__.SourceCodeLine = 1606;
                SPOS = (ushort) ( Functions.Find( "=" , IPODDATA ) ) ; 
                __context__.SourceCodeLine = 1607;
                EPOS = (ushort) ( Functions.Length( IPODDATA ) ) ; 
                __context__.SourceCodeLine = 1608;
                IPODLISTLAYER  .UpdateValue ( Functions.Mid ( IPODDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 1611;
                if ( Functions.TestForTrue  ( ( Functions.Find( "IPOD:LISTLAYERNAME=" , IPODDATA ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1613;
                    SPOS = (ushort) ( Functions.Find( "=" , IPODDATA ) ) ; 
                    __context__.SourceCodeLine = 1614;
                    EPOS = (ushort) ( Functions.Length( IPODDATA ) ) ; 
                    __context__.SourceCodeLine = 1615;
                    IPODLISTNAME  .UpdateValue ( Functions.Mid ( IPODDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 1618;
                    if ( Functions.TestForTrue  ( ( Functions.Find( "IPOD:LINE1TXT=" , IPODDATA ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1620;
                        SPOS = (ushort) ( Functions.Find( "=" , IPODDATA ) ) ; 
                        __context__.SourceCodeLine = 1621;
                        EPOS = (ushort) ( Functions.Length( IPODDATA ) ) ; 
                        __context__.SourceCodeLine = 1622;
                        IPODLINE1TEXT  .UpdateValue ( Functions.Mid ( IPODDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1625;
                        if ( Functions.TestForTrue  ( ( Functions.Find( "IPOD:LINE2TXT=" , IPODDATA ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1627;
                            SPOS = (ushort) ( Functions.Find( "=" , IPODDATA ) ) ; 
                            __context__.SourceCodeLine = 1628;
                            EPOS = (ushort) ( Functions.Length( IPODDATA ) ) ; 
                            __context__.SourceCodeLine = 1629;
                            IPODLINE2TEXT  .UpdateValue ( Functions.Mid ( IPODDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 1632;
                            if ( Functions.TestForTrue  ( ( Functions.Find( "IPOD:LINE3TXT=" , IPODDATA ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 1634;
                                SPOS = (ushort) ( Functions.Find( "=" , IPODDATA ) ) ; 
                                __context__.SourceCodeLine = 1635;
                                EPOS = (ushort) ( Functions.Length( IPODDATA ) ) ; 
                                __context__.SourceCodeLine = 1636;
                                IPODLINE3TEXT  .UpdateValue ( Functions.Mid ( IPODDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 1639;
                                if ( Functions.TestForTrue  ( ( Functions.Find( "IPOD:LINE4TXT=" , IPODDATA ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 1641;
                                    SPOS = (ushort) ( Functions.Find( "=" , IPODDATA ) ) ; 
                                    __context__.SourceCodeLine = 1642;
                                    EPOS = (ushort) ( Functions.Length( IPODDATA ) ) ; 
                                    __context__.SourceCodeLine = 1643;
                                    IPODLINE4TEXT  .UpdateValue ( Functions.Mid ( IPODDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 1646;
                                    if ( Functions.TestForTrue  ( ( Functions.Find( "IPOD:LINE5TXT=" , IPODDATA ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 1648;
                                        SPOS = (ushort) ( Functions.Find( "=" , IPODDATA ) ) ; 
                                        __context__.SourceCodeLine = 1649;
                                        EPOS = (ushort) ( Functions.Length( IPODDATA ) ) ; 
                                        __context__.SourceCodeLine = 1650;
                                        IPODLINE5TEXT  .UpdateValue ( Functions.Mid ( IPODDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 1653;
                                        if ( Functions.TestForTrue  ( ( Functions.Find( "IPOD:LINE6TXT=" , IPODDATA ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 1655;
                                            SPOS = (ushort) ( Functions.Find( "=" , IPODDATA ) ) ; 
                                            __context__.SourceCodeLine = 1656;
                                            EPOS = (ushort) ( Functions.Length( IPODDATA ) ) ; 
                                            __context__.SourceCodeLine = 1657;
                                            IPODLINE6TEXT  .UpdateValue ( Functions.Mid ( IPODDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 1660;
                                            if ( Functions.TestForTrue  ( ( Functions.Find( "IPOD:LINE7TXT=" , IPODDATA ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 1662;
                                                SPOS = (ushort) ( Functions.Find( "=" , IPODDATA ) ) ; 
                                                __context__.SourceCodeLine = 1663;
                                                EPOS = (ushort) ( Functions.Length( IPODDATA ) ) ; 
                                                __context__.SourceCodeLine = 1664;
                                                IPODLINE7TEXT  .UpdateValue ( Functions.Mid ( IPODDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 1667;
                                                if ( Functions.TestForTrue  ( ( Functions.Find( "IPOD:LINE8TXT=" , IPODDATA ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 1669;
                                                    SPOS = (ushort) ( Functions.Find( "=" , IPODDATA ) ) ; 
                                                    __context__.SourceCodeLine = 1670;
                                                    EPOS = (ushort) ( Functions.Length( IPODDATA ) ) ; 
                                                    __context__.SourceCodeLine = 1671;
                                                    IPODLINE8TEXT  .UpdateValue ( Functions.Mid ( IPODDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 1674;
                                                    if ( Functions.TestForTrue  ( ( Functions.Find( "IPOD:SONG=" , IPODDATA ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 1676;
                                                        SPOS = (ushort) ( Functions.Find( "=" , IPODDATA ) ) ; 
                                                        __context__.SourceCodeLine = 1677;
                                                        EPOS = (ushort) ( Functions.Length( IPODDATA ) ) ; 
                                                        __context__.SourceCodeLine = 1678;
                                                        IPODCURRSONGTEXT  .UpdateValue ( Functions.Mid ( IPODDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 1681;
                                                        if ( Functions.TestForTrue  ( ( Functions.Find( "IPOD:ARTIST=" , IPODDATA ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 1683;
                                                            SPOS = (ushort) ( Functions.Find( "=" , IPODDATA ) ) ; 
                                                            __context__.SourceCodeLine = 1684;
                                                            EPOS = (ushort) ( Functions.Length( IPODDATA ) ) ; 
                                                            __context__.SourceCodeLine = 1685;
                                                            IPODCURRARTISTTEXT  .UpdateValue ( Functions.Mid ( IPODDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 1688;
                                                            if ( Functions.TestForTrue  ( ( Functions.Find( "IPOD:ALBUM=" , IPODDATA ))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 1690;
                                                                SPOS = (ushort) ( Functions.Find( "=" , IPODDATA ) ) ; 
                                                                __context__.SourceCodeLine = 1691;
                                                                EPOS = (ushort) ( Functions.Length( IPODDATA ) ) ; 
                                                                __context__.SourceCodeLine = 1692;
                                                                IPODCURRALBUMTEXT  .UpdateValue ( Functions.Mid ( IPODDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                                                                } 
                                                            
                                                            }
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            
            }
            
        private void FN_PARSESIRIUS (  SplusExecutionContext __context__, CrestronString SIRIUSDATA ) 
            { 
            ushort SPOS = 0;
            
            ushort EPOS = 0;
            
            
            __context__.SourceCodeLine = 1704;
            if ( Functions.TestForTrue  ( ( Functions.Find( "SIRIUS:ANTLVL=" , SIRIUSDATA ))  ) ) 
                { 
                __context__.SourceCodeLine = 1706;
                SPOS = (ushort) ( Functions.Find( "=" , SIRIUSDATA ) ) ; 
                __context__.SourceCodeLine = 1707;
                EPOS = (ushort) ( Functions.Length( SIRIUSDATA ) ) ; 
                __context__.SourceCodeLine = 1708;
                SIRIUSANTLEVEL  .UpdateValue ( Functions.Mid ( SIRIUSDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                } 
            
            __context__.SourceCodeLine = 1710;
            if ( Functions.TestForTrue  ( ( Functions.Find( "SIRIUS:CATNAME=" , SIRIUSDATA ))  ) ) 
                { 
                __context__.SourceCodeLine = 1712;
                SPOS = (ushort) ( Functions.Find( "=" , SIRIUSDATA ) ) ; 
                __context__.SourceCodeLine = 1713;
                EPOS = (ushort) ( Functions.Length( SIRIUSDATA ) ) ; 
                __context__.SourceCodeLine = 1714;
                SIRIUSCURRCATTEXT  .UpdateValue ( Functions.Mid ( SIRIUSDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                } 
            
            __context__.SourceCodeLine = 1716;
            if ( Functions.TestForTrue  ( ( Functions.Find( "SIRIUS:CHNUM=" , SIRIUSDATA ))  ) ) 
                { 
                __context__.SourceCodeLine = 1718;
                SPOS = (ushort) ( Functions.Find( "=" , SIRIUSDATA ) ) ; 
                __context__.SourceCodeLine = 1719;
                EPOS = (ushort) ( Functions.Length( SIRIUSDATA ) ) ; 
                __context__.SourceCodeLine = 1720;
                SIRIUSCURRCHANNUMTEXT  .UpdateValue ( Functions.Mid ( SIRIUSDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                } 
            
            __context__.SourceCodeLine = 1722;
            if ( Functions.TestForTrue  ( ( Functions.Find( "SIRIUS:CHNAME=" , SIRIUSDATA ))  ) ) 
                { 
                __context__.SourceCodeLine = 1724;
                SPOS = (ushort) ( Functions.Find( "=" , SIRIUSDATA ) ) ; 
                __context__.SourceCodeLine = 1725;
                EPOS = (ushort) ( Functions.Length( SIRIUSDATA ) ) ; 
                __context__.SourceCodeLine = 1726;
                SIRIUSCURRCHANNAMETEXT  .UpdateValue ( Functions.Mid ( SIRIUSDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                } 
            
            __context__.SourceCodeLine = 1728;
            if ( Functions.TestForTrue  ( ( Functions.Find( "SIRIUS:ARTIST=" , SIRIUSDATA ))  ) ) 
                { 
                __context__.SourceCodeLine = 1730;
                SPOS = (ushort) ( Functions.Find( "=" , SIRIUSDATA ) ) ; 
                __context__.SourceCodeLine = 1731;
                EPOS = (ushort) ( Functions.Length( SIRIUSDATA ) ) ; 
                __context__.SourceCodeLine = 1732;
                SIRIUSCURRARTISTTEXT  .UpdateValue ( Functions.Mid ( SIRIUSDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                } 
            
            __context__.SourceCodeLine = 1734;
            if ( Functions.TestForTrue  ( ( Functions.Find( "SIRIUS:SONG=" , SIRIUSDATA ))  ) ) 
                { 
                __context__.SourceCodeLine = 1736;
                SPOS = (ushort) ( Functions.Find( "=" , SIRIUSDATA ) ) ; 
                __context__.SourceCodeLine = 1737;
                EPOS = (ushort) ( Functions.Length( SIRIUSDATA ) ) ; 
                __context__.SourceCodeLine = 1738;
                SIRIUSCURRSONGTEXT  .UpdateValue ( Functions.Mid ( SIRIUSDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                } 
            
            __context__.SourceCodeLine = 1740;
            if ( Functions.TestForTrue  ( ( Functions.Find( "SIRIUS:COMPOSER=" , SIRIUSDATA ))  ) ) 
                { 
                __context__.SourceCodeLine = 1742;
                SPOS = (ushort) ( Functions.Find( "=" , SIRIUSDATA ) ) ; 
                __context__.SourceCodeLine = 1743;
                EPOS = (ushort) ( Functions.Length( SIRIUSDATA ) ) ; 
                __context__.SourceCodeLine = 1744;
                SIRIUSCURRCOMPTEXT  .UpdateValue ( Functions.Mid ( SIRIUSDATA ,  (int) ( (SPOS + 1) ) ,  (int) ( EPOS ) )  ) ; 
                } 
            
            
            }
            
        private void FNPROCESSDATA (  SplusExecutionContext __context__, CrestronString SDATA ) 
            { 
            CrestronString STEMP;
            STEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 600, this );
            
            CrestronString STRASH;
            STRASH  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
            
            
            __context__.SourceCodeLine = 1756;
            while ( Functions.TestForTrue  ( ( Functions.Find( "\u000D\u000A" , SDATA ))  ) ) 
                { 
                __context__.SourceCodeLine = 1758;
                STEMP  .UpdateValue ( FN_PARSEDELIMITEDTEXT (  __context__ , SDATA, "@", "\u000D\u000A", (ushort)( 0 ))  ) ; 
                __context__.SourceCodeLine = 1759;
                STRASH  .UpdateValue ( Functions.Remove ( "\u000D\u000A" , SDATA )  ) ; 
                __context__.SourceCodeLine = 1761;
                RXPROCESSED  .UpdateValue ( STEMP  ) ; 
                __context__.SourceCodeLine = 1763;
                
                    {
                    int __SPLS_TMPVAR__SWTCH_1__ = ((int)1);
                    
                        { 
                        if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.BoolToInt ( Functions.Find( "MAIN" , STEMP ) > 0 )) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 1767;
                            FN_PARSEMAIN (  __context__ , STEMP) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.BoolToInt ( Functions.Find( "Zone2" , STEMP ) > 0 )) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 1772;
                            FN_PARSEZONE2 (  __context__ , STEMP) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.BoolToInt ( Functions.Find( "Zone3" , STEMP ) > 0 )) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 1777;
                            FN_PARSEZONE3 (  __context__ , STEMP) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.BoolToInt ( Functions.Find( "Zone4" , STEMP ) > 0 )) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 1782;
                            FN_PARSEZONE4 (  __context__ , STEMP) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.BoolToInt ( Functions.Find( "HDRADIO" , STEMP ) > 0 )) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 1787;
                            FN_PARSETUNER (  __context__ , STEMP) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.BoolToInt ( Functions.Find( "SIRIUS" , STEMP ) > 0 )) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 1792;
                            FN_PARSESIRIUS (  __context__ , STEMP) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.BoolToInt ( Functions.Find( "PANDORA" , STEMP ) > 0 )) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 1797;
                            Functions.Delay (  (int) ( 1 ) ) ; 
                            __context__.SourceCodeLine = 1798;
                            FN_PARSEPANDORA (  __context__ , STEMP) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.BoolToInt ( Functions.Find( "NAPSTER" , STEMP ) > 0 )) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 1803;
                            FN_PARSENAPSTER (  __context__ , STEMP) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.BoolToInt ( Functions.Find( "SIRIUSIR" , STEMP ) > 0 )) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 1808;
                            FN_PARSESIRIUSIR (  __context__ , STEMP) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.BoolToInt ( Functions.Find( "RHAP" , STEMP ) > 0 )) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 1813;
                            FN_PARSERHAP (  __context__ , STEMP) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.BoolToInt ( Functions.Find( "PC" , STEMP ) > 0 )) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 1817;
                            FN_PARSEPC (  __context__ , STEMP) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.BoolToInt ( Functions.Find( "USB" , STEMP ) > 0 )) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 1822;
                            FN_PARSEUSB (  __context__ , STEMP) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.BoolToInt ( Functions.Find( "NETRADIO" , STEMP ) > 0 )) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 1827;
                            FN_PARSENETRADIO (  __context__ , STEMP) ; 
                            } 
                        
                        else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( Functions.BoolToInt ( Functions.Find( "IPOD" , STEMP ) > 0 )) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 1832;
                            FN_PARSEIPOD (  __context__ , STEMP) ; 
                            } 
                        
                        } 
                        
                    }
                    
                
                __context__.SourceCodeLine = 1756;
                } 
            
            __context__.SourceCodeLine = 1837;
            /* Trace( "Parsing OFF\r\n") */ ; 
            __context__.SourceCodeLine = 1838;
            G_BPARSING = (ushort) ( 0 ) ; 
            
            }
            
        object CMDIN_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 1852;
                CMDTOSEND  .UpdateValue ( CMDIN  ) ; 
                __context__.SourceCodeLine = 1854;
                RS232_TO_DEV  .UpdateValue ( CMDTOSEND  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object TUNERDIRVAL_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 1859;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TUNERISFM  .Value == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 1861;
                MakeString ( CMDTOSEND , "@HDRADIO:FMFREQ={0:d}\r\n", (short)TUNERDIRVAL  .UshortValue) ; 
                __context__.SourceCodeLine = 1863;
                RS232_TO_DEV  .UpdateValue ( CMDTOSEND  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 1869;
                MakeString ( CMDTOSEND , "@HDRADIO:AMFREQ={0:d}\r\n", (short)TUNERDIRVAL  .UshortValue) ; 
                __context__.SourceCodeLine = 1871;
                RS232_TO_DEV  .UpdateValue ( CMDTOSEND  ) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object SIRIUSDIRVAL_OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1877;
        MakeString ( CMDTOSEND , "@SIRIUS:CHSEL={0:d}\r\n", (short)SIRIUSDIRVAL  .UshortValue) ; 
        __context__.SourceCodeLine = 1879;
        RS232_TO_DEV  .UpdateValue ( CMDTOSEND  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PANDORA_MEM_SAVE_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1885;
        MakeString ( CMDTOSEND , "@PANDORA:MEM={0:d}\r\n", (short)PANDORA_MEM_LOC_VAL  .UshortValue) ; 
        __context__.SourceCodeLine = 1887;
        RS232_TO_DEV  .UpdateValue ( CMDTOSEND  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NAPSTER_MEM_SAVE_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1893;
        MakeString ( CMDTOSEND , "@NAPSTER:MEM={0:d}\r\n", (short)NAPSTER_MEM_LOC_VAL  .UshortValue) ; 
        __context__.SourceCodeLine = 1895;
        RS232_TO_DEV  .UpdateValue ( CMDTOSEND  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SIRIUSIR_MEM_SAVE_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1900;
        MakeString ( CMDTOSEND , "@SIRIUSIR:MEM={0:d}\r\n", (short)SIRIUSIR_MEM_LOC_VAL  .UshortValue) ; 
        __context__.SourceCodeLine = 1902;
        RS232_TO_DEV  .UpdateValue ( CMDTOSEND  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RHAP_MEM_SAVE_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1907;
        MakeString ( CMDTOSEND , "@RHAP:MEM={0:d}\r\n", (short)RHAP_MEM_LOC_VAL  .UshortValue) ; 
        __context__.SourceCodeLine = 1909;
        RS232_TO_DEV  .UpdateValue ( CMDTOSEND  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PC_MEM_SAVE_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1914;
        MakeString ( CMDTOSEND , "@PC:MEM={0:d}\r\n", (short)PC_MEM_LOC_VAL  .UshortValue) ; 
        __context__.SourceCodeLine = 1916;
        RS232_TO_DEV  .UpdateValue ( CMDTOSEND  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NETRADIO_MEM_SAVE_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1922;
        MakeString ( CMDTOSEND , "@NETRADIO:MEM={0:d}\r\n", (short)NETRADIO_MEM_LOC_VAL  .UshortValue) ; 
        __context__.SourceCodeLine = 1924;
        RS232_TO_DEV  .UpdateValue ( CMDTOSEND  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object USB_MEM_SAVE_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1929;
        MakeString ( CMDTOSEND , "@USB:MEM={0:d}\r\n", (short)USB_MEM_LOC_VAL  .UshortValue) ; 
        __context__.SourceCodeLine = 1931;
        RS232_TO_DEV  .UpdateValue ( CMDTOSEND  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SIRIUS_MEM_SAVE_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1936;
        MakeString ( CMDTOSEND , "@SIRIUS:MEM={0:d}\r\n", (short)SIRIUS_MEM_LOC_VAL  .UshortValue) ; 
        __context__.SourceCodeLine = 1938;
        RS232_TO_DEV  .UpdateValue ( CMDTOSEND  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PROCESS_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1945;
        while ( Functions.TestForTrue  ( ( Functions.Find( "\u000D\u000A" , RS232FROMDEV ))  ) ) 
            { 
            __context__.SourceCodeLine = 1947;
            FNPROCESSDATA (  __context__ , Functions.Remove( "\u000D\u000A" , RS232FROMDEV )) ; 
            __context__.SourceCodeLine = 1945;
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}


public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    CMDTOSEND  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
    
    PROCESS = new Crestron.Logos.SplusObjects.DigitalInput( PROCESS__DigitalInput__, this );
    m_DigitalInputList.Add( PROCESS__DigitalInput__, PROCESS );
    
    TUNERISFM = new Crestron.Logos.SplusObjects.DigitalInput( TUNERISFM__DigitalInput__, this );
    m_DigitalInputList.Add( TUNERISFM__DigitalInput__, TUNERISFM );
    
    PANDORA_MEM_SAVE = new Crestron.Logos.SplusObjects.DigitalInput( PANDORA_MEM_SAVE__DigitalInput__, this );
    m_DigitalInputList.Add( PANDORA_MEM_SAVE__DigitalInput__, PANDORA_MEM_SAVE );
    
    NAPSTER_MEM_SAVE = new Crestron.Logos.SplusObjects.DigitalInput( NAPSTER_MEM_SAVE__DigitalInput__, this );
    m_DigitalInputList.Add( NAPSTER_MEM_SAVE__DigitalInput__, NAPSTER_MEM_SAVE );
    
    SIRIUSIR_MEM_SAVE = new Crestron.Logos.SplusObjects.DigitalInput( SIRIUSIR_MEM_SAVE__DigitalInput__, this );
    m_DigitalInputList.Add( SIRIUSIR_MEM_SAVE__DigitalInput__, SIRIUSIR_MEM_SAVE );
    
    RHAP_MEM_SAVE = new Crestron.Logos.SplusObjects.DigitalInput( RHAP_MEM_SAVE__DigitalInput__, this );
    m_DigitalInputList.Add( RHAP_MEM_SAVE__DigitalInput__, RHAP_MEM_SAVE );
    
    PC_MEM_SAVE = new Crestron.Logos.SplusObjects.DigitalInput( PC_MEM_SAVE__DigitalInput__, this );
    m_DigitalInputList.Add( PC_MEM_SAVE__DigitalInput__, PC_MEM_SAVE );
    
    NETRADIO_MEM_SAVE = new Crestron.Logos.SplusObjects.DigitalInput( NETRADIO_MEM_SAVE__DigitalInput__, this );
    m_DigitalInputList.Add( NETRADIO_MEM_SAVE__DigitalInput__, NETRADIO_MEM_SAVE );
    
    USB_MEM_SAVE = new Crestron.Logos.SplusObjects.DigitalInput( USB_MEM_SAVE__DigitalInput__, this );
    m_DigitalInputList.Add( USB_MEM_SAVE__DigitalInput__, USB_MEM_SAVE );
    
    SIRIUS_MEM_SAVE = new Crestron.Logos.SplusObjects.DigitalInput( SIRIUS_MEM_SAVE__DigitalInput__, this );
    m_DigitalInputList.Add( SIRIUS_MEM_SAVE__DigitalInput__, SIRIUS_MEM_SAVE );
    
    TUNER_PROGRAM1_AVAIL = new Crestron.Logos.SplusObjects.DigitalOutput( TUNER_PROGRAM1_AVAIL__DigitalOutput__, this );
    m_DigitalOutputList.Add( TUNER_PROGRAM1_AVAIL__DigitalOutput__, TUNER_PROGRAM1_AVAIL );
    
    TUNER_PROGRAM2_AVAIL = new Crestron.Logos.SplusObjects.DigitalOutput( TUNER_PROGRAM2_AVAIL__DigitalOutput__, this );
    m_DigitalOutputList.Add( TUNER_PROGRAM2_AVAIL__DigitalOutput__, TUNER_PROGRAM2_AVAIL );
    
    TUNER_PROGRAM3_AVAIL = new Crestron.Logos.SplusObjects.DigitalOutput( TUNER_PROGRAM3_AVAIL__DigitalOutput__, this );
    m_DigitalOutputList.Add( TUNER_PROGRAM3_AVAIL__DigitalOutput__, TUNER_PROGRAM3_AVAIL );
    
    TUNER_PROGRAM4_AVAIL = new Crestron.Logos.SplusObjects.DigitalOutput( TUNER_PROGRAM4_AVAIL__DigitalOutput__, this );
    m_DigitalOutputList.Add( TUNER_PROGRAM4_AVAIL__DigitalOutput__, TUNER_PROGRAM4_AVAIL );
    
    TUNER_PROGRAM5_AVAIL = new Crestron.Logos.SplusObjects.DigitalOutput( TUNER_PROGRAM5_AVAIL__DigitalOutput__, this );
    m_DigitalOutputList.Add( TUNER_PROGRAM5_AVAIL__DigitalOutput__, TUNER_PROGRAM5_AVAIL );
    
    TUNER_PROGRAM6_AVAIL = new Crestron.Logos.SplusObjects.DigitalOutput( TUNER_PROGRAM6_AVAIL__DigitalOutput__, this );
    m_DigitalOutputList.Add( TUNER_PROGRAM6_AVAIL__DigitalOutput__, TUNER_PROGRAM6_AVAIL );
    
    TUNER_PROGRAM7_AVAIL = new Crestron.Logos.SplusObjects.DigitalOutput( TUNER_PROGRAM7_AVAIL__DigitalOutput__, this );
    m_DigitalOutputList.Add( TUNER_PROGRAM7_AVAIL__DigitalOutput__, TUNER_PROGRAM7_AVAIL );
    
    TUNER_PROGRAM8_AVAIL = new Crestron.Logos.SplusObjects.DigitalOutput( TUNER_PROGRAM8_AVAIL__DigitalOutput__, this );
    m_DigitalOutputList.Add( TUNER_PROGRAM8_AVAIL__DigitalOutput__, TUNER_PROGRAM8_AVAIL );
    
    TUNERDIRVAL = new Crestron.Logos.SplusObjects.AnalogInput( TUNERDIRVAL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( TUNERDIRVAL__AnalogSerialInput__, TUNERDIRVAL );
    
    SIRIUSDIRVAL = new Crestron.Logos.SplusObjects.AnalogInput( SIRIUSDIRVAL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SIRIUSDIRVAL__AnalogSerialInput__, SIRIUSDIRVAL );
    
    PANDORA_MEM_LOC_VAL = new Crestron.Logos.SplusObjects.AnalogInput( PANDORA_MEM_LOC_VAL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( PANDORA_MEM_LOC_VAL__AnalogSerialInput__, PANDORA_MEM_LOC_VAL );
    
    NAPSTER_MEM_LOC_VAL = new Crestron.Logos.SplusObjects.AnalogInput( NAPSTER_MEM_LOC_VAL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( NAPSTER_MEM_LOC_VAL__AnalogSerialInput__, NAPSTER_MEM_LOC_VAL );
    
    SIRIUSIR_MEM_LOC_VAL = new Crestron.Logos.SplusObjects.AnalogInput( SIRIUSIR_MEM_LOC_VAL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SIRIUSIR_MEM_LOC_VAL__AnalogSerialInput__, SIRIUSIR_MEM_LOC_VAL );
    
    RHAP_MEM_LOC_VAL = new Crestron.Logos.SplusObjects.AnalogInput( RHAP_MEM_LOC_VAL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( RHAP_MEM_LOC_VAL__AnalogSerialInput__, RHAP_MEM_LOC_VAL );
    
    PC_MEM_LOC_VAL = new Crestron.Logos.SplusObjects.AnalogInput( PC_MEM_LOC_VAL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( PC_MEM_LOC_VAL__AnalogSerialInput__, PC_MEM_LOC_VAL );
    
    NETRADIO_MEM_LOC_VAL = new Crestron.Logos.SplusObjects.AnalogInput( NETRADIO_MEM_LOC_VAL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( NETRADIO_MEM_LOC_VAL__AnalogSerialInput__, NETRADIO_MEM_LOC_VAL );
    
    USB_MEM_LOC_VAL = new Crestron.Logos.SplusObjects.AnalogInput( USB_MEM_LOC_VAL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( USB_MEM_LOC_VAL__AnalogSerialInput__, USB_MEM_LOC_VAL );
    
    SIRIUS_MEM_LOC_VAL = new Crestron.Logos.SplusObjects.AnalogInput( SIRIUS_MEM_LOC_VAL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SIRIUS_MEM_LOC_VAL__AnalogSerialInput__, SIRIUS_MEM_LOC_VAL );
    
    CMDIN = new Crestron.Logos.SplusObjects.StringInput( CMDIN__AnalogSerialInput__, 100, this );
    m_StringInputList.Add( CMDIN__AnalogSerialInput__, CMDIN );
    
    RXPROCESSED = new Crestron.Logos.SplusObjects.StringOutput( RXPROCESSED__AnalogSerialOutput__, this );
    m_StringOutputList.Add( RXPROCESSED__AnalogSerialOutput__, RXPROCESSED );
    
    RS232_TO_DEV = new Crestron.Logos.SplusObjects.StringOutput( RS232_TO_DEV__AnalogSerialOutput__, this );
    m_StringOutputList.Add( RS232_TO_DEV__AnalogSerialOutput__, RS232_TO_DEV );
    
    MAIN_ZONE_NAME = new Crestron.Logos.SplusObjects.StringOutput( MAIN_ZONE_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_ZONE_NAME__AnalogSerialOutput__, MAIN_ZONE_NAME );
    
    MAIN_SCENE1_NAME = new Crestron.Logos.SplusObjects.StringOutput( MAIN_SCENE1_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_SCENE1_NAME__AnalogSerialOutput__, MAIN_SCENE1_NAME );
    
    MAIN_SCENE2_NAME = new Crestron.Logos.SplusObjects.StringOutput( MAIN_SCENE2_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_SCENE2_NAME__AnalogSerialOutput__, MAIN_SCENE2_NAME );
    
    MAIN_SCENE3_NAME = new Crestron.Logos.SplusObjects.StringOutput( MAIN_SCENE3_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_SCENE3_NAME__AnalogSerialOutput__, MAIN_SCENE3_NAME );
    
    MAIN_SCENE4_NAME = new Crestron.Logos.SplusObjects.StringOutput( MAIN_SCENE4_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_SCENE4_NAME__AnalogSerialOutput__, MAIN_SCENE4_NAME );
    
    MAIN_SCENE5_NAME = new Crestron.Logos.SplusObjects.StringOutput( MAIN_SCENE5_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_SCENE5_NAME__AnalogSerialOutput__, MAIN_SCENE5_NAME );
    
    MAIN_SCENE6_NAME = new Crestron.Logos.SplusObjects.StringOutput( MAIN_SCENE6_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_SCENE6_NAME__AnalogSerialOutput__, MAIN_SCENE6_NAME );
    
    MAIN_SCENE7_NAME = new Crestron.Logos.SplusObjects.StringOutput( MAIN_SCENE7_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_SCENE7_NAME__AnalogSerialOutput__, MAIN_SCENE7_NAME );
    
    MAIN_SCENE8_NAME = new Crestron.Logos.SplusObjects.StringOutput( MAIN_SCENE8_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_SCENE8_NAME__AnalogSerialOutput__, MAIN_SCENE8_NAME );
    
    MAIN_SCENE9_NAME = new Crestron.Logos.SplusObjects.StringOutput( MAIN_SCENE9_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_SCENE9_NAME__AnalogSerialOutput__, MAIN_SCENE9_NAME );
    
    MAIN_SCENE10_NAME = new Crestron.Logos.SplusObjects.StringOutput( MAIN_SCENE10_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_SCENE10_NAME__AnalogSerialOutput__, MAIN_SCENE10_NAME );
    
    MAIN_SCENE11_NAME = new Crestron.Logos.SplusObjects.StringOutput( MAIN_SCENE11_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_SCENE11_NAME__AnalogSerialOutput__, MAIN_SCENE11_NAME );
    
    MAIN_SCENE12_NAME = new Crestron.Logos.SplusObjects.StringOutput( MAIN_SCENE12_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_SCENE12_NAME__AnalogSerialOutput__, MAIN_SCENE12_NAME );
    
    MAIN_SLEEP_TIMER_TEXT = new Crestron.Logos.SplusObjects.StringOutput( MAIN_SLEEP_TIMER_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_SLEEP_TIMER_TEXT__AnalogSerialOutput__, MAIN_SLEEP_TIMER_TEXT );
    
    MAIN_VOL_TEXT = new Crestron.Logos.SplusObjects.StringOutput( MAIN_VOL_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_VOL_TEXT__AnalogSerialOutput__, MAIN_VOL_TEXT );
    
    MAIN_CURR_INPUT_AUDIO_TYPE = new Crestron.Logos.SplusObjects.StringOutput( MAIN_CURR_INPUT_AUDIO_TYPE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_CURR_INPUT_AUDIO_TYPE__AnalogSerialOutput__, MAIN_CURR_INPUT_AUDIO_TYPE );
    
    MAIN_DECODER_MODE = new Crestron.Logos.SplusObjects.StringOutput( MAIN_DECODER_MODE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_DECODER_MODE__AnalogSerialOutput__, MAIN_DECODER_MODE );
    
    MAIN_PURE_DIRECT_MODE = new Crestron.Logos.SplusObjects.StringOutput( MAIN_PURE_DIRECT_MODE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_PURE_DIRECT_MODE__AnalogSerialOutput__, MAIN_PURE_DIRECT_MODE );
    
    MAIN_ADAPTIVE_DYNAMIC_RANGE_MODE = new Crestron.Logos.SplusObjects.StringOutput( MAIN_ADAPTIVE_DYNAMIC_RANGE_MODE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_ADAPTIVE_DYNAMIC_RANGE_MODE__AnalogSerialOutput__, MAIN_ADAPTIVE_DYNAMIC_RANGE_MODE );
    
    MAIN_LIP_SYNC_MODE = new Crestron.Logos.SplusObjects.StringOutput( MAIN_LIP_SYNC_MODE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_LIP_SYNC_MODE__AnalogSerialOutput__, MAIN_LIP_SYNC_MODE );
    
    MAIN_STRAIGHT_MODE_STATUS = new Crestron.Logos.SplusObjects.StringOutput( MAIN_STRAIGHT_MODE_STATUS__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_STRAIGHT_MODE_STATUS__AnalogSerialOutput__, MAIN_STRAIGHT_MODE_STATUS );
    
    MAIN_ENHANCER_STATUS = new Crestron.Logos.SplusObjects.StringOutput( MAIN_ENHANCER_STATUS__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_ENHANCER_STATUS__AnalogSerialOutput__, MAIN_ENHANCER_STATUS );
    
    MAIN_SOUND_PROG_STATUS = new Crestron.Logos.SplusObjects.StringOutput( MAIN_SOUND_PROG_STATUS__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_SOUND_PROG_STATUS__AnalogSerialOutput__, MAIN_SOUND_PROG_STATUS );
    
    MAIN_ADAPTIVE_DSP_MODE = new Crestron.Logos.SplusObjects.StringOutput( MAIN_ADAPTIVE_DSP_MODE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_ADAPTIVE_DSP_MODE__AnalogSerialOutput__, MAIN_ADAPTIVE_DSP_MODE );
    
    MAIN_3D_CINEMA_MODE = new Crestron.Logos.SplusObjects.StringOutput( MAIN_3D_CINEMA_MODE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_3D_CINEMA_MODE__AnalogSerialOutput__, MAIN_3D_CINEMA_MODE );
    
    MAIN_EX_DECODER_MODE = new Crestron.Logos.SplusObjects.StringOutput( MAIN_EX_DECODER_MODE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_EX_DECODER_MODE__AnalogSerialOutput__, MAIN_EX_DECODER_MODE );
    
    MAIN_2CHAN_DECODER_MODE = new Crestron.Logos.SplusObjects.StringOutput( MAIN_2CHAN_DECODER_MODE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_2CHAN_DECODER_MODE__AnalogSerialOutput__, MAIN_2CHAN_DECODER_MODE );
    
    MAIN_CURR_HDMI_OUT_CONFIG = new Crestron.Logos.SplusObjects.StringOutput( MAIN_CURR_HDMI_OUT_CONFIG__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_CURR_HDMI_OUT_CONFIG__AnalogSerialOutput__, MAIN_CURR_HDMI_OUT_CONFIG );
    
    MAIN_HDMI_PROC_STATE = new Crestron.Logos.SplusObjects.StringOutput( MAIN_HDMI_PROC_STATE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_HDMI_PROC_STATE__AnalogSerialOutput__, MAIN_HDMI_PROC_STATE );
    
    MAIN_HDMI_ASPECT = new Crestron.Logos.SplusObjects.StringOutput( MAIN_HDMI_ASPECT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_HDMI_ASPECT__AnalogSerialOutput__, MAIN_HDMI_ASPECT );
    
    MAIN_HDMI_RES = new Crestron.Logos.SplusObjects.StringOutput( MAIN_HDMI_RES__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_HDMI_RES__AnalogSerialOutput__, MAIN_HDMI_RES );
    
    ZONE2_NAME = new Crestron.Logos.SplusObjects.StringOutput( ZONE2_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ZONE2_NAME__AnalogSerialOutput__, ZONE2_NAME );
    
    ZONE2_SCENE1_NAME = new Crestron.Logos.SplusObjects.StringOutput( ZONE2_SCENE1_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ZONE2_SCENE1_NAME__AnalogSerialOutput__, ZONE2_SCENE1_NAME );
    
    ZONE2_SCENE2_NAME = new Crestron.Logos.SplusObjects.StringOutput( ZONE2_SCENE2_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ZONE2_SCENE2_NAME__AnalogSerialOutput__, ZONE2_SCENE2_NAME );
    
    ZONE2_SCENE3_NAME = new Crestron.Logos.SplusObjects.StringOutput( ZONE2_SCENE3_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ZONE2_SCENE3_NAME__AnalogSerialOutput__, ZONE2_SCENE3_NAME );
    
    ZONE2_SCENE4_NAME = new Crestron.Logos.SplusObjects.StringOutput( ZONE2_SCENE4_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ZONE2_SCENE4_NAME__AnalogSerialOutput__, ZONE2_SCENE4_NAME );
    
    ZONE2_SLEEP_TIMER_TEXT = new Crestron.Logos.SplusObjects.StringOutput( ZONE2_SLEEP_TIMER_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ZONE2_SLEEP_TIMER_TEXT__AnalogSerialOutput__, ZONE2_SLEEP_TIMER_TEXT );
    
    ZONE2_VOL_TEXT = new Crestron.Logos.SplusObjects.StringOutput( ZONE2_VOL_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ZONE2_VOL_TEXT__AnalogSerialOutput__, ZONE2_VOL_TEXT );
    
    ZONE3_NAME = new Crestron.Logos.SplusObjects.StringOutput( ZONE3_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ZONE3_NAME__AnalogSerialOutput__, ZONE3_NAME );
    
    ZONE3_SCENE1_NAME = new Crestron.Logos.SplusObjects.StringOutput( ZONE3_SCENE1_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ZONE3_SCENE1_NAME__AnalogSerialOutput__, ZONE3_SCENE1_NAME );
    
    ZONE3_SCENE2_NAME = new Crestron.Logos.SplusObjects.StringOutput( ZONE3_SCENE2_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ZONE3_SCENE2_NAME__AnalogSerialOutput__, ZONE3_SCENE2_NAME );
    
    ZONE3_SCENE3_NAME = new Crestron.Logos.SplusObjects.StringOutput( ZONE3_SCENE3_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ZONE3_SCENE3_NAME__AnalogSerialOutput__, ZONE3_SCENE3_NAME );
    
    ZONE3_SCENE4_NAME = new Crestron.Logos.SplusObjects.StringOutput( ZONE3_SCENE4_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ZONE3_SCENE4_NAME__AnalogSerialOutput__, ZONE3_SCENE4_NAME );
    
    ZONE3_SLEEP_TIMER_TEXT = new Crestron.Logos.SplusObjects.StringOutput( ZONE3_SLEEP_TIMER_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ZONE3_SLEEP_TIMER_TEXT__AnalogSerialOutput__, ZONE3_SLEEP_TIMER_TEXT );
    
    ZONE3_VOL_TEXT = new Crestron.Logos.SplusObjects.StringOutput( ZONE3_VOL_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ZONE3_VOL_TEXT__AnalogSerialOutput__, ZONE3_VOL_TEXT );
    
    ZONE4_NAME = new Crestron.Logos.SplusObjects.StringOutput( ZONE4_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ZONE4_NAME__AnalogSerialOutput__, ZONE4_NAME );
    
    ZONE4_SCENE1_NAME = new Crestron.Logos.SplusObjects.StringOutput( ZONE4_SCENE1_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ZONE4_SCENE1_NAME__AnalogSerialOutput__, ZONE4_SCENE1_NAME );
    
    ZONE4_SCENE2_NAME = new Crestron.Logos.SplusObjects.StringOutput( ZONE4_SCENE2_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ZONE4_SCENE2_NAME__AnalogSerialOutput__, ZONE4_SCENE2_NAME );
    
    ZONE4_SCENE3_NAME = new Crestron.Logos.SplusObjects.StringOutput( ZONE4_SCENE3_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ZONE4_SCENE3_NAME__AnalogSerialOutput__, ZONE4_SCENE3_NAME );
    
    ZONE4_SCENE4_NAME = new Crestron.Logos.SplusObjects.StringOutput( ZONE4_SCENE4_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ZONE4_SCENE4_NAME__AnalogSerialOutput__, ZONE4_SCENE4_NAME );
    
    ZONE4_SLEEP_TIMER_TEXT = new Crestron.Logos.SplusObjects.StringOutput( ZONE4_SLEEP_TIMER_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ZONE4_SLEEP_TIMER_TEXT__AnalogSerialOutput__, ZONE4_SLEEP_TIMER_TEXT );
    
    TUNER_CURR_STATION = new Crestron.Logos.SplusObjects.StringOutput( TUNER_CURR_STATION__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TUNER_CURR_STATION__AnalogSerialOutput__, TUNER_CURR_STATION );
    
    TUNER_CURR_PROGRAM_NUMBER = new Crestron.Logos.SplusObjects.StringOutput( TUNER_CURR_PROGRAM_NUMBER__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TUNER_CURR_PROGRAM_NUMBER__AnalogSerialOutput__, TUNER_CURR_PROGRAM_NUMBER );
    
    TUNER_CURR_PROGRAM_TYPE = new Crestron.Logos.SplusObjects.StringOutput( TUNER_CURR_PROGRAM_TYPE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TUNER_CURR_PROGRAM_TYPE__AnalogSerialOutput__, TUNER_CURR_PROGRAM_TYPE );
    
    TUNER_CURR_SONG = new Crestron.Logos.SplusObjects.StringOutput( TUNER_CURR_SONG__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TUNER_CURR_SONG__AnalogSerialOutput__, TUNER_CURR_SONG );
    
    TUNER_CURR_ARTIST = new Crestron.Logos.SplusObjects.StringOutput( TUNER_CURR_ARTIST__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TUNER_CURR_ARTIST__AnalogSerialOutput__, TUNER_CURR_ARTIST );
    
    TUNER_CURR_ALBUM = new Crestron.Logos.SplusObjects.StringOutput( TUNER_CURR_ALBUM__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TUNER_CURR_ALBUM__AnalogSerialOutput__, TUNER_CURR_ALBUM );
    
    PANDLISTLAYER = new Crestron.Logos.SplusObjects.StringOutput( PANDLISTLAYER__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PANDLISTLAYER__AnalogSerialOutput__, PANDLISTLAYER );
    
    PANDLISTNAME = new Crestron.Logos.SplusObjects.StringOutput( PANDLISTNAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PANDLISTNAME__AnalogSerialOutput__, PANDLISTNAME );
    
    PANDLINE1TEXT = new Crestron.Logos.SplusObjects.StringOutput( PANDLINE1TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PANDLINE1TEXT__AnalogSerialOutput__, PANDLINE1TEXT );
    
    PANDLINE2TEXT = new Crestron.Logos.SplusObjects.StringOutput( PANDLINE2TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PANDLINE2TEXT__AnalogSerialOutput__, PANDLINE2TEXT );
    
    PANDLINE3TEXT = new Crestron.Logos.SplusObjects.StringOutput( PANDLINE3TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PANDLINE3TEXT__AnalogSerialOutput__, PANDLINE3TEXT );
    
    PANDLINE4TEXT = new Crestron.Logos.SplusObjects.StringOutput( PANDLINE4TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PANDLINE4TEXT__AnalogSerialOutput__, PANDLINE4TEXT );
    
    PANDLINE5TEXT = new Crestron.Logos.SplusObjects.StringOutput( PANDLINE5TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PANDLINE5TEXT__AnalogSerialOutput__, PANDLINE5TEXT );
    
    PANDLINE6TEXT = new Crestron.Logos.SplusObjects.StringOutput( PANDLINE6TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PANDLINE6TEXT__AnalogSerialOutput__, PANDLINE6TEXT );
    
    PANDLINE7TEXT = new Crestron.Logos.SplusObjects.StringOutput( PANDLINE7TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PANDLINE7TEXT__AnalogSerialOutput__, PANDLINE7TEXT );
    
    PANDLINE8TEXT = new Crestron.Logos.SplusObjects.StringOutput( PANDLINE8TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PANDLINE8TEXT__AnalogSerialOutput__, PANDLINE8TEXT );
    
    PANDCURRSONGTEXT = new Crestron.Logos.SplusObjects.StringOutput( PANDCURRSONGTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PANDCURRSONGTEXT__AnalogSerialOutput__, PANDCURRSONGTEXT );
    
    PANDCURRALBUMTEXT = new Crestron.Logos.SplusObjects.StringOutput( PANDCURRALBUMTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PANDCURRALBUMTEXT__AnalogSerialOutput__, PANDCURRALBUMTEXT );
    
    PANDCURRSTATIONTEXT = new Crestron.Logos.SplusObjects.StringOutput( PANDCURRSTATIONTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PANDCURRSTATIONTEXT__AnalogSerialOutput__, PANDCURRSTATIONTEXT );
    
    NAPLISTLAYER = new Crestron.Logos.SplusObjects.StringOutput( NAPLISTLAYER__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NAPLISTLAYER__AnalogSerialOutput__, NAPLISTLAYER );
    
    NAPLISTNAME = new Crestron.Logos.SplusObjects.StringOutput( NAPLISTNAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NAPLISTNAME__AnalogSerialOutput__, NAPLISTNAME );
    
    NAPLINE1TEXT = new Crestron.Logos.SplusObjects.StringOutput( NAPLINE1TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NAPLINE1TEXT__AnalogSerialOutput__, NAPLINE1TEXT );
    
    NAPLINE2TEXT = new Crestron.Logos.SplusObjects.StringOutput( NAPLINE2TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NAPLINE2TEXT__AnalogSerialOutput__, NAPLINE2TEXT );
    
    NAPLINE3TEXT = new Crestron.Logos.SplusObjects.StringOutput( NAPLINE3TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NAPLINE3TEXT__AnalogSerialOutput__, NAPLINE3TEXT );
    
    NAPLINE4TEXT = new Crestron.Logos.SplusObjects.StringOutput( NAPLINE4TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NAPLINE4TEXT__AnalogSerialOutput__, NAPLINE4TEXT );
    
    NAPLINE5TEXT = new Crestron.Logos.SplusObjects.StringOutput( NAPLINE5TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NAPLINE5TEXT__AnalogSerialOutput__, NAPLINE5TEXT );
    
    NAPLINE6TEXT = new Crestron.Logos.SplusObjects.StringOutput( NAPLINE6TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NAPLINE6TEXT__AnalogSerialOutput__, NAPLINE6TEXT );
    
    NAPLINE7TEXT = new Crestron.Logos.SplusObjects.StringOutput( NAPLINE7TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NAPLINE7TEXT__AnalogSerialOutput__, NAPLINE7TEXT );
    
    NAPLINE8TEXT = new Crestron.Logos.SplusObjects.StringOutput( NAPLINE8TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NAPLINE8TEXT__AnalogSerialOutput__, NAPLINE8TEXT );
    
    NAPCURRSONGTEXT = new Crestron.Logos.SplusObjects.StringOutput( NAPCURRSONGTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NAPCURRSONGTEXT__AnalogSerialOutput__, NAPCURRSONGTEXT );
    
    NAPCURRARTISTTEXT = new Crestron.Logos.SplusObjects.StringOutput( NAPCURRARTISTTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NAPCURRARTISTTEXT__AnalogSerialOutput__, NAPCURRARTISTTEXT );
    
    NAPCURRALBUMTEXT = new Crestron.Logos.SplusObjects.StringOutput( NAPCURRALBUMTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NAPCURRALBUMTEXT__AnalogSerialOutput__, NAPCURRALBUMTEXT );
    
    SIRIUSIRLISTLAYER = new Crestron.Logos.SplusObjects.StringOutput( SIRIUSIRLISTLAYER__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUSIRLISTLAYER__AnalogSerialOutput__, SIRIUSIRLISTLAYER );
    
    SIRIUSIRLISTNAME = new Crestron.Logos.SplusObjects.StringOutput( SIRIUSIRLISTNAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUSIRLISTNAME__AnalogSerialOutput__, SIRIUSIRLISTNAME );
    
    SIRIUSIRLINE1TEXT = new Crestron.Logos.SplusObjects.StringOutput( SIRIUSIRLINE1TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUSIRLINE1TEXT__AnalogSerialOutput__, SIRIUSIRLINE1TEXT );
    
    SIRIUSIRLINE2TEXT = new Crestron.Logos.SplusObjects.StringOutput( SIRIUSIRLINE2TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUSIRLINE2TEXT__AnalogSerialOutput__, SIRIUSIRLINE2TEXT );
    
    SIRIUSIRLINE3TEXT = new Crestron.Logos.SplusObjects.StringOutput( SIRIUSIRLINE3TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUSIRLINE3TEXT__AnalogSerialOutput__, SIRIUSIRLINE3TEXT );
    
    SIRIUSIRLINE4TEXT = new Crestron.Logos.SplusObjects.StringOutput( SIRIUSIRLINE4TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUSIRLINE4TEXT__AnalogSerialOutput__, SIRIUSIRLINE4TEXT );
    
    SIRIUSIRLINE5TEXT = new Crestron.Logos.SplusObjects.StringOutput( SIRIUSIRLINE5TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUSIRLINE5TEXT__AnalogSerialOutput__, SIRIUSIRLINE5TEXT );
    
    SIRIUSIRLINE6TEXT = new Crestron.Logos.SplusObjects.StringOutput( SIRIUSIRLINE6TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUSIRLINE6TEXT__AnalogSerialOutput__, SIRIUSIRLINE6TEXT );
    
    SIRIUSIRLINE7TEXT = new Crestron.Logos.SplusObjects.StringOutput( SIRIUSIRLINE7TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUSIRLINE7TEXT__AnalogSerialOutput__, SIRIUSIRLINE7TEXT );
    
    SIRIUSIRLINE8TEXT = new Crestron.Logos.SplusObjects.StringOutput( SIRIUSIRLINE8TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUSIRLINE8TEXT__AnalogSerialOutput__, SIRIUSIRLINE8TEXT );
    
    SIRIUSIRCURRSONGTEXT = new Crestron.Logos.SplusObjects.StringOutput( SIRIUSIRCURRSONGTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUSIRCURRSONGTEXT__AnalogSerialOutput__, SIRIUSIRCURRSONGTEXT );
    
    SIRIUSIRCURRARTISTTEXT = new Crestron.Logos.SplusObjects.StringOutput( SIRIUSIRCURRARTISTTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUSIRCURRARTISTTEXT__AnalogSerialOutput__, SIRIUSIRCURRARTISTTEXT );
    
    SIRIUSIRCURRALBUMTEXT = new Crestron.Logos.SplusObjects.StringOutput( SIRIUSIRCURRALBUMTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUSIRCURRALBUMTEXT__AnalogSerialOutput__, SIRIUSIRCURRALBUMTEXT );
    
    SIRIUSIRCURRCHANNELTEXT = new Crestron.Logos.SplusObjects.StringOutput( SIRIUSIRCURRCHANNELTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUSIRCURRCHANNELTEXT__AnalogSerialOutput__, SIRIUSIRCURRCHANNELTEXT );
    
    RHAPLISTLAYER = new Crestron.Logos.SplusObjects.StringOutput( RHAPLISTLAYER__AnalogSerialOutput__, this );
    m_StringOutputList.Add( RHAPLISTLAYER__AnalogSerialOutput__, RHAPLISTLAYER );
    
    RHAPLISTNAME = new Crestron.Logos.SplusObjects.StringOutput( RHAPLISTNAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( RHAPLISTNAME__AnalogSerialOutput__, RHAPLISTNAME );
    
    RHAPLINE1TEXT = new Crestron.Logos.SplusObjects.StringOutput( RHAPLINE1TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( RHAPLINE1TEXT__AnalogSerialOutput__, RHAPLINE1TEXT );
    
    RHAPLINE2TEXT = new Crestron.Logos.SplusObjects.StringOutput( RHAPLINE2TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( RHAPLINE2TEXT__AnalogSerialOutput__, RHAPLINE2TEXT );
    
    RHAPLINE3TEXT = new Crestron.Logos.SplusObjects.StringOutput( RHAPLINE3TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( RHAPLINE3TEXT__AnalogSerialOutput__, RHAPLINE3TEXT );
    
    RHAPLINE4TEXT = new Crestron.Logos.SplusObjects.StringOutput( RHAPLINE4TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( RHAPLINE4TEXT__AnalogSerialOutput__, RHAPLINE4TEXT );
    
    RHAPLINE5TEXT = new Crestron.Logos.SplusObjects.StringOutput( RHAPLINE5TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( RHAPLINE5TEXT__AnalogSerialOutput__, RHAPLINE5TEXT );
    
    RHAPLINE6TEXT = new Crestron.Logos.SplusObjects.StringOutput( RHAPLINE6TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( RHAPLINE6TEXT__AnalogSerialOutput__, RHAPLINE6TEXT );
    
    RHAPLINE7TEXT = new Crestron.Logos.SplusObjects.StringOutput( RHAPLINE7TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( RHAPLINE7TEXT__AnalogSerialOutput__, RHAPLINE7TEXT );
    
    RHAPLINE8TEXT = new Crestron.Logos.SplusObjects.StringOutput( RHAPLINE8TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( RHAPLINE8TEXT__AnalogSerialOutput__, RHAPLINE8TEXT );
    
    RHAPCURRSONGTEXT = new Crestron.Logos.SplusObjects.StringOutput( RHAPCURRSONGTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( RHAPCURRSONGTEXT__AnalogSerialOutput__, RHAPCURRSONGTEXT );
    
    RHAPCURRARTISTTEXT = new Crestron.Logos.SplusObjects.StringOutput( RHAPCURRARTISTTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( RHAPCURRARTISTTEXT__AnalogSerialOutput__, RHAPCURRARTISTTEXT );
    
    RHAPCURRALBUMTEXT = new Crestron.Logos.SplusObjects.StringOutput( RHAPCURRALBUMTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( RHAPCURRALBUMTEXT__AnalogSerialOutput__, RHAPCURRALBUMTEXT );
    
    PCLISTLAYER = new Crestron.Logos.SplusObjects.StringOutput( PCLISTLAYER__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PCLISTLAYER__AnalogSerialOutput__, PCLISTLAYER );
    
    PCLISTNAME = new Crestron.Logos.SplusObjects.StringOutput( PCLISTNAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PCLISTNAME__AnalogSerialOutput__, PCLISTNAME );
    
    PCLINE1TEXT = new Crestron.Logos.SplusObjects.StringOutput( PCLINE1TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PCLINE1TEXT__AnalogSerialOutput__, PCLINE1TEXT );
    
    PCLINE2TEXT = new Crestron.Logos.SplusObjects.StringOutput( PCLINE2TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PCLINE2TEXT__AnalogSerialOutput__, PCLINE2TEXT );
    
    PCLINE3TEXT = new Crestron.Logos.SplusObjects.StringOutput( PCLINE3TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PCLINE3TEXT__AnalogSerialOutput__, PCLINE3TEXT );
    
    PCLINE4TEXT = new Crestron.Logos.SplusObjects.StringOutput( PCLINE4TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PCLINE4TEXT__AnalogSerialOutput__, PCLINE4TEXT );
    
    PCLINE5TEXT = new Crestron.Logos.SplusObjects.StringOutput( PCLINE5TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PCLINE5TEXT__AnalogSerialOutput__, PCLINE5TEXT );
    
    PCLINE6TEXT = new Crestron.Logos.SplusObjects.StringOutput( PCLINE6TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PCLINE6TEXT__AnalogSerialOutput__, PCLINE6TEXT );
    
    PCLINE7TEXT = new Crestron.Logos.SplusObjects.StringOutput( PCLINE7TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PCLINE7TEXT__AnalogSerialOutput__, PCLINE7TEXT );
    
    PCLINE8TEXT = new Crestron.Logos.SplusObjects.StringOutput( PCLINE8TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PCLINE8TEXT__AnalogSerialOutput__, PCLINE8TEXT );
    
    PCCURRSONGTEXT = new Crestron.Logos.SplusObjects.StringOutput( PCCURRSONGTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PCCURRSONGTEXT__AnalogSerialOutput__, PCCURRSONGTEXT );
    
    PCCURRARTISTTEXT = new Crestron.Logos.SplusObjects.StringOutput( PCCURRARTISTTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PCCURRARTISTTEXT__AnalogSerialOutput__, PCCURRARTISTTEXT );
    
    PCCURRALBUMTEXT = new Crestron.Logos.SplusObjects.StringOutput( PCCURRALBUMTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PCCURRALBUMTEXT__AnalogSerialOutput__, PCCURRALBUMTEXT );
    
    NETRADIOLISTLAYER = new Crestron.Logos.SplusObjects.StringOutput( NETRADIOLISTLAYER__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NETRADIOLISTLAYER__AnalogSerialOutput__, NETRADIOLISTLAYER );
    
    NETRADIOLISTNAME = new Crestron.Logos.SplusObjects.StringOutput( NETRADIOLISTNAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NETRADIOLISTNAME__AnalogSerialOutput__, NETRADIOLISTNAME );
    
    NETRADIOLINE1TEXT = new Crestron.Logos.SplusObjects.StringOutput( NETRADIOLINE1TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NETRADIOLINE1TEXT__AnalogSerialOutput__, NETRADIOLINE1TEXT );
    
    NETRADIOLINE2TEXT = new Crestron.Logos.SplusObjects.StringOutput( NETRADIOLINE2TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NETRADIOLINE2TEXT__AnalogSerialOutput__, NETRADIOLINE2TEXT );
    
    NETRADIOLINE3TEXT = new Crestron.Logos.SplusObjects.StringOutput( NETRADIOLINE3TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NETRADIOLINE3TEXT__AnalogSerialOutput__, NETRADIOLINE3TEXT );
    
    NETRADIOLINE4TEXT = new Crestron.Logos.SplusObjects.StringOutput( NETRADIOLINE4TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NETRADIOLINE4TEXT__AnalogSerialOutput__, NETRADIOLINE4TEXT );
    
    NETRADIOLINE5TEXT = new Crestron.Logos.SplusObjects.StringOutput( NETRADIOLINE5TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NETRADIOLINE5TEXT__AnalogSerialOutput__, NETRADIOLINE5TEXT );
    
    NETRADIOLINE6TEXT = new Crestron.Logos.SplusObjects.StringOutput( NETRADIOLINE6TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NETRADIOLINE6TEXT__AnalogSerialOutput__, NETRADIOLINE6TEXT );
    
    NETRADIOLINE7TEXT = new Crestron.Logos.SplusObjects.StringOutput( NETRADIOLINE7TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NETRADIOLINE7TEXT__AnalogSerialOutput__, NETRADIOLINE7TEXT );
    
    NETRADIOLINE8TEXT = new Crestron.Logos.SplusObjects.StringOutput( NETRADIOLINE8TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NETRADIOLINE8TEXT__AnalogSerialOutput__, NETRADIOLINE8TEXT );
    
    NETRADIOCURRSONGTEXT = new Crestron.Logos.SplusObjects.StringOutput( NETRADIOCURRSONGTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NETRADIOCURRSONGTEXT__AnalogSerialOutput__, NETRADIOCURRSONGTEXT );
    
    NETRADIOCURRARTISTTEXT = new Crestron.Logos.SplusObjects.StringOutput( NETRADIOCURRARTISTTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NETRADIOCURRARTISTTEXT__AnalogSerialOutput__, NETRADIOCURRARTISTTEXT );
    
    NETRADIOCURRALBUMTEXT = new Crestron.Logos.SplusObjects.StringOutput( NETRADIOCURRALBUMTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NETRADIOCURRALBUMTEXT__AnalogSerialOutput__, NETRADIOCURRALBUMTEXT );
    
    NETRADIOCURRCHANNELTEXT = new Crestron.Logos.SplusObjects.StringOutput( NETRADIOCURRCHANNELTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( NETRADIOCURRCHANNELTEXT__AnalogSerialOutput__, NETRADIOCURRCHANNELTEXT );
    
    USBLISTLAYER = new Crestron.Logos.SplusObjects.StringOutput( USBLISTLAYER__AnalogSerialOutput__, this );
    m_StringOutputList.Add( USBLISTLAYER__AnalogSerialOutput__, USBLISTLAYER );
    
    USBLISTNAME = new Crestron.Logos.SplusObjects.StringOutput( USBLISTNAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( USBLISTNAME__AnalogSerialOutput__, USBLISTNAME );
    
    USBLINE1TEXT = new Crestron.Logos.SplusObjects.StringOutput( USBLINE1TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( USBLINE1TEXT__AnalogSerialOutput__, USBLINE1TEXT );
    
    USBLINE2TEXT = new Crestron.Logos.SplusObjects.StringOutput( USBLINE2TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( USBLINE2TEXT__AnalogSerialOutput__, USBLINE2TEXT );
    
    USBLINE3TEXT = new Crestron.Logos.SplusObjects.StringOutput( USBLINE3TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( USBLINE3TEXT__AnalogSerialOutput__, USBLINE3TEXT );
    
    USBLINE4TEXT = new Crestron.Logos.SplusObjects.StringOutput( USBLINE4TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( USBLINE4TEXT__AnalogSerialOutput__, USBLINE4TEXT );
    
    USBLINE5TEXT = new Crestron.Logos.SplusObjects.StringOutput( USBLINE5TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( USBLINE5TEXT__AnalogSerialOutput__, USBLINE5TEXT );
    
    USBLINE6TEXT = new Crestron.Logos.SplusObjects.StringOutput( USBLINE6TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( USBLINE6TEXT__AnalogSerialOutput__, USBLINE6TEXT );
    
    USBLINE7TEXT = new Crestron.Logos.SplusObjects.StringOutput( USBLINE7TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( USBLINE7TEXT__AnalogSerialOutput__, USBLINE7TEXT );
    
    USBLINE8TEXT = new Crestron.Logos.SplusObjects.StringOutput( USBLINE8TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( USBLINE8TEXT__AnalogSerialOutput__, USBLINE8TEXT );
    
    USBCURRSONGTEXT = new Crestron.Logos.SplusObjects.StringOutput( USBCURRSONGTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( USBCURRSONGTEXT__AnalogSerialOutput__, USBCURRSONGTEXT );
    
    USBCURRARTISTTEXT = new Crestron.Logos.SplusObjects.StringOutput( USBCURRARTISTTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( USBCURRARTISTTEXT__AnalogSerialOutput__, USBCURRARTISTTEXT );
    
    USBCURRALBUMTEXT = new Crestron.Logos.SplusObjects.StringOutput( USBCURRALBUMTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( USBCURRALBUMTEXT__AnalogSerialOutput__, USBCURRALBUMTEXT );
    
    IPODLISTLAYER = new Crestron.Logos.SplusObjects.StringOutput( IPODLISTLAYER__AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPODLISTLAYER__AnalogSerialOutput__, IPODLISTLAYER );
    
    IPODLISTNAME = new Crestron.Logos.SplusObjects.StringOutput( IPODLISTNAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPODLISTNAME__AnalogSerialOutput__, IPODLISTNAME );
    
    IPODLINE1TEXT = new Crestron.Logos.SplusObjects.StringOutput( IPODLINE1TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPODLINE1TEXT__AnalogSerialOutput__, IPODLINE1TEXT );
    
    IPODLINE2TEXT = new Crestron.Logos.SplusObjects.StringOutput( IPODLINE2TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPODLINE2TEXT__AnalogSerialOutput__, IPODLINE2TEXT );
    
    IPODLINE3TEXT = new Crestron.Logos.SplusObjects.StringOutput( IPODLINE3TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPODLINE3TEXT__AnalogSerialOutput__, IPODLINE3TEXT );
    
    IPODLINE4TEXT = new Crestron.Logos.SplusObjects.StringOutput( IPODLINE4TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPODLINE4TEXT__AnalogSerialOutput__, IPODLINE4TEXT );
    
    IPODLINE5TEXT = new Crestron.Logos.SplusObjects.StringOutput( IPODLINE5TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPODLINE5TEXT__AnalogSerialOutput__, IPODLINE5TEXT );
    
    IPODLINE6TEXT = new Crestron.Logos.SplusObjects.StringOutput( IPODLINE6TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPODLINE6TEXT__AnalogSerialOutput__, IPODLINE6TEXT );
    
    IPODLINE7TEXT = new Crestron.Logos.SplusObjects.StringOutput( IPODLINE7TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPODLINE7TEXT__AnalogSerialOutput__, IPODLINE7TEXT );
    
    IPODLINE8TEXT = new Crestron.Logos.SplusObjects.StringOutput( IPODLINE8TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPODLINE8TEXT__AnalogSerialOutput__, IPODLINE8TEXT );
    
    IPODCURRSONGTEXT = new Crestron.Logos.SplusObjects.StringOutput( IPODCURRSONGTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPODCURRSONGTEXT__AnalogSerialOutput__, IPODCURRSONGTEXT );
    
    IPODCURRARTISTTEXT = new Crestron.Logos.SplusObjects.StringOutput( IPODCURRARTISTTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPODCURRARTISTTEXT__AnalogSerialOutput__, IPODCURRARTISTTEXT );
    
    IPODCURRALBUMTEXT = new Crestron.Logos.SplusObjects.StringOutput( IPODCURRALBUMTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( IPODCURRALBUMTEXT__AnalogSerialOutput__, IPODCURRALBUMTEXT );
    
    SIRIUSANTLEVEL = new Crestron.Logos.SplusObjects.StringOutput( SIRIUSANTLEVEL__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUSANTLEVEL__AnalogSerialOutput__, SIRIUSANTLEVEL );
    
    SIRIUSCURRCATTEXT = new Crestron.Logos.SplusObjects.StringOutput( SIRIUSCURRCATTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUSCURRCATTEXT__AnalogSerialOutput__, SIRIUSCURRCATTEXT );
    
    SIRIUSCURRCHANNUMTEXT = new Crestron.Logos.SplusObjects.StringOutput( SIRIUSCURRCHANNUMTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUSCURRCHANNUMTEXT__AnalogSerialOutput__, SIRIUSCURRCHANNUMTEXT );
    
    SIRIUSCURRCHANNAMETEXT = new Crestron.Logos.SplusObjects.StringOutput( SIRIUSCURRCHANNAMETEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUSCURRCHANNAMETEXT__AnalogSerialOutput__, SIRIUSCURRCHANNAMETEXT );
    
    SIRIUSCURRARTISTTEXT = new Crestron.Logos.SplusObjects.StringOutput( SIRIUSCURRARTISTTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUSCURRARTISTTEXT__AnalogSerialOutput__, SIRIUSCURRARTISTTEXT );
    
    SIRIUSCURRSONGTEXT = new Crestron.Logos.SplusObjects.StringOutput( SIRIUSCURRSONGTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUSCURRSONGTEXT__AnalogSerialOutput__, SIRIUSCURRSONGTEXT );
    
    SIRIUSCURRCOMPTEXT = new Crestron.Logos.SplusObjects.StringOutput( SIRIUSCURRCOMPTEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUSCURRCOMPTEXT__AnalogSerialOutput__, SIRIUSCURRCOMPTEXT );
    
    RS232FROMDEV = new Crestron.Logos.SplusObjects.BufferInput( RS232FROMDEV__AnalogSerialInput__, 65534, this );
    m_StringInputList.Add( RS232FROMDEV__AnalogSerialInput__, RS232FROMDEV );
    
    
    CMDIN.OnSerialChange.Add( new InputChangeHandlerWrapper( CMDIN_OnChange_0, false ) );
    TUNERDIRVAL.OnAnalogChange.Add( new InputChangeHandlerWrapper( TUNERDIRVAL_OnChange_1, false ) );
    SIRIUSDIRVAL.OnAnalogChange.Add( new InputChangeHandlerWrapper( SIRIUSDIRVAL_OnChange_2, false ) );
    PANDORA_MEM_SAVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( PANDORA_MEM_SAVE_OnPush_3, false ) );
    NAPSTER_MEM_SAVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( NAPSTER_MEM_SAVE_OnPush_4, false ) );
    SIRIUSIR_MEM_SAVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( SIRIUSIR_MEM_SAVE_OnPush_5, false ) );
    RHAP_MEM_SAVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( RHAP_MEM_SAVE_OnPush_6, false ) );
    PC_MEM_SAVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( PC_MEM_SAVE_OnPush_7, false ) );
    NETRADIO_MEM_SAVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( NETRADIO_MEM_SAVE_OnPush_8, false ) );
    USB_MEM_SAVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( USB_MEM_SAVE_OnPush_9, false ) );
    SIRIUS_MEM_SAVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( SIRIUS_MEM_SAVE_OnPush_10, false ) );
    PROCESS.OnDigitalPush.Add( new InputChangeHandlerWrapper( PROCESS_OnPush_11, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_YAMAHA_RX_A3000_RS232_COMMAND___FB_PROCESSOR_V2_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint CMDIN__AnalogSerialInput__ = 0;
const uint RS232FROMDEV__AnalogSerialInput__ = 1;
const uint PROCESS__DigitalInput__ = 0;
const uint TUNERISFM__DigitalInput__ = 1;
const uint PANDORA_MEM_SAVE__DigitalInput__ = 2;
const uint NAPSTER_MEM_SAVE__DigitalInput__ = 3;
const uint SIRIUSIR_MEM_SAVE__DigitalInput__ = 4;
const uint RHAP_MEM_SAVE__DigitalInput__ = 5;
const uint PC_MEM_SAVE__DigitalInput__ = 6;
const uint NETRADIO_MEM_SAVE__DigitalInput__ = 7;
const uint USB_MEM_SAVE__DigitalInput__ = 8;
const uint SIRIUS_MEM_SAVE__DigitalInput__ = 9;
const uint TUNERDIRVAL__AnalogSerialInput__ = 2;
const uint SIRIUSDIRVAL__AnalogSerialInput__ = 3;
const uint PANDORA_MEM_LOC_VAL__AnalogSerialInput__ = 4;
const uint NAPSTER_MEM_LOC_VAL__AnalogSerialInput__ = 5;
const uint SIRIUSIR_MEM_LOC_VAL__AnalogSerialInput__ = 6;
const uint RHAP_MEM_LOC_VAL__AnalogSerialInput__ = 7;
const uint PC_MEM_LOC_VAL__AnalogSerialInput__ = 8;
const uint NETRADIO_MEM_LOC_VAL__AnalogSerialInput__ = 9;
const uint USB_MEM_LOC_VAL__AnalogSerialInput__ = 10;
const uint SIRIUS_MEM_LOC_VAL__AnalogSerialInput__ = 11;
const uint TUNER_PROGRAM1_AVAIL__DigitalOutput__ = 0;
const uint TUNER_PROGRAM2_AVAIL__DigitalOutput__ = 1;
const uint TUNER_PROGRAM3_AVAIL__DigitalOutput__ = 2;
const uint TUNER_PROGRAM4_AVAIL__DigitalOutput__ = 3;
const uint TUNER_PROGRAM5_AVAIL__DigitalOutput__ = 4;
const uint TUNER_PROGRAM6_AVAIL__DigitalOutput__ = 5;
const uint TUNER_PROGRAM7_AVAIL__DigitalOutput__ = 6;
const uint TUNER_PROGRAM8_AVAIL__DigitalOutput__ = 7;
const uint RXPROCESSED__AnalogSerialOutput__ = 0;
const uint RS232_TO_DEV__AnalogSerialOutput__ = 1;
const uint MAIN_ZONE_NAME__AnalogSerialOutput__ = 2;
const uint MAIN_SCENE1_NAME__AnalogSerialOutput__ = 3;
const uint MAIN_SCENE2_NAME__AnalogSerialOutput__ = 4;
const uint MAIN_SCENE3_NAME__AnalogSerialOutput__ = 5;
const uint MAIN_SCENE4_NAME__AnalogSerialOutput__ = 6;
const uint MAIN_SCENE5_NAME__AnalogSerialOutput__ = 7;
const uint MAIN_SCENE6_NAME__AnalogSerialOutput__ = 8;
const uint MAIN_SCENE7_NAME__AnalogSerialOutput__ = 9;
const uint MAIN_SCENE8_NAME__AnalogSerialOutput__ = 10;
const uint MAIN_SCENE9_NAME__AnalogSerialOutput__ = 11;
const uint MAIN_SCENE10_NAME__AnalogSerialOutput__ = 12;
const uint MAIN_SCENE11_NAME__AnalogSerialOutput__ = 13;
const uint MAIN_SCENE12_NAME__AnalogSerialOutput__ = 14;
const uint MAIN_SLEEP_TIMER_TEXT__AnalogSerialOutput__ = 15;
const uint MAIN_VOL_TEXT__AnalogSerialOutput__ = 16;
const uint MAIN_CURR_INPUT_AUDIO_TYPE__AnalogSerialOutput__ = 17;
const uint MAIN_DECODER_MODE__AnalogSerialOutput__ = 18;
const uint MAIN_PURE_DIRECT_MODE__AnalogSerialOutput__ = 19;
const uint MAIN_ADAPTIVE_DYNAMIC_RANGE_MODE__AnalogSerialOutput__ = 20;
const uint MAIN_LIP_SYNC_MODE__AnalogSerialOutput__ = 21;
const uint MAIN_STRAIGHT_MODE_STATUS__AnalogSerialOutput__ = 22;
const uint MAIN_ENHANCER_STATUS__AnalogSerialOutput__ = 23;
const uint MAIN_SOUND_PROG_STATUS__AnalogSerialOutput__ = 24;
const uint MAIN_ADAPTIVE_DSP_MODE__AnalogSerialOutput__ = 25;
const uint MAIN_3D_CINEMA_MODE__AnalogSerialOutput__ = 26;
const uint MAIN_EX_DECODER_MODE__AnalogSerialOutput__ = 27;
const uint MAIN_2CHAN_DECODER_MODE__AnalogSerialOutput__ = 28;
const uint MAIN_CURR_HDMI_OUT_CONFIG__AnalogSerialOutput__ = 29;
const uint MAIN_HDMI_PROC_STATE__AnalogSerialOutput__ = 30;
const uint MAIN_HDMI_ASPECT__AnalogSerialOutput__ = 31;
const uint MAIN_HDMI_RES__AnalogSerialOutput__ = 32;
const uint ZONE2_NAME__AnalogSerialOutput__ = 33;
const uint ZONE2_SCENE1_NAME__AnalogSerialOutput__ = 34;
const uint ZONE2_SCENE2_NAME__AnalogSerialOutput__ = 35;
const uint ZONE2_SCENE3_NAME__AnalogSerialOutput__ = 36;
const uint ZONE2_SCENE4_NAME__AnalogSerialOutput__ = 37;
const uint ZONE2_SLEEP_TIMER_TEXT__AnalogSerialOutput__ = 38;
const uint ZONE2_VOL_TEXT__AnalogSerialOutput__ = 39;
const uint ZONE3_NAME__AnalogSerialOutput__ = 40;
const uint ZONE3_SCENE1_NAME__AnalogSerialOutput__ = 41;
const uint ZONE3_SCENE2_NAME__AnalogSerialOutput__ = 42;
const uint ZONE3_SCENE3_NAME__AnalogSerialOutput__ = 43;
const uint ZONE3_SCENE4_NAME__AnalogSerialOutput__ = 44;
const uint ZONE3_SLEEP_TIMER_TEXT__AnalogSerialOutput__ = 45;
const uint ZONE3_VOL_TEXT__AnalogSerialOutput__ = 46;
const uint ZONE4_NAME__AnalogSerialOutput__ = 47;
const uint ZONE4_SCENE1_NAME__AnalogSerialOutput__ = 48;
const uint ZONE4_SCENE2_NAME__AnalogSerialOutput__ = 49;
const uint ZONE4_SCENE3_NAME__AnalogSerialOutput__ = 50;
const uint ZONE4_SCENE4_NAME__AnalogSerialOutput__ = 51;
const uint ZONE4_SLEEP_TIMER_TEXT__AnalogSerialOutput__ = 52;
const uint TUNER_CURR_STATION__AnalogSerialOutput__ = 53;
const uint TUNER_CURR_PROGRAM_NUMBER__AnalogSerialOutput__ = 54;
const uint TUNER_CURR_PROGRAM_TYPE__AnalogSerialOutput__ = 55;
const uint TUNER_CURR_SONG__AnalogSerialOutput__ = 56;
const uint TUNER_CURR_ARTIST__AnalogSerialOutput__ = 57;
const uint TUNER_CURR_ALBUM__AnalogSerialOutput__ = 58;
const uint PANDLISTLAYER__AnalogSerialOutput__ = 59;
const uint PANDLISTNAME__AnalogSerialOutput__ = 60;
const uint PANDLINE1TEXT__AnalogSerialOutput__ = 61;
const uint PANDLINE2TEXT__AnalogSerialOutput__ = 62;
const uint PANDLINE3TEXT__AnalogSerialOutput__ = 63;
const uint PANDLINE4TEXT__AnalogSerialOutput__ = 64;
const uint PANDLINE5TEXT__AnalogSerialOutput__ = 65;
const uint PANDLINE6TEXT__AnalogSerialOutput__ = 66;
const uint PANDLINE7TEXT__AnalogSerialOutput__ = 67;
const uint PANDLINE8TEXT__AnalogSerialOutput__ = 68;
const uint PANDCURRSONGTEXT__AnalogSerialOutput__ = 69;
const uint PANDCURRALBUMTEXT__AnalogSerialOutput__ = 70;
const uint PANDCURRSTATIONTEXT__AnalogSerialOutput__ = 71;
const uint NAPLISTLAYER__AnalogSerialOutput__ = 72;
const uint NAPLISTNAME__AnalogSerialOutput__ = 73;
const uint NAPLINE1TEXT__AnalogSerialOutput__ = 74;
const uint NAPLINE2TEXT__AnalogSerialOutput__ = 75;
const uint NAPLINE3TEXT__AnalogSerialOutput__ = 76;
const uint NAPLINE4TEXT__AnalogSerialOutput__ = 77;
const uint NAPLINE5TEXT__AnalogSerialOutput__ = 78;
const uint NAPLINE6TEXT__AnalogSerialOutput__ = 79;
const uint NAPLINE7TEXT__AnalogSerialOutput__ = 80;
const uint NAPLINE8TEXT__AnalogSerialOutput__ = 81;
const uint NAPCURRSONGTEXT__AnalogSerialOutput__ = 82;
const uint NAPCURRARTISTTEXT__AnalogSerialOutput__ = 83;
const uint NAPCURRALBUMTEXT__AnalogSerialOutput__ = 84;
const uint SIRIUSIRLISTLAYER__AnalogSerialOutput__ = 85;
const uint SIRIUSIRLISTNAME__AnalogSerialOutput__ = 86;
const uint SIRIUSIRLINE1TEXT__AnalogSerialOutput__ = 87;
const uint SIRIUSIRLINE2TEXT__AnalogSerialOutput__ = 88;
const uint SIRIUSIRLINE3TEXT__AnalogSerialOutput__ = 89;
const uint SIRIUSIRLINE4TEXT__AnalogSerialOutput__ = 90;
const uint SIRIUSIRLINE5TEXT__AnalogSerialOutput__ = 91;
const uint SIRIUSIRLINE6TEXT__AnalogSerialOutput__ = 92;
const uint SIRIUSIRLINE7TEXT__AnalogSerialOutput__ = 93;
const uint SIRIUSIRLINE8TEXT__AnalogSerialOutput__ = 94;
const uint SIRIUSIRCURRSONGTEXT__AnalogSerialOutput__ = 95;
const uint SIRIUSIRCURRARTISTTEXT__AnalogSerialOutput__ = 96;
const uint SIRIUSIRCURRALBUMTEXT__AnalogSerialOutput__ = 97;
const uint SIRIUSIRCURRCHANNELTEXT__AnalogSerialOutput__ = 98;
const uint RHAPLISTLAYER__AnalogSerialOutput__ = 99;
const uint RHAPLISTNAME__AnalogSerialOutput__ = 100;
const uint RHAPLINE1TEXT__AnalogSerialOutput__ = 101;
const uint RHAPLINE2TEXT__AnalogSerialOutput__ = 102;
const uint RHAPLINE3TEXT__AnalogSerialOutput__ = 103;
const uint RHAPLINE4TEXT__AnalogSerialOutput__ = 104;
const uint RHAPLINE5TEXT__AnalogSerialOutput__ = 105;
const uint RHAPLINE6TEXT__AnalogSerialOutput__ = 106;
const uint RHAPLINE7TEXT__AnalogSerialOutput__ = 107;
const uint RHAPLINE8TEXT__AnalogSerialOutput__ = 108;
const uint RHAPCURRSONGTEXT__AnalogSerialOutput__ = 109;
const uint RHAPCURRARTISTTEXT__AnalogSerialOutput__ = 110;
const uint RHAPCURRALBUMTEXT__AnalogSerialOutput__ = 111;
const uint PCLISTLAYER__AnalogSerialOutput__ = 112;
const uint PCLISTNAME__AnalogSerialOutput__ = 113;
const uint PCLINE1TEXT__AnalogSerialOutput__ = 114;
const uint PCLINE2TEXT__AnalogSerialOutput__ = 115;
const uint PCLINE3TEXT__AnalogSerialOutput__ = 116;
const uint PCLINE4TEXT__AnalogSerialOutput__ = 117;
const uint PCLINE5TEXT__AnalogSerialOutput__ = 118;
const uint PCLINE6TEXT__AnalogSerialOutput__ = 119;
const uint PCLINE7TEXT__AnalogSerialOutput__ = 120;
const uint PCLINE8TEXT__AnalogSerialOutput__ = 121;
const uint PCCURRSONGTEXT__AnalogSerialOutput__ = 122;
const uint PCCURRARTISTTEXT__AnalogSerialOutput__ = 123;
const uint PCCURRALBUMTEXT__AnalogSerialOutput__ = 124;
const uint NETRADIOLISTLAYER__AnalogSerialOutput__ = 125;
const uint NETRADIOLISTNAME__AnalogSerialOutput__ = 126;
const uint NETRADIOLINE1TEXT__AnalogSerialOutput__ = 127;
const uint NETRADIOLINE2TEXT__AnalogSerialOutput__ = 128;
const uint NETRADIOLINE3TEXT__AnalogSerialOutput__ = 129;
const uint NETRADIOLINE4TEXT__AnalogSerialOutput__ = 130;
const uint NETRADIOLINE5TEXT__AnalogSerialOutput__ = 131;
const uint NETRADIOLINE6TEXT__AnalogSerialOutput__ = 132;
const uint NETRADIOLINE7TEXT__AnalogSerialOutput__ = 133;
const uint NETRADIOLINE8TEXT__AnalogSerialOutput__ = 134;
const uint NETRADIOCURRSONGTEXT__AnalogSerialOutput__ = 135;
const uint NETRADIOCURRARTISTTEXT__AnalogSerialOutput__ = 136;
const uint NETRADIOCURRALBUMTEXT__AnalogSerialOutput__ = 137;
const uint NETRADIOCURRCHANNELTEXT__AnalogSerialOutput__ = 138;
const uint USBLISTLAYER__AnalogSerialOutput__ = 139;
const uint USBLISTNAME__AnalogSerialOutput__ = 140;
const uint USBLINE1TEXT__AnalogSerialOutput__ = 141;
const uint USBLINE2TEXT__AnalogSerialOutput__ = 142;
const uint USBLINE3TEXT__AnalogSerialOutput__ = 143;
const uint USBLINE4TEXT__AnalogSerialOutput__ = 144;
const uint USBLINE5TEXT__AnalogSerialOutput__ = 145;
const uint USBLINE6TEXT__AnalogSerialOutput__ = 146;
const uint USBLINE7TEXT__AnalogSerialOutput__ = 147;
const uint USBLINE8TEXT__AnalogSerialOutput__ = 148;
const uint USBCURRSONGTEXT__AnalogSerialOutput__ = 149;
const uint USBCURRARTISTTEXT__AnalogSerialOutput__ = 150;
const uint USBCURRALBUMTEXT__AnalogSerialOutput__ = 151;
const uint IPODLISTLAYER__AnalogSerialOutput__ = 152;
const uint IPODLISTNAME__AnalogSerialOutput__ = 153;
const uint IPODLINE1TEXT__AnalogSerialOutput__ = 154;
const uint IPODLINE2TEXT__AnalogSerialOutput__ = 155;
const uint IPODLINE3TEXT__AnalogSerialOutput__ = 156;
const uint IPODLINE4TEXT__AnalogSerialOutput__ = 157;
const uint IPODLINE5TEXT__AnalogSerialOutput__ = 158;
const uint IPODLINE6TEXT__AnalogSerialOutput__ = 159;
const uint IPODLINE7TEXT__AnalogSerialOutput__ = 160;
const uint IPODLINE8TEXT__AnalogSerialOutput__ = 161;
const uint IPODCURRSONGTEXT__AnalogSerialOutput__ = 162;
const uint IPODCURRARTISTTEXT__AnalogSerialOutput__ = 163;
const uint IPODCURRALBUMTEXT__AnalogSerialOutput__ = 164;
const uint SIRIUSANTLEVEL__AnalogSerialOutput__ = 165;
const uint SIRIUSCURRCATTEXT__AnalogSerialOutput__ = 166;
const uint SIRIUSCURRCHANNUMTEXT__AnalogSerialOutput__ = 167;
const uint SIRIUSCURRCHANNAMETEXT__AnalogSerialOutput__ = 168;
const uint SIRIUSCURRARTISTTEXT__AnalogSerialOutput__ = 169;
const uint SIRIUSCURRSONGTEXT__AnalogSerialOutput__ = 170;
const uint SIRIUSCURRCOMPTEXT__AnalogSerialOutput__ = 171;

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
