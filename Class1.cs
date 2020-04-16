using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Class1
    {
        public  enum E_translate
        {
            /* program */
            LANG_CORE = 1,

            /* common: professions */
            LANG_COMMON_PROF = 100,
            LANG_COMMON_PROF_GUARDIAN,
            LANG_COMMON_PROF_DRAGONHUNTER,
            LANG_COMMON_PROF_WARRIOR,
            LANG_COMMON_PROF_BERSERKER,
            LANG_COMMON_PROF_ENGINEER,
            LANG_COMMON_PROF_SCRAPPER,
            LANG_COMMON_PROF_RANGER,
            LANG_COMMON_PROF_DRUID,
            LANG_COMMON_PROF_THIEF,
            LANG_COMMON_PROF_DAREDEVIL,
            LANG_COMMON_PROF_ELEMENTALIST,
            LANG_COMMON_PROF_TEMPEST,
            LANG_COMMON_PROF_MESMER,
            LANG_COMMON_PROF_CHRONOMANCER,
            LANG_COMMON_PROF_NECROMANCER,
            LANG_COMMON_PROF_REAPER,
            LANG_COMMON_PROF_RECKONER,
            LANG_COMMON_PROF_HERALD,
            LANG_COMMON_PROF_FIREBRAND,
            LANG_COMMON_PROF_SPELLBREAKER,
            LANG_COMMON_PROF_HOLOSMITH,
            LANG_COMMON_PROF_SOULBEAST,
            LANG_COMMON_PROF_DEADEYE,
            LANG_COMMON_PROF_WEAVER,
            LANG_COMMON_PROF_MIRAGE,
            LANG_COMMON_PROF_SCOURGE,
            LANG_COMMON_PROF_RENEGADE,

            /* common: skill itemization */
            LANG_COMMON_SKILLS_TOTAL = 130,
            LANG_COMMON_SKILLS_H,
            LANG_COMMON_SKILLS_F,
            LANG_COMMON_SKILLS_ACTIVATIONS,
            LANG_COMMON_SKILLS_CANCELS,
            LANG_COMMON_SKILLS_WASTED,
            LANG_COMMON_SKILLS_HITSCOMPRESS,
            LANG_COMMON_SKILLS_HITSTOTAL,
            LANG_COMMON_SKILLS_NINETY,
            LANG_COMMON_SKILLS_FIFTY,
            LANG_COMMON_SKILLS_MOVING,
            LANG_COMMON_SKILLS_FLANG_KING,
            LANG_COMMON_SKILLS_CRITS,
            LANG_COMMON_SKILLS_VALUE,
            LANG_COMMON_SKILLS_MIN,
            LANG_COMMON_SKILLS_AVG,
            LANG_COMMON_SKILLS_MAX,
            LANG_COMMON_SKILLS_APXDMG,
            LANG_COMMON_SKILLS_OVERSTACK,
            LANG_COMMON_SKILLS_NOSKILLS,
            LANG_COMMON_SKILLS_REMOVED,
            LANG_COMMON_SKILLS_RESISTED,
            LANG_COMMON_SKILLS_GLANG_CE,
            LANG_COMMON_SKILLS_MISSES,
            LANG_COMMON_SKILLS_NOTARGETS,

            /* common: generic */
            LANG_COMMON_ATT_HEADER = 155,
            LANG_COMMON_ATT_HOSTILE,
            LANG_COMMON_ATT_FRIENDLY,
            LANG_COMMON_DATATYPE_HEADER = 160,
            LANG_COMMON_DATATYPE_COMBAT,
            LANG_COMMON_DATATYPE_ACTIVE,
            LANG_COMMON_DIRECTION_HEADER = 165,
            LANG_COMMON_DIRECTION_OUTGOING,
            LANG_COMMON_DIRECTION_INCOMING,
            LANG_COMMON_DATASTYLE_HEADER = 170,
            LANG_COMMON_DATASTYLE_PERSECOND,
            LANG_COMMON_DATASTYLE_TOTAL,
            LANG_COMMON_DATASTYLE_PERCENT,

            /* panels: dps */
            LANG_PAN_PERSONALDPS_HEADER = 200,
            LANG_PAN_PERSONALDPS_OUT,
            LANG_PAN_PERSONALDPS_IN,
            LANG_PAN_PERSONALDPS_CBT,
            LANG_PAN_PERSONALDPS_ACT,
            LANG_PAN_PERSONALDPS_DAMAGE,
            LANG_PAN_PERSONALDPS_PHYS,
            LANG_PAN_PERSONALDPS_BUFF,
            LANG_PAN_PERSONALDPS_HEALING,
            LANG_PAN_PERSONALDPS_CRIT,
            LANG_PAN_PERSONALDPS_NINETY,
            LANG_PAN_PERSONALDPS_FIFTY,
            LANG_PAN_PERSONALDPS_EVADE,
            LANG_PAN_PERSONALDPS_BLOCK,
            LANG_PAN_PERSONALDPS_ABSORB,
            LANG_PAN_PERSONALDPS_INTERRUPT,
            LANG_PAN_PERSONALDPS_CURRENT,
            LANG_PAN_PERSONALDPS_HIST,
            LANG_PAN_PERSONALDPS_COMBAT,
            LANG_PAN_PERSONALDPS_PS,
            LANG_PAN_PERSONALDPS_DMG,
            LANG_PAN_PERSONALDPS_PERSONAL,
            LANG_PAN_PERSONALDPS_INTERVAL,
            LANG_PAN_PERSONALDPS_MILLISECONDS,
            LANG_PAN_PERSONALDPS_HISTLEFT,
            LANG_PAN_PERSONALDPS_HISTRIGHT,
            LANG_PAN_PERSONALDPS_SHIELDS,

            /* panels: skills */
            LANG_PAN_PERSONALSKILLS_HEADER = 240,
            LANG_PAN_PERSONALSKILLS_OUT,
            LANG_PAN_PERSONALSKILLS_IN,
            LANG_PAN_PERSONALSKILLS_ALL,
            LANG_PAN_PERSONALSKILLS_BUFFS,
            LANG_PAN_PERSONALSKILLS_PHYS,
            LANG_PAN_PERSONALSKILLS_SKREMOVE,
            LANG_PAN_PERSONALSKILLS_CURRENT,
            LANG_PAN_PERSONALSKILLS_HIST,
            LANG_PAN_PERSONALSKILLS_COMBAT,
            LANG_PAN_PERSONALSKILLS_PERSONAL,
            LANG_PAN_PERSONALSKILLS_INTERVAL,
            LANG_PAN_PERSONALSKILLS_MILLISECONDS,
            LANG_PAN_PERSONALSKILLS_HEADERSHORT,

            /* panels: target */
            LANG_PAN_TARGET_HEADER = 270,
            LANG_PAN_TARGET_LOGAUTO,
            LANG_PAN_TARGET_LOGMANUAL,
            LANG_PAN_TARGET_LOGNONE,
            LANG_PAN_TARGET_LOGUNAVAILABLE,
            LANG_PAN_TARGET_NOLOCK,
            LANG_PAN_TARGET_COMBAT,
            LANG_PAN_TARGET_RS,
            LANG_PAN_TARGET_DPS,
            LANG_PAN_TARGET_TTK,
            LANG_PAN_TARGET_START,
            LANG_PAN_TARGET_STOP,

            /* panels: healthbar */
            LANG_PAN_HEALTHBAR_HEADER = 290,
            LANG_PAN_HEALTHBAR_HP,

            /* panels: chcli */
            LANG_PAN_CHCLI_HEADER = 300,
            LANG_PAN_CHCLI_OUT,
            LANG_PAN_CHCLI_IN,
            LANG_PAN_CHCLI_ADPS,
            LANG_PAN_CHCLI_BUFFS,
            LANG_PAN_CHCLI_PHYS,
            LANG_PAN_CHCLI_CND,
            LANG_PAN_CHCLI_TOTAL,
            LANG_PAN_CHCLI_H,
            LANG_PAN_CHCLI_F,
            LANG_PAN_CHCLI_COMBAT,
            LANG_PAN_CHCLI_PS,
            LANG_PAN_CHCLI_DMG,
            LANG_PAN_CHCLI_DISABLED,
            LANG_PAN_CHCLI_SKREMOVE,
            LANG_PAN_CHCLI_CURRENT,
            LANG_PAN_CHCLI_HIST,
            LANG_PAN_CHCLI_AGREMOVE,
            LANG_PAN_CHCLI_CHCLI,
            LANG_PAN_CHCLI_INTERVAL,
            LANG_PAN_CHCLI_MILLISECONDS,
            LANG_PAN_CHCLI_PCT,
            LANG_PAN_CHCLI_NOPLAYERS,
            LANG_PAN_CHCLI_HISTLEFT,
            LANG_PAN_CHCLI_HISTRIGHT,

            /* panels: summary */
            LANG_PAN_SUMMARY_HEADER = 340,
            LANG_PAN_SUMMARY_CBTTIME,
            LANG_PAN_SUMMARY_ADPSOUT,
            LANG_PAN_SUMMARY_TGADPSOUT,
            LANG_PAN_SUMMARY_ADPSIN,
            LANG_PAN_SUMMARY_TGADPSIN,
            LANG_PAN_SUMMARY_CRITPCT,
            LANG_PAN_SUMMARY_NINETYPCT,
            LANG_PAN_SUMMARY_FIFTYPCT,
            LANG_PAN_SUMMARY_MOVINGPCT,
            LANG_PAN_SUMMARY_FLANG_KPCT,
            LANG_PAN_SUMMARY_CANCELTIME,
            LANG_PAN_SUMMARY_RESCOUNT,
            LANG_PAN_SUMMARY_RESTIME,
            LANG_PAN_SUMMARY_DOWNCOUNT,
            LANG_PAN_SUMMARY_CLEANSEDOUT,
            LANG_PAN_SUMMARY_STRIPPEDOUT,
            LANG_PAN_SUMMARY_GLANG_CEPCT,
            LANG_PAN_SUMMARY_EVADES,
            LANG_PAN_SUMMARY_INTERRUPTS,
            LANG_PAN_SUMMARY_MISSES,
            LANG_PAN_SUMMARY_DODGE,
            LANG_PAN_SUMMARY_HIST,
            LANG_PAN_SUMMARY_SQSHORT1,
            LANG_PAN_SUMMARY_SQSHORT2,
            LANG_PAN_SUMMARY_CLEANSEDIN,
            LANG_PAN_SUMMARY_STRIPPEDIN,
            LANG_PAN_SUMMARY_DOWNTIME,
            LANG_PAN_SUMMARY_CANCELCOUNT,
            LANG_PAN_SUMMARY_SHIELDPCT,
            LANG_PAN_SUMMARY_SHIELDEFF,
            LANG_PAN_SUMMARY_BLOCKS,
            LANG_PAN_SUMMARY_ABSORBS,
            LANG_PAN_SUMMARY_CLEANSEDSELF,
            LANG_PAN_SUMMARY_DURATION,
            LANG_PAN_SUMMARY_INTENSITY,
            LANG_PAN_SUMMARY_PHYS,
            LANG_PAN_SUMMARY_COND,
            LANG_PAN_SUMMARY_DPSUPTIME,
            LANG_PAN_SUMMARY_PROTPCT,
            LANG_PAN_SUMMARY_KILLINGBLOWS,
            LANG_PAN_SUMMARY_DOWNEDS,
            LANG_PAN_SUMMARY_DOWNEDPCT,
            LANG_PAN_SUMMARY_ZEROES,
            LANG_PAN_SUMMARY_DEATHCOUNT,

            /* panels: logger */
            LANG_PAN_LOGGER_HEADER = 390,
            LANG_PAN_LOGGER_HEADER_CBT,
            LANG_PAN_LOGGER_ENG,
            LANG_PAN_LOGGER_GME,
            LANG_PAN_LOGGER_BOT,
            LANG_PAN_LOGGER_TOP,
            LANG_PAN_LOGGER_AUTO,
            LANG_PAN_LOGGER_SCROLL,
            LANG_PAN_LOGGER_FILTER,
            LANG_PAN_LOGGER_RESQ,
            LANG_PAN_LOGGER_CBTQ,
            LANG_PAN_LOGGER_MBLK,
            LANG_PAN_LOGGER_MSZ,
            LANG_PAN_LOGGER_AG,
            LANG_PAN_LOGGER_CH,
            LANG_PAN_LOGGER_CEA,
            LANG_PAN_LOGGER_GRC,
            LANG_PAN_LOGGER_SCS,
            LANG_PAN_LOGGER_SCC,
            LANG_PAN_LOGGER_STG,
            LANG_PAN_LOGGER_SAG,
            LANG_PAN_LOGGER_RTH,
            LANG_PAN_LOGGER_CCS,
            LANG_PAN_LOGGER_HS,
            LANG_PAN_LOGGER_UI0,
            LANG_PAN_LOGGER_UI1,
            LANG_PAN_LOGGER_HU,
            LANG_PAN_LOGGER_LOGGER,
            LANG_PAN_LOGGER_CHANNEL,
            LANG_PAN_LOGGER_SIM,
            LANG_PAN_LOGGER_MCI,
            LANG_PAN_LOGGER_MCO,
            LANG_PAN_LOGGER_LINES,
            LANG_PAN_LOGGER_SUPPRESS,
            LANG_PAN_LOGGER_PERFTIME,
            LANG_PAN_LOGGER_PERFUSE,
            LANG_PAN_LOGGER_EVENTS,
            LANG_PAN_LOGGER_CBTSTATECHANGE,
            LANG_PAN_LOGGER_CBTACTIVATION,
            LANG_PAN_LOGGER_CBTBUFFREMOVE,
            LANG_PAN_LOGGER_CBTBUFFAPPLY,
            LANG_PAN_LOGGER_CBTBUFFDAMAGE,
            LANG_PAN_LOGGER_CBTBUFFHEAL,
            LANG_PAN_LOGGER_CBTDIRECTDAMAGE,
            LANG_PAN_LOGGER_CBTDIRECTHEAL,
            LANG_PAN_LOGGER_DEBUG,
            LANG_PAN_LOGGER_CBTMINION,

            /* panels: compass */
            LANG_PAN_COMPASS_HEADER = 440,
            LANG_PAN_COMPASS_N,
            LANG_PAN_COMPASS_E,
            LANG_PAN_COMPASS_S,
            LANG_PAN_COMPASS_W,
            LANG_PAN_COMPASS_BEARING,

            /* panels: metrics */
            LANG_PAN_METRICS_HEADER = 450,
            LANG_PAN_METRICS_FPS,
            LANG_PAN_METRICS_PING,
            LANG_PAN_METRICS_MAPTYPE,
            LANG_PAN_METRICS_MAPID,
            LANG_PAN_METRICS_MAPLV,
            LANG_PAN_METRICS_BUILDGW,
            LANG_PAN_METRICS_BUILDARC,
            LANG_PAN_METRICS_TICK,

            /* panels: gathering */
            LANG_PAN_GATHER_HEADER = 460,
            LANG_PAN_GATHER_PICKH,
            LANG_PAN_GATHER_AXEH,
            LANG_PAN_GATHER_SICKLEH,
            LANG_PAN_GATHER_PICKED,
            LANG_PAN_GATHER_AXED,
            LANG_PAN_GATHER_SICKLED,
            LANG_PAN_GATHER_TOOLS,
            LANG_PAN_GATHER_PICKREMAIN,
            LANG_PAN_GATHER_AXEREMAIN,
            LANG_PAN_GATHER_SICKLEREMAIN,
            LANG_PAN_GATHER_TIME,

            /* panels: options */
            LANG_PAN_OPTIONS_HEADER = 490,
            LANG_PAN_OPTIONS_PANELS,
            LANG_PAN_OPTIONS_SUMMARIES,
            LANG_PAN_OPTIONS_BASIC,
            LANG_PAN_OPTIONS_Y,
            LANG_PAN_OPTIONS_N,
            LANG_PAN_OPTIONS_SM_LINK,
            LANG_PAN_OPTIONS_SM_AUTOOPEN,
            LANG_PAN_OPTIONS_SM_ADPSOUT,
            LANG_PAN_OPTIONS_SM_ADPSIN,
            LANG_PAN_OPTIONS_SM_BUFFS,
            LANG_PAN_OPTIONS_SM_RATES,
            LANG_PAN_OPTIONS_SM_AGSTATES,
            LANG_PAN_OPTIONS_SM_BUFFEVENTS,
            LANG_PAN_OPTIONS_SM_RESULTS,
            LANG_PAN_OPTIONS_BS_LOCKTARGET,
            LANG_PAN_OPTIONS_BS_SAVELOGS,
            LANG_PAN_OPTIONS_BS_NPCINPATH,
            LANG_PAN_OPTIONS_BS_COMPRESS,
            LANG_PAN_OPTIONS_BS_PANSNAP,
            LANG_PAN_OPTIONS_BS_ALWAYSREQMOD,
            LANG_PAN_OPTIONS_BS_COMBATDETAIL,
            LANG_PAN_OPTIONS_BS_VERBOSITY,
            LANG_PAN_OPTIONS_RESTRICTED,
            LANG_PAN_OPTIONS_RS_HBARS,
            LANG_PAN_OPTIONS_RS_EMBEDLL,
            LANG_PAN_OPTIONS_RS_FLASHWHISPER,
            LANG_PAN_OPTIONS_RS_FLASHPARTY,
            LANG_PAN_OPTIONS_RS_RWACCEPT,
            LANG_PAN_OPTIONS_RS_CONSUMEMAX,
            LANG_PAN_OPTIONS_RS_CONSUMESKIPDELAY,
            LANG_PAN_OPTIONS_RS_KEYS,
            LANG_PAN_OPTIONS_BS_GUILDINPATH,
            LANG_PAN_OPTIONS_BS_BGBARS,
            LANG_PAN_OPTIONS_BS_FWDINPUT,
            LANG_PAN_OPTIONS_BS_TRANSPARENCY,
            LANG_PAN_OPTIONS_BS_BGBARCOLOUR,
            LANG_PAN_OPTIONS_BS_PLAYERINPATH,
            LANG_PAN_OPTIONS_BS_ALTERNATEUI,
            LANG_PAN_OPTIONS_BS_RECOUNTLIKE,
            LANG_PAN_OPTIONS_BS_ALTUITRIM,
            LANG_PAN_OPTIONS_BS_ALTUIMOVELOCK,
            LANG_PAN_OPTIONS_BS_MENULOCK,
            LANG_PAN_OPTIONS_BS_NOTOTALS,
            LANG_PAN_OPTIONS_BS_ALTUICLICKLOCK,
            LANG_PAN_OPTIONS_RS_EMBEDEXTRA,
            LANG_PAN_OPTIONS_BS_LOGGING,
            LANG_PAN_OPTIONS_SM_HIDEZEROBUFFS,
            LANG_PAN_OPTIONS_RS_HIDEOBLACH,
            LANG_PAN_OPTIONS_RS_HIDEOBLQUEST,
            LANG_PAN_OPTIONS_BS_NOTIMERS,
            LANG_PAN_OPTIONS_BS_FASTCLOSE,
            LANG_PAN_OPTIONS_BS_LOGS,
            LANG_PAN_OPTIONS_BS_CONFIG,
            LANG_PAN_OPTIONS_BS_STYLE,
            LANG_PAN_OPTIONS_BS_COLOURSIMGUI,
            LANG_PAN_OPTIONS_BS_COLOURSARC,
            LANG_PAN_OPTIONS_BS_COLOURSPROF,
            LANG_PAN_OPTIONS_BS_COLOURSSQUAD,
            LANG_PAN_OPTIONS_BS_APPEARANCE,

            /* panels: consume */
            LANG_PAN_CONSUME_HEADER = 550,
            LANG_PAN_CONSUME_NONE,

            /* panels: waypoint */
            LANG_PAN_WAYPOINT_HEADER = 560,
            LANG_PAN_WAYPOINT_EBG,
            LANG_PAN_WAYPOINT_RBL,
            LANG_PAN_WAYPOINT_BBL,
            LANG_PAN_WAYPOINT_GBL,
            LANG_PAN_WAYPOINT_NONE,
            LANG_PAN_WAYPOINT_DISABLED,

            /* panels: templates */
            LANG_PAN_TEMPLATES_HEADER = 570,
            LANG_PAN_TEMPLATES_LOAD,
            LANG_PAN_TEMPLATES_SAVE,
            LANG_PAN_TEMPLATES_SORTNUMBER,
            LANG_PAN_TEMPLATES_TRAITS,
            LANG_PAN_TEMPLATES_GEAR,
            LANG_PAN_TEMPLATES_SKILLS,
            LANG_PAN_TEMPLATES_LEGENDARY,
            LANG_PAN_TEMPLATES_PVP,
            LANG_PAN_TEMPLATES_PREEQUIP,
            LANG_PAN_TEMPLATES_SORTALPHA,
            LANG_PAN_TEMPLATES_COPY,
            LANG_PAN_TEMPLATES_NAME,
            LANG_PAN_TEMPLATES_DELETE,
            LANG_PAN_TEMPLATES_OVERWRITE,
            LANG_PAN_TEMPLATES_SAVED,
            LANG_PAN_TEMPLATES_LOADING,
            LANG_PAN_TEMPLATES_REDUCEDRATE,
            LANG_PAN_TEMPLATES_DISABLED,
            LANG_PAN_TEMPLATES_CANCEL,

            /* panels: buffs */
            LANG_PAN_BUFFS_HEADER = 590,
            LANG_PAN_BUFFS_WARNING,

            /* panels: details */
            LANG_PAN_DETAIL_HEADER = 610,
            LANG_PAN_DETAIL_MIN,
            LANG_PAN_DETAIL_MAX,
            LANG_PAN_DETAIL_ELAPSED,
            LANG_PAN_DETAIL_REMOVED,

            /* common: custom */
            LANG_COMMON_CSK_DODGE = 620,
            LANG_COMMON_CSK_SHIELD,

            /* common: skills2 */
            LANG_COMMON_SKILLS2_NOEVENTS = 630,
            LANG_COMMON_SKILLS2_SHIELDED,
            LANG_COMMON_SKILLS2_HITSANY,
            LANG_COMMON_SKILLS2_DMGPHYS,
            LANG_COMMON_SKILLS2_DMGBUFF,
            LANG_COMMON_SKILLS2_CHANNELED,
            LANG_COMMON_SKILLS2_PROTECTED,
            LANG_COMMON_SKILLS2_KILLINGBLOWS,
            LANG_COMMON_SKILLS2_DOWNEDS,
            LANG_COMMON_SKILLS2_VALUESHIELD,
            LANG_COMMON_SKILLS2_BLOCKS,
            LANG_COMMON_SKILLS2_EVADES,
            LANG_COMMON_SKILLS2_ABSORBS,
            LANG_COMMON_SKILLS2_ZEROES,

            /* common: assorted */
            LANG_COMMON_AS_SUCCESS = 660,
            LANG_COMMON_AS_FAIL,
            LANG_COMMON_AS_PADDING,
            LANG_COMMON_AS_BACKGROUND,
            LANG_COMMON_AS_ONELINE,
            LANG_COMMON_AS_ALIGNRIGHT,
            LANG_COMMON_AS_RESET,
            LANG_COMMON_AS_TOTAL,
            LANG_COMMON_AS_CLEAVE,
            LANG_COMMON_AS_TARGET,
            LANG_COMMON_AS_IN,
            LANG_COMMON_AS_TITLE,
            LANG_COMMON_AS_NOHISTORY,
            LANG_COMMON_AS_AUTOSIZE,
            LANG_COMMON_AS_LISTLENGTH,
            LANG_COMMON_AS_SCROLLBAR,
            LANG_COMMON_AS_FRIENDLY,
            LANG_COMMON_AS_LIST,
            LANG_COMMON_AS_SKILLS,
            LANG_COMMON_AS_TARGETS,
            LANG_COMMON_AS_LOG,
            LANG_COMMON_AS_EXTRAS,
            LANG_COMMON_AS_VERSIONCHECK,
            LANG_COMMON_AS_NOOBLACH,
            LANG_COMMON_AS_NOOBLQUEST,
            LANG_COMMON_AS_NOCOMBATTEXT,
            LANG_COMMON_AS_COMBATTIME,
            LANG_COMMON_AS_SORTDPS,
            LANG_COMMON_AS_STYLE,
            LANG_COMMON_AS_BUFFS,
            LANG_COMMON_AS_SORTTARGET,
            LANG_COMMON_AS_DISPLAY,
            LANG_COMMON_AS_COLOURSUBGROUP,
            LANG_COMMON_AS_FORMATTOOLTIP,
            LANG_COMMON_AS_PLAYERFORMAT,
            LANG_COMMON_AS_DEBUG,
            LANG_COMMON_AS_DATA,
            LANG_COMMON_AS_LABELS,
            LANG_COMMON_AS_NUMBERS,
            LANG_COMMON_AS_PROF,
            LANG_COMMON_AS_TOPSKILLS,
            LANG_COMMON_AS_TOPTARGETS,
            LANG_COMMON_AS_WIDTH,
            LANG_COMMON_AS_DAMAGE,
            LANG_COMMON_AS_TAKEN,
            LANG_COMMON_AS_TITLEMATCHFRAME,
            LANG_COMMON_AS_TITLEFORMATTOOLTIP,
            LANG_COMMON_AS_TITLEFORMAT,
            LANG_COMMON_AS_REC,
            LANG_COMMON_AS_CUR,
            LANG_COMMON_AS_LOGSINVALID,
            LANG_COMMON_AS_MAPRELOAD,
            LANG_COMMON_AS_INTERVAL,
            LANG_COMMON_AS_NAMECHARWIDTH,
            LANG_COMMON_AS_NOOBLEVENT,
            LANG_COMMON_AS_SHOWADVANCEDSTYLEOPTS,
            LANG_COMMON_AS_SHOWADVANCEDSTYLEOPTSINFO,
            LANG_COMMON_AS_SHOWADVANCEDSTYLEOPTSCOL,
            LANG_COMMON_AS_SHOWADVANCEDSTYLEOPTSPREC,
            LANG_COMMON_AS_NAME,
            LANG_COMMON_AS_NAMECOLPROF,
            LANG_COMMON_AS_NAMECOLSUBGROUP,
            LANG_COMMON_AS_SORTSUBGROUP,
            LANG_COMMON_AS_MEMGW2,
            LANG_COMMON_AS_MEMARC,
            LANG_COMMON_AS_DISTCBT,
            LANG_COMMON_AS_DISTOOC,
            LANG_COMMON_AS_TIMECBT,
            LANG_COMMON_AS_TIMEOOC,
            LANG_COMMON_AS_DETAILED,
            LANG_COMMON_AS_SLOWVATOOLTIP,
            LANG_COMMON_AS_SLOWVA,
            LANG_COMMON_AS_SIMDISABLED,
            LANG_COMMON_AS_SORTADV,
            LANG_COMMON_AS_SORTADVTOOLTIP,
            LANG_COMMON_AS_SHOWADVANCEDSTYLEOPTSTOOLTIP,
            LANG_COMMON_AS_HISTORY,
            LANG_COMMON_AS_SORTADV_ADVANCED,
            LANG_COMMON_AS_SORTADV_FNNONE,
            LANG_COMMON_AS_SORTADV_FNDOWN,
            LANG_COMMON_AS_SORTADV_FNDOWNPERSIST,
            LANG_COMMON_AS_SORTADV_FNDEATH,
            LANG_COMMON_AS_SORTADV_FNDEATHPERSIST,
            LANG_COMMON_AS_SORTADV_FNRESCOUNT,
            LANG_COMMON_AS_SORTADV_FNRESTIME,
            LANG_COMMON_AS_SORTADV_FNCLEANSE,
            LANG_COMMON_AS_SORTADV_FNSTRIP,
            LANG_COMMON_AS_SORTADV_FNDPSOUTNEARPERSIST,
            LANG_COMMON_AS_SORTADV_FNDPSINNEARPERSIST,
            LANG_COMMON_AS_STATSEXCLUDE,
            LANG_COMMON_AS_STATSEXCLUDETOOLTIP,
            LANG_COMMON_AS_STATSEXCLUDEACTIVE,
            LANG_COMMON_AS_STATSEXCLUDEVSPLAYER,
            LANG_COMMON_AS_STATSEXCLUDEVSNPC,
            LANG_COMMON_AS_STATSEXCLUDEVSGADGET,
            LANG_COMMON_AS_STATSEXCLUDEFROMPLAYER,
            LANG_COMMON_AS_STATSEXCLUDEFROMNPC,
            LANG_COMMON_AS_STATSEXCLUDEFROMGADGET,
            LANG_COMMON_AS_OPTSBASICTOOLTIP,
            LANG_COMMON_AS_OPTSLOGSTOOLTIP,
            LANG_COMMON_AS_OPTSEXTRASTOOLTIP,
            LANG_COMMON_AS_OPTSPLAYERTOOLTIP,
            LANG_COMMON_AS_OPTSDISPLAYTOOLTIP,
            LANG_COMMON_AS_OPTSSTYLETOOLTIP,
            LANG_COMMON_AS_PERSISTRESET,
            LANG_COMMON_AS_SORTADV_FNDPSOUTNEARSQUAD,
            LANG_COMMON_AS_SORTADV_FNDPSINNEARSQUAD,
            LANG_COMMON_AS_ALWAYSSHOWWINDOWS,
            LANG_COMMON_AS_PERSISTPARTYRESET,
            LANG_COMMON_AS_PERSISTPROFRESET,
            LANG_COMMON_AS_DETAILDEFAULT,
            LANG_COMMON_AS_DETAILDEFAULTTOOLTIP,
            LANG_COMMON_AS_SAVEWVWLOGS,
            LANG_COMMON_AS_SAVEWVWLOGSTHRESHOLDMIN,
            LANG_COMMON_AS_SAVEWVWLOGSTHRESHOLDMAX,
            LANG_COMMON_AS_SAVEWVWLOGSTOOLTIP,
            LANG_COMMON_AS_DMGOUT,
            LANG_COMMON_AS_DMGIN,
            LANG_COMMON_AS_SAVEWVWLOGSENEMYMIN,
            LANG_COMMON_AS_ADVANCEDFUNCOPTS,
            LANG_COMMON_AS_SHOWADVANCEDFUNCOPTS,
            LANG_COMMON_AS_SHOWADVANCEDFUNCOPTSTOOLTIP,
            LANG_COMMON_AS_DRAWCOMPAT,
            LANG_COMMON_AS_SAVEPROFKEYBINDS,
            LANG_COMMON_AS_SAVEPROFKEYBINDSTOOLTIP,
            LANG_COMMON_AS_SHOWTARGETINFO,
            LANG_COMMON_AS_TARGETINFOTARGET,
            LANG_COMMON_AS_PERSISTBUILDRESET,
            LANG_COMMON_AS_OPTSTIME,
            LANG_COMMON_AS_OPTSTIMETOOLTIP,
            LANG_COMMON_AS_OPTSTIME_USEDMG,
            LANG_COMMON_AS_DRAWBARS,
            LANG_COMMON_AS_SUBGROUP,
            LANG_COMMON_AS_TOPSUBGROUPS,
            LANG_COMMON_AS_BUFFTOTAL,
            LANG_COMMON_AS_MAP_MAPASSETTIMEOUT,
            LANG_COMMON_AS_MAP_MAPASSETTIMEOUTTOOLTIP,
            LANG_COMMON_AS_MAP_MAPTIMEOUT,
            LANG_COMMON_AS_MAP_MAPTIMEOUTTOOLTIP,
            LANG_COMMON_AS_MAP_MODELTIMEOUT,
            LANG_COMMON_AS_MAP_MODELTIMEOUTTOOLTIP,
            LANG_COMMON_AS_MAP,

            /* end */
            LANG_END
        };

        public string[] Lvs_()
        {
            string[] LANG = new string[2048];


            ///
            ///LANG[(int)E_translate.(int)E_translate.LANG_CORE] = "core";

            LANG[(int)E_translate.LANG_CORE] = "core";

            /* common: professions */
            LANG[(int)E_translate.LANG_COMMON_PROF_GUARDIAN] = "Gdn";
            LANG[(int)E_translate.LANG_COMMON_PROF_DRAGONHUNTER] = "Dgh";
            LANG[(int)E_translate.LANG_COMMON_PROF_WARRIOR] = "War";
            LANG[(int)E_translate.LANG_COMMON_PROF_BERSERKER] = "Brs";
            LANG[(int)E_translate.LANG_COMMON_PROF_ENGINEER] = "Eng";
            LANG[(int)E_translate.LANG_COMMON_PROF_SCRAPPER] = "Scr";
            LANG[(int)E_translate.LANG_COMMON_PROF_RANGER] = "Rgr";
            LANG[(int)E_translate.LANG_COMMON_PROF_DRUID] = "Dru";
            LANG[(int)E_translate.LANG_COMMON_PROF_THIEF] = "Thf";
            LANG[(int)E_translate.LANG_COMMON_PROF_DAREDEVIL] = "Dar";
            LANG[(int)E_translate.LANG_COMMON_PROF_ELEMENTALIST] = "Ele";
            LANG[(int)E_translate.LANG_COMMON_PROF_TEMPEST] = "Tmp";
            LANG[(int)E_translate.LANG_COMMON_PROF_MESMER] = "Mes";
            LANG[(int)E_translate.LANG_COMMON_PROF_CHRONOMANCER] = "Chr";
            LANG[(int)E_translate.LANG_COMMON_PROF_NECROMANCER] = "Nec";
            LANG[(int)E_translate.LANG_COMMON_PROF_REAPER] = "Rea";
            LANG[(int)E_translate.LANG_COMMON_PROF_RECKONER] = "Rev";
            LANG[(int)E_translate.LANG_COMMON_PROF_HERALD] = "Her";
            LANG[(int)E_translate.LANG_COMMON_PROF_FIREBRAND] = "Fbd";
            LANG[(int)E_translate.LANG_COMMON_PROF_SPELLBREAKER] = "Spb";
            LANG[(int)E_translate.LANG_COMMON_PROF_HOLOSMITH] = "Hls";
            LANG[(int)E_translate.LANG_COMMON_PROF_SOULBEAST] = "Slb";
            LANG[(int)E_translate.LANG_COMMON_PROF_DEADEYE] = "Ded";
            LANG[(int)E_translate.LANG_COMMON_PROF_WEAVER] = "Wea";
            LANG[(int)E_translate.LANG_COMMON_PROF_MIRAGE] = "Mir";
            LANG[(int)E_translate.LANG_COMMON_PROF_SCOURGE] = "Scg";
            LANG[(int)E_translate.LANG_COMMON_PROF_RENEGADE] = "Ren";

            /* common: skill itemization */
            LANG[(int)E_translate.LANG_COMMON_SKILLS_ACTIVATIONS] = "activations";
            LANG[(int)E_translate.LANG_COMMON_SKILLS_CANCELS] = "cancels";
            LANG[(int)E_translate.LANG_COMMON_SKILLS_WASTED] = "time wasted";
            LANG[(int)E_translate.LANG_COMMON_SKILLS_HITSCOMPRESS] = "hits (cmprs)";
            LANG[(int)E_translate.LANG_COMMON_SKILLS_HITSTOTAL] = "hits (dmg)";
            LANG[(int)E_translate.LANG_COMMON_SKILLS_NINETY] = "over 90";
            LANG[(int)E_translate.LANG_COMMON_SKILLS_FIFTY] = "under 50";
            LANG[(int)E_translate.LANG_COMMON_SKILLS_MOVING] = "moving";
            LANG[(int)E_translate.LANG_COMMON_SKILLS_FLANG_KING] = "fLANG_king";
            LANG[(int)E_translate.LANG_COMMON_SKILLS_CRITS] = "crit";
            LANG[(int)E_translate.LANG_COMMON_SKILLS_VALUE] = "total";
            LANG[(int)E_translate.LANG_COMMON_SKILLS_MIN] = "min";
            LANG[(int)E_translate.LANG_COMMON_SKILLS_AVG] = "avg";
            LANG[(int)E_translate.LANG_COMMON_SKILLS_MAX] = "max";
            LANG[(int)E_translate.LANG_COMMON_SKILLS_APXDMG] = "apx dmg";
            LANG[(int)E_translate.LANG_COMMON_SKILLS_OVERSTACK] = "overstack";
            LANG[(int)E_translate.LANG_COMMON_SKILLS_NOSKILLS] = "No skills logged";
            LANG[(int)E_translate.LANG_COMMON_SKILLS_REMOVED] = "removed";
            LANG[(int)E_translate.LANG_COMMON_SKILLS_RESISTED] = "resisted";
            LANG[(int)E_translate.LANG_COMMON_SKILLS_GLANG_CE] = "gLANG_ce";
            LANG[(int)E_translate.LANG_COMMON_SKILLS_MISSES] = "misses";
            LANG[(int)E_translate.LANG_COMMON_SKILLS_NOTARGETS] = "No targets logged";

            /* common: skills 2 */
            LANG[(int)E_translate.LANG_COMMON_SKILLS2_NOEVENTS] = "No events";
            LANG[(int)E_translate.LANG_COMMON_SKILLS2_SHIELDED] = "shielded";
            LANG[(int)E_translate.LANG_COMMON_SKILLS2_HITSANY] = "hits (all)";
            LANG[(int)E_translate.LANG_COMMON_SKILLS2_DMGPHYS] = "dmg (phys)";
            LANG[(int)E_translate.LANG_COMMON_SKILLS2_DMGBUFF] = "dmg (buff)";
            LANG[(int)E_translate.LANG_COMMON_SKILLS2_CHANNELED] = "time cast";
            LANG[(int)E_translate.LANG_COMMON_SKILLS2_PROTECTED] = "protected";
            LANG[(int)E_translate.LANG_COMMON_SKILLS2_KILLINGBLOWS] = "killed";
            LANG[(int)E_translate.LANG_COMMON_SKILLS2_DOWNEDS] = "downed";
            LANG[(int)E_translate.LANG_COMMON_SKILLS2_VALUESHIELD] = "shield total";
            LANG[(int)E_translate.LANG_COMMON_SKILLS2_BLOCKS] = "blocks";
            LANG[(int)E_translate.LANG_COMMON_SKILLS2_EVADES] = "evades";
            LANG[(int)E_translate.LANG_COMMON_SKILLS2_ABSORBS] = "absorbs";
            LANG[(int)E_translate.LANG_COMMON_SKILLS2_ZEROES] = "zeroes";

            /* common: custom skills */
            LANG[(int)E_translate.LANG_COMMON_CSK_DODGE] = "Dodge";

            /* panels: dps */
            LANG[(int)E_translate.LANG_PAN_PERSONALDPS_HEADER] = "Self Stats";
            LANG[(int)E_translate.LANG_PAN_PERSONALDPS_DAMAGE] = "damage";
            LANG[(int)E_translate.LANG_PAN_PERSONALDPS_HEALING] = "healing";
            LANG[(int)E_translate.LANG_PAN_PERSONALDPS_HISTLEFT] = "current";
            LANG[(int)E_translate.LANG_PAN_PERSONALDPS_HISTRIGHT] = "current";
            LANG[(int)E_translate.LANG_PAN_PERSONALDPS_SHIELDS] = "barrier";

            /* panels: skills */
            LANG[(int)E_translate.LANG_PAN_PERSONALSKILLS_HEADER] = "Self Skills";

            /* panels: healthbar */
            LANG[(int)E_translate.LANG_PAN_HEALTHBAR_HEADER] = "Healthbar";

            /* panels: chcli */
            LANG[(int)E_translate.LANG_PAN_CHCLI_HEADER] = "Area Stats";
            LANG[(int)E_translate.LANG_PAN_CHCLI_DISABLED] = "Disabled on out-of-party players";
            LANG[(int)E_translate.LANG_PAN_CHCLI_NOPLAYERS] = "No players in range";
            LANG[(int)E_translate.LANG_PAN_CHCLI_HISTLEFT] = "current";
            LANG[(int)E_translate.LANG_PAN_CHCLI_HISTRIGHT] = "current";

            /* panels: summary */
            LANG[(int)E_translate.LANG_PAN_SUMMARY_HEADER] = "Summary";
            LANG[(int)E_translate.LANG_PAN_SUMMARY_CBTTIME] = "combat time";
            LANG[(int)E_translate.LANG_PAN_SUMMARY_ADPSOUT] = "dps out";
            LANG[(int)E_translate.LANG_PAN_SUMMARY_ADPSIN] = "dps in";
            LANG[(int)E_translate.LANG_PAN_SUMMARY_CRITPCT] = "crit";
            LANG[(int)E_translate.LANG_PAN_SUMMARY_NINETYPCT] = "ninety";
            LANG[(int)E_translate.LANG_PAN_SUMMARY_FIFTYPCT] = "fifty";
            LANG[(int)E_translate.LANG_PAN_SUMMARY_MOVINGPCT] = "moving";
            LANG[(int)E_translate.LANG_PAN_SUMMARY_FLANG_KPCT] = "fLANG_k";
            LANG[(int)E_translate.LANG_PAN_SUMMARY_CANCELTIME] = "cancel time";
            LANG[(int)E_translate.LANG_PAN_SUMMARY_RESCOUNT] = "res count";
            LANG[(int)E_translate.LANG_PAN_SUMMARY_RESTIME] = "res time";
            LANG[(int)E_translate.LANG_PAN_SUMMARY_DOWNCOUNT] = "down count";
            LANG[(int)E_translate.LANG_PAN_SUMMARY_CLEANSEDOUT] = "cleanse out";
            LANG[(int)E_translate.LANG_PAN_SUMMARY_STRIPPEDOUT] = "strip out";
            LANG[(int)E_translate.LANG_PAN_SUMMARY_GLANG_CEPCT] = "gLANG_ce";
            LANG[(int)E_translate.LANG_PAN_SUMMARY_EVADES] = "evades";
            LANG[(int)E_translate.LANG_PAN_SUMMARY_INTERRUPTS] = "interrupts";
            LANG[(int)E_translate.LANG_PAN_SUMMARY_MISSES] = "misses";
            LANG[(int)E_translate.LANG_PAN_SUMMARY_DODGE] = "dodges used";
            LANG[(int)E_translate.LANG_PAN_SUMMARY_HIST] = "History";
            LANG[(int)E_translate.LANG_PAN_SUMMARY_SQSHORT1] = "player must be";
            LANG[(int)E_translate.LANG_PAN_SUMMARY_SQSHORT2] = "in party/squad";
            LANG[(int)E_translate.LANG_PAN_SUMMARY_CLEANSEDIN] = "cleanse in";
            LANG[(int)E_translate.LANG_PAN_SUMMARY_STRIPPEDIN] = "strip in";
            LANG[(int)E_translate.LANG_PAN_SUMMARY_DOWNTIME] = "down time";
            LANG[(int)E_translate.LANG_PAN_SUMMARY_CANCELCOUNT] = "cancel count";
            LANG[(int)E_translate.LANG_PAN_SUMMARY_SHIELDPCT] = "shield";
            LANG[(int)E_translate.LANG_PAN_SUMMARY_SHIELDEFF] = "shield eff";
            LANG[(int)E_translate.LANG_PAN_SUMMARY_BLOCKS] = "blocks";
            LANG[(int)E_translate.LANG_PAN_SUMMARY_ABSORBS] = "absorbs";
            LANG[(int)E_translate.LANG_PAN_SUMMARY_CLEANSEDSELF] = "cleanse self";
            LANG[(int)E_translate.LANG_PAN_SUMMARY_DURATION] = "duration";
            LANG[(int)E_translate.LANG_PAN_SUMMARY_INTENSITY] = "intensity";
            LANG[(int)E_translate.LANG_PAN_SUMMARY_PHYS] = "phys";
            LANG[(int)E_translate.LANG_PAN_SUMMARY_COND] = "cond";
            LANG[(int)E_translate.LANG_PAN_SUMMARY_DPSUPTIME] = "dps uptime";
            LANG[(int)E_translate.LANG_PAN_SUMMARY_PROTPCT] = "prot";
            LANG[(int)E_translate.LANG_PAN_SUMMARY_KILLINGBLOWS] = "killed";
            LANG[(int)E_translate.LANG_PAN_SUMMARY_DOWNEDS] = "downed";
            LANG[(int)E_translate.LANG_PAN_SUMMARY_DOWNEDPCT] = "down";
            LANG[(int)E_translate.LANG_PAN_SUMMARY_ZEROES] = "zeroes";
            LANG[(int)E_translate.LANG_PAN_SUMMARY_DEATHCOUNT] = "death count";

            /* panels: logger */
            LANG[(int)E_translate.LANG_PAN_LOGGER_HEADER] = "Log";
            LANG[(int)E_translate.LANG_PAN_LOGGER_HEADER_CBT] = "cbt";
            LANG[(int)E_translate.LANG_PAN_LOGGER_ENG] = "eng";
            LANG[(int)E_translate.LANG_PAN_LOGGER_GME] = "gme";
            LANG[(int)E_translate.LANG_PAN_LOGGER_FILTER] = "filter";
            LANG[(int)E_translate.LANG_PAN_LOGGER_RESQ] = "res.qdep";
            LANG[(int)E_translate.LANG_PAN_LOGGER_CBTQ] = "cbt.qdep";
            LANG[(int)E_translate.LANG_PAN_LOGGER_MBLK] = "m.blks";
            LANG[(int)E_translate.LANG_PAN_LOGGER_MSZ] = "m.sz";
            LANG[(int)E_translate.LANG_PAN_LOGGER_AG] = "lim.ag";
            LANG[(int)E_translate.LANG_PAN_LOGGER_CH] = "lim.ch";
            LANG[(int)E_translate.LANG_PAN_LOGGER_CEA] = "ces";
            LANG[(int)E_translate.LANG_PAN_LOGGER_GRC] = "grc";
            LANG[(int)E_translate.LANG_PAN_LOGGER_SCS] = "cbs";
            LANG[(int)E_translate.LANG_PAN_LOGGER_SCC] = "ccx";
            LANG[(int)E_translate.LANG_PAN_LOGGER_STG] = "tgc";
            LANG[(int)E_translate.LANG_PAN_LOGGER_SAG] = "scr";
            LANG[(int)E_translate.LANG_PAN_LOGGER_RTH] = "rth";
            LANG[(int)E_translate.LANG_PAN_LOGGER_CCS] = "ccs";
            LANG[(int)E_translate.LANG_PAN_LOGGER_HS] = "rs";
            LANG[(int)E_translate.LANG_PAN_LOGGER_UI0] = "ui0";
            LANG[(int)E_translate.LANG_PAN_LOGGER_UI1] = "ui1";
            LANG[(int)E_translate.LANG_PAN_LOGGER_HU] = "ru";
            LANG[(int)E_translate.LANG_PAN_LOGGER_CHANNEL] = "Channel";
            LANG[(int)E_translate.LANG_PAN_LOGGER_SIM] = "sim";
            LANG[(int)E_translate.LANG_PAN_LOGGER_MCI] = "mci";
            LANG[(int)E_translate.LANG_PAN_LOGGER_MCO] = "mco";
            LANG[(int)E_translate.LANG_PAN_LOGGER_LINES] = "lines";
            LANG[(int)E_translate.LANG_PAN_LOGGER_SUPPRESS] = "suppress logging";
            LANG[(int)E_translate.LANG_PAN_LOGGER_PERFTIME] = "perf.time";
            LANG[(int)E_translate.LANG_PAN_LOGGER_PERFUSE] = "perf.use";
            LANG[(int)E_translate.LANG_PAN_LOGGER_EVENTS] = "Events";
            LANG[(int)E_translate.LANG_PAN_LOGGER_CBTSTATECHANGE] = "statechange";
            LANG[(int)E_translate.LANG_PAN_LOGGER_CBTACTIVATION] = "activation";
            LANG[(int)E_translate.LANG_PAN_LOGGER_CBTBUFFREMOVE] = "buffremove";
            LANG[(int)E_translate.LANG_PAN_LOGGER_CBTBUFFAPPLY] = "buffapply";
            LANG[(int)E_translate.LANG_PAN_LOGGER_CBTBUFFDAMAGE] = "buffdamage";
            LANG[(int)E_translate.LANG_PAN_LOGGER_CBTBUFFHEAL] = "buffheal";
            LANG[(int)E_translate.LANG_PAN_LOGGER_CBTDIRECTDAMAGE] = "directdamage";
            LANG[(int)E_translate.LANG_PAN_LOGGER_CBTDIRECTHEAL] = "directheal";
            LANG[(int)E_translate.LANG_PAN_LOGGER_DEBUG] = "Debug";
            LANG[(int)E_translate.LANG_PAN_LOGGER_CBTMINION] = "minion";

            /* panels: metrics */
            LANG[(int)E_translate.LANG_PAN_METRICS_HEADER] = "Metrics";
            LANG[(int)E_translate.LANG_PAN_METRICS_FPS] = "F";
            LANG[(int)E_translate.LANG_PAN_METRICS_PING] = "P";
            LANG[(int)E_translate.LANG_PAN_METRICS_MAPTYPE] = "Map.type";
            LANG[(int)E_translate.LANG_PAN_METRICS_MAPID] = "Map.ID";
            LANG[(int)E_translate.LANG_PAN_METRICS_MAPLV] = "Map.level";
            LANG[(int)E_translate.LANG_PAN_METRICS_BUILDGW] = "B.gw2";
            LANG[(int)E_translate.LANG_PAN_METRICS_BUILDARC] = "B.arc";
            LANG[(int)E_translate.LANG_PAN_METRICS_TICK] = "R";

            /* panels: buffs */
            LANG[(int)E_translate.LANG_PAN_BUFFS_HEADER] = "Buffs";
            LANG[(int)E_translate.LANG_PAN_BUFFS_WARNING] = "WARNING: CPU HEAVY";

            /* panels: detail */
            LANG[(int)E_translate.LANG_PAN_DETAIL_HEADER] = "Detail";
            LANG[(int)E_translate.LANG_PAN_DETAIL_MIN] = "min";
            LANG[(int)E_translate.LANG_PAN_DETAIL_MAX] = "max";
            LANG[(int)E_translate.LANG_PAN_DETAIL_ELAPSED] = "elapsed";
            LANG[(int)E_translate.LANG_PAN_DETAIL_REMOVED] = "Agent doesn't exist";

            /* panels: options */
            LANG[(int)E_translate.LANG_PAN_OPTIONS_HEADER] = "Arcdps Options";
            LANG[(int)E_translate.LANG_PAN_OPTIONS_PANELS] = "Windows";
            LANG[(int)E_translate.LANG_PAN_OPTIONS_SUMMARIES] = "Tooltip";
            LANG[(int)E_translate.LANG_PAN_OPTIONS_BASIC] = "General";
            LANG[(int)E_translate.LANG_PAN_OPTIONS_SM_ADPSOUT] = "dps out";
            LANG[(int)E_translate.LANG_PAN_OPTIONS_SM_ADPSIN] = "dps in";
            LANG[(int)E_translate.LANG_PAN_OPTIONS_SM_BUFFS] = "buffs";
            LANG[(int)E_translate.LANG_PAN_OPTIONS_SM_RATES] = "rates";
            LANG[(int)E_translate.LANG_PAN_OPTIONS_SM_AGSTATES] = "states";
            LANG[(int)E_translate.LANG_PAN_OPTIONS_SM_BUFFEVENTS] = "buff events";
            LANG[(int)E_translate.LANG_PAN_OPTIONS_SM_RESULTS] = "results";
            LANG[(int)E_translate.LANG_PAN_OPTIONS_BS_LOCKTARGET] = "Lock target to encounter NPC";
            LANG[(int)E_translate.LANG_PAN_OPTIONS_BS_SAVELOGS] = "Save EVTC logs after encounters";
            LANG[(int)E_translate.LANG_PAN_OPTIONS_BS_NPCINPATH] = "Use NPC name in EVTC save path";
            LANG[(int)E_translate.LANG_PAN_OPTIONS_BS_COMPRESS] = "Compress logs with PowerShell (Win10)";
            LANG[(int)E_translate.LANG_PAN_OPTIONS_BS_GUILDINPATH] = "Use guild in EVTC save path";
            LANG[(int)E_translate.LANG_PAN_OPTIONS_BS_BGBARS] = "Draw bars";
            LANG[(int)E_translate.LANG_PAN_OPTIONS_BS_PLAYERINPATH] = "Use player name in EVTC save path";
            LANG[(int)E_translate.LANG_PAN_OPTIONS_BS_ALTUIMOVELOCK] = "Moving requires modifiers";
            LANG[(int)E_translate.LANG_PAN_OPTIONS_BS_ALTUICLICKLOCK] = "Clicking requires modifiers (unsupported)";
            LANG[(int)E_translate.LANG_PAN_OPTIONS_BS_LOGGING] = "Logging";
            LANG[(int)E_translate.LANG_PAN_OPTIONS_SM_HIDEZEROBUFFS] = "hide empty buffs";
            LANG[(int)E_translate.LANG_PAN_OPTIONS_BS_FASTCLOSE] = "Esc closes windows";
            LANG[(int)E_translate.LANG_PAN_OPTIONS_BS_LOGS] = "Logs (open folder)";
            LANG[(int)E_translate.LANG_PAN_OPTIONS_BS_CONFIG] = "Config (open folder)";
            LANG[(int)E_translate.LANG_PAN_OPTIONS_BS_STYLE] = "Style";
            LANG[(int)E_translate.LANG_PAN_OPTIONS_BS_COLOURSIMGUI] = "Colours: ImGui";
            LANG[(int)E_translate.LANG_PAN_OPTIONS_BS_COLOURSARC] = "Colours: Arc";
            LANG[(int)E_translate.LANG_PAN_OPTIONS_BS_COLOURSPROF] = "Colours: Profession";
            LANG[(int)E_translate.LANG_PAN_OPTIONS_BS_COLOURSSQUAD] = "Colours: Squad";
            LANG[(int)E_translate.LANG_PAN_OPTIONS_BS_APPEARANCE] = "Appearance";

            /* common assorted out of lazy */
            LANG[(int)E_translate.LANG_COMMON_AS_SUCCESS] = "success";
            LANG[(int)E_translate.LANG_COMMON_AS_FAIL] = "failed";
            LANG[(int)E_translate.LANG_COMMON_AS_PADDING] = "padding";
            LANG[(int)E_translate.LANG_COMMON_AS_BACKGROUND] = "background";
            LANG[(int)E_translate.LANG_COMMON_AS_ONELINE] = "one line";
            LANG[(int)E_translate.LANG_COMMON_AS_ALIGNRIGHT] = "align right";
            LANG[(int)E_translate.LANG_COMMON_AS_RESET] = "Reset";
            LANG[(int)E_translate.LANG_COMMON_AS_TOTAL] = "total";
            LANG[(int)E_translate.LANG_COMMON_AS_CLEAVE] = "cleave";
            LANG[(int)E_translate.LANG_COMMON_AS_TARGET] = "target";
            LANG[(int)E_translate.LANG_COMMON_AS_IN] = "in";
            LANG[(int)E_translate.LANG_COMMON_AS_TITLE] = "title bar";
            LANG[(int)E_translate.LANG_COMMON_AS_NOHISTORY] = "no history";
            LANG[(int)E_translate.LANG_COMMON_AS_AUTOSIZE] = "auto size";
            LANG[(int)E_translate.LANG_COMMON_AS_LISTLENGTH] = "max displayed";
            LANG[(int)E_translate.LANG_COMMON_AS_SCROLLBAR] = "scroll bar";
            LANG[(int)E_translate.LANG_COMMON_AS_FRIENDLY] = "friendly";
            LANG[(int)E_translate.LANG_COMMON_AS_LIST] = "List";
            LANG[(int)E_translate.LANG_COMMON_AS_SKILLS] = "skills";
            LANG[(int)E_translate.LANG_COMMON_AS_TARGETS] = "targets";
            LANG[(int)E_translate.LANG_COMMON_AS_LOG] = "log";
            LANG[(int)E_translate.LANG_COMMON_AS_EXTRAS] = "Extras";
            LANG[(int)E_translate.LANG_COMMON_AS_VERSIONCHECK] = "Check recommended minimum version";
            LANG[(int)E_translate.LANG_COMMON_AS_NOOBLACH] = "Suppress objective achievements";
            LANG[(int)E_translate.LANG_COMMON_AS_NOOBLQUEST] = "Suppress objective quests";
            LANG[(int)E_translate.LANG_COMMON_AS_NOCOMBATTEXT] = "Suppress floating combat text";
            LANG[(int)E_translate.LANG_COMMON_AS_CUR] = "cur";
            LANG[(int)E_translate.LANG_COMMON_AS_REC] = "rec";
            LANG[(int)E_translate.LANG_COMMON_AS_LOGSINVALID] = "Logs will be invalid";
            LANG[(int)E_translate.LANG_COMMON_AS_MAPRELOAD] = "requires map reload";
            LANG[(int)E_translate.LANG_COMMON_AS_NOOBLEVENT] = "Suppress objective events";
            LANG[(int)E_translate.LANG_COMMON_AS_SLOWVATOOLTIP] = "Warning: results unpredictable";
            LANG[(int)E_translate.LANG_COMMON_AS_SLOWVA] = "Slow worldstep when window inactive";
            LANG[(int)E_translate.LANG_COMMON_AS_OPTSEXTRASTOOLTIP] = "Options provided by extras dll";
            LANG[(int)E_translate.LANG_COMMON_AS_SAVEPROFKEYBINDS] = "Save/restore some profession keybinds";
            LANG[(int)E_translate.LANG_COMMON_AS_SAVEPROFKEYBINDSTOOLTIP] = "Automatically load last keybinds on map\nenter, and save on map exit\n(skills group, stow weapon)";
            LANG[(int)E_translate.LANG_COMMON_AS_COMBATTIME] = "combat time";
            LANG[(int)E_translate.LANG_COMMON_AS_SORTDPS] = "sort per second";
            LANG[(int)E_translate.LANG_COMMON_AS_STYLE] = "Style";
            LANG[(int)E_translate.LANG_COMMON_AS_BUFFS] = "buffs";
            LANG[(int)E_translate.LANG_COMMON_AS_SORTTARGET] = "sort vs target";
            LANG[(int)E_translate.LANG_COMMON_AS_DISPLAY] = "Display";
            LANG[(int)E_translate.LANG_COMMON_AS_COLOURSUBGROUP] = "colour by subgroup";
            LANG[(int)E_translate.LANG_COMMON_AS_FORMATTOOLTIP] = "@1: cleave total\r\n@2: cleave per second\n@3: cleave percent\n@4: target total\n@5: target per second\n@6: target percent";
            LANG[(int)E_translate.LANG_COMMON_AS_PLAYERFORMAT] = "stats format";
            LANG[(int)E_translate.LANG_COMMON_AS_DEBUG] = "debug";
            LANG[(int)E_translate.LANG_COMMON_AS_DATA] = "Data";
            LANG[(int)E_translate.LANG_COMMON_AS_LABELS] = "labels";
            LANG[(int)E_translate.LANG_COMMON_AS_NUMBERS] = "index numbers";
            LANG[(int)E_translate.LANG_COMMON_AS_PROF] = "profession";
            LANG[(int)E_translate.LANG_COMMON_AS_TOPSKILLS] = "top skills";
            LANG[(int)E_translate.LANG_COMMON_AS_TOPTARGETS] = "top targets";
            LANG[(int)E_translate.LANG_COMMON_AS_WIDTH] = "window width";
            LANG[(int)E_translate.LANG_COMMON_AS_DAMAGE] = "Damage";
            LANG[(int)E_translate.LANG_COMMON_AS_TAKEN] = "taken";
            LANG[(int)E_translate.LANG_COMMON_AS_TITLEMATCHFRAME] = "use window colour for title bar";
            LANG[(int)E_translate.LANG_COMMON_AS_TITLEFORMATTOOLTIP] = "@1: cleave per second\n@2: cleave total\n@3: target per second\n@4: target total\n@5: target name";
            LANG[(int)E_translate.LANG_COMMON_AS_TITLEFORMAT] = "title bar format";
            LANG[(int)E_translate.LANG_COMMON_AS_INTERVAL] = "interval";
            LANG[(int)E_translate.LANG_COMMON_AS_NAMECHARWIDTH] = "max name length";
            LANG[(int)E_translate.LANG_COMMON_AS_SHOWADVANCEDSTYLEOPTS] = "show advanced style options";
            LANG[(int)E_translate.LANG_COMMON_AS_SHOWADVANCEDSTYLEOPTSINFO] = "Warning: modifying ImGui style\nmay not do what you want it to do.\nThis is unsupported and no layout\ncompatibility is guaranteed";
            LANG[(int)E_translate.LANG_COMMON_AS_SHOWADVANCEDSTYLEOPTSCOL] = "Some colours are hardcoded and\ncannot be changed";
            LANG[(int)E_translate.LANG_COMMON_AS_SHOWADVANCEDSTYLEOPTSPREC] = "Colours defined in config ini\ntake precedence when loaded";
            LANG[(int)E_translate.LANG_COMMON_AS_NAME] = "name";
            LANG[(int)E_translate.LANG_COMMON_AS_NAMECOLPROF] = "name colour using profession";
            LANG[(int)E_translate.LANG_COMMON_AS_NAMECOLSUBGROUP] = "name colour using subgroup";
            LANG[(int)E_translate.LANG_COMMON_AS_SORTSUBGROUP] = "sort by subgroup";
            LANG[(int)E_translate.LANG_COMMON_AS_MEMGW2] = "M.gw2";
            LANG[(int)E_translate.LANG_COMMON_AS_MEMARC] = "M.arc";
            LANG[(int)E_translate.LANG_COMMON_AS_DISTCBT] = "Dist.cbt";
            LANG[(int)E_translate.LANG_COMMON_AS_DISTOOC] = "Dist.ooc";
            LANG[(int)E_translate.LANG_COMMON_AS_TIMECBT] = "Time.cbt";
            LANG[(int)E_translate.LANG_COMMON_AS_TIMEOOC] = "Time.ooc";
            LANG[(int)E_translate.LANG_COMMON_AS_DETAILED] = "detailed";
            LANG[(int)E_translate.LANG_COMMON_AS_SIMDISABLED] = "simulation disabled";
            LANG[(int)E_translate.LANG_COMMON_AS_SORTADV] = "sort advanced";
            LANG[(int)E_translate.LANG_COMMON_AS_SORTADVTOOLTIP] = "Advanced sort options override default\nsort options and player format strings,\nas well as require more CPU";
            LANG[(int)E_translate.LANG_COMMON_AS_SHOWADVANCEDSTYLEOPTSTOOLTIP] = "Changes to default style will\nnot retroactively apply to\nthese. Delete the appearance_ keys\nin the ini to reset";
            LANG[(int)E_translate.LANG_COMMON_AS_HISTORY] = "history";
            LANG[(int)E_translate.LANG_COMMON_AS_SORTADV_ADVANCED] = "Adv";
            LANG[(int)E_translate.LANG_COMMON_AS_SORTADV_FNNONE] = "none";
            LANG[(int)E_translate.LANG_COMMON_AS_SORTADV_FNDOWN] = "downeds";
            LANG[(int)E_translate.LANG_COMMON_AS_SORTADV_FNDOWNPERSIST] = "time between downeds";
            LANG[(int)E_translate.LANG_COMMON_AS_SORTADV_FNDEATH] = "deaths";
            LANG[(int)E_translate.LANG_COMMON_AS_SORTADV_FNDEATHPERSIST] = "time between deaths";
            LANG[(int)E_translate.LANG_COMMON_AS_SORTADV_FNRESCOUNT] = "res count";
            LANG[(int)E_translate.LANG_COMMON_AS_SORTADV_FNRESTIME] = "res time";
            LANG[(int)E_translate.LANG_COMMON_AS_SORTADV_FNCLEANSE] = "cleanses";
            LANG[(int)E_translate.LANG_COMMON_AS_SORTADV_FNSTRIP] = "strips";
            LANG[(int)E_translate.LANG_COMMON_AS_SORTADV_FNDPSOUTNEARPERSIST] = "dps out persist";
            LANG[(int)E_translate.LANG_COMMON_AS_SORTADV_FNDPSINNEARPERSIST] = "dps in persist";
            LANG[(int)E_translate.LANG_COMMON_AS_STATSEXCLUDE] = "stats exclude";
            LANG[(int)E_translate.LANG_COMMON_AS_STATSEXCLUDETOOLTIP] = "Exclusion applies to all area stats\nand details windows, aggregate and skills";
            LANG[(int)E_translate.LANG_COMMON_AS_STATSEXCLUDEACTIVE] = "excl";
            LANG[(int)E_translate.LANG_COMMON_AS_STATSEXCLUDEVSPLAYER] = "vs players";
            LANG[(int)E_translate.LANG_COMMON_AS_STATSEXCLUDEVSNPC] = "vs npcs";
            LANG[(int)E_translate.LANG_COMMON_AS_STATSEXCLUDEVSGADGET] = "vs gadgets";
            LANG[(int)E_translate.LANG_COMMON_AS_STATSEXCLUDEFROMPLAYER] = "from players";
            LANG[(int)E_translate.LANG_COMMON_AS_STATSEXCLUDEFROMNPC] = "from npcs";
            LANG[(int)E_translate.LANG_COMMON_AS_STATSEXCLUDEFROMGADGET] = "from gadgets";
            LANG[(int)E_translate.LANG_COMMON_AS_OPTSBASICTOOLTIP] = "Global interface options";
            LANG[(int)E_translate.LANG_COMMON_AS_OPTSLOGSTOOLTIP] = "Boss encounter logging options";
            LANG[(int)E_translate.LANG_COMMON_AS_OPTSPLAYERTOOLTIP] = "Player tooltips";
            LANG[(int)E_translate.LANG_COMMON_AS_OPTSDISPLAYTOOLTIP] = "Data display";
            LANG[(int)E_translate.LANG_COMMON_AS_OPTSSTYLETOOLTIP] = "Window style";
            LANG[(int)E_translate.LANG_COMMON_AS_PERSISTRESET] = "Reset persistent";
            LANG[(int)E_translate.LANG_COMMON_AS_SORTADV_FNDPSOUTNEARSQUAD] = "squad time dps out";
            LANG[(int)E_translate.LANG_COMMON_AS_SORTADV_FNDPSINNEARSQUAD] = "squad time dps in";
            LANG[(int)E_translate.LANG_COMMON_AS_ALWAYSSHOWWINDOWS] = "Always draw windows";
            LANG[(int)E_translate.LANG_COMMON_AS_PERSISTPARTYRESET] = "Reset persistent on party join/leave";
            LANG[(int)E_translate.LANG_COMMON_AS_PERSISTPROFRESET] = "Reset persistent on prof change";
            LANG[(int)E_translate.LANG_COMMON_AS_DETAILDEFAULT] = "detail default";
            LANG[(int)E_translate.LANG_COMMON_AS_DETAILDEFAULTTOOLTIP] = "Details windows initial settings\nwhen opened from this";
            LANG[(int)E_translate.LANG_COMMON_AS_SAVEWVWLOGS] = "Save EVTC logs on WvW squad combat";
            LANG[(int)E_translate.LANG_COMMON_AS_SAVEWVWLOGSTHRESHOLDMIN] = "Min participants for WvW squad logs";
            LANG[(int)E_translate.LANG_COMMON_AS_SAVEWVWLOGSTHRESHOLDMAX] = "Max participants for WvW squad logs";
            LANG[(int)E_translate.LANG_COMMON_AS_SAVEWVWLOGSTOOLTIP] = "Matches advanced sort squad stats,\nstart on damage event in reporting radius\nof squad center, stop on all members\nout of combat";
            LANG[(int)E_translate.LANG_COMMON_AS_DMGOUT] = "Damage out";
            LANG[(int)E_translate.LANG_COMMON_AS_DMGIN] = "Damage in";
            LANG[(int)E_translate.LANG_COMMON_AS_SAVEWVWLOGSENEMYMIN] = "Min player enemies for WvW squad logs";
            LANG[(int)E_translate.LANG_COMMON_AS_ADVANCEDFUNCOPTS] = "Advanced";
            LANG[(int)E_translate.LANG_COMMON_AS_SHOWADVANCEDFUNCOPTS] = "show advanced function options";
            LANG[(int)E_translate.LANG_COMMON_AS_SHOWADVANCEDFUNCOPTSTOOLTIP] = "Changes may cause crashes\nor not play nice\nwith other applications";
            LANG[(int)E_translate.LANG_COMMON_AS_DRAWCOMPAT] = "Use D3DX9";
            LANG[(int)E_translate.LANG_COMMON_AS_SHOWTARGETINFO] = "show target info";
            LANG[(int)E_translate.LANG_COMMON_AS_TARGETINFOTARGET] = "Target";
            LANG[(int)E_translate.LANG_COMMON_AS_PERSISTBUILDRESET] = "Reset persistent on build change";
            LANG[(int)E_translate.LANG_COMMON_AS_OPTSTIME] = "combat time";
            LANG[(int)E_translate.LANG_COMMON_AS_OPTSTIMETOOLTIP] = "Default combat duration is from combat\nstart to combat end. Changes are applied\nimmediately, no reset.";
            LANG[(int)E_translate.LANG_COMMON_AS_OPTSTIME_USEDMG] = "Use last damage event for combat end";
            LANG[(int)E_translate.LANG_COMMON_AS_DRAWBARS] = "draw bars";
            LANG[(int)E_translate.LANG_COMMON_AS_SUBGROUP] = "subgroup";
            LANG[(int)E_translate.LANG_COMMON_AS_TOPSUBGROUPS] = "top subgroups";
            LANG[(int)E_translate.LANG_COMMON_AS_BUFFTOTAL] = "buffs total";
            LANG[(int)E_translate.LANG_COMMON_AS_MAP_MAPASSETTIMEOUT] = "Map asset timeout";
            LANG[(int)E_translate.LANG_COMMON_AS_MAP_MAPASSETTIMEOUTTOOLTIP] = "Max asset load time before\npop-in (2min WvW WP bug)";
            LANG[(int)E_translate.LANG_COMMON_AS_MAP_MAPTIMEOUT] = "Map timeout";
            LANG[(int)E_translate.LANG_COMMON_AS_MAP_MAPTIMEOUTTOOLTIP] = "Max map load time before\npop-in";
            LANG[(int)E_translate.LANG_COMMON_AS_MAP_MODELTIMEOUT] = "Model timeout";
            LANG[(int)E_translate.LANG_COMMON_AS_MAP_MODELTIMEOUTTOOLTIP] = "Max model load time before\npop-in (agent fashion)";
            LANG[(int)E_translate.LANG_COMMON_AS_MAP] = "Map";





            return LANG;
        }

    

	/* common: professions */
	
    }
}
