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
            LANG_COMMON_SKILLS_FLANKING,
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
            LANG_COMMON_SKILLS_GLANCE,
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
            LANG_PAN_SUMMARY_FLANKPCT,
            LANG_PAN_SUMMARY_CANCELTIME,
            LANG_PAN_SUMMARY_RESCOUNT,
            LANG_PAN_SUMMARY_RESTIME,
            LANG_PAN_SUMMARY_DOWNCOUNT,
            LANG_PAN_SUMMARY_CLEANSEDOUT,
            LANG_PAN_SUMMARY_STRIPPEDOUT,
            LANG_PAN_SUMMARY_GLANCEPCT,
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

            /* end */
            LANG_END
        };

        public string[] Lvs_()
        {
            string[] lang = new string[2048];
            lang[(int)E_translate.LANG_CORE] = "core";
            lang[(int)E_translate.LANG_COMMON_PROF_GUARDIAN] = "Gdn";
            lang[(int)E_translate.LANG_COMMON_PROF_DRAGONHUNTER] = "Dgh";
            lang[(int)E_translate.LANG_COMMON_PROF_WARRIOR] = "War";
            lang[(int)E_translate.LANG_COMMON_PROF_BERSERKER] = "Brs";
            lang[(int)E_translate.LANG_COMMON_PROF_ENGINEER] = "Eng";
            lang[(int)E_translate.LANG_COMMON_PROF_SCRAPPER] = "Scr";
            lang[(int)E_translate.LANG_COMMON_PROF_RANGER] = "Rgr";
            lang[(int)E_translate.LANG_COMMON_PROF_DRUID] = "Dru";
            lang[(int)E_translate.LANG_COMMON_PROF_THIEF] = "Thf";
            lang[(int)E_translate.LANG_COMMON_PROF_DAREDEVIL] = "Dar";
            lang[(int)E_translate.LANG_COMMON_PROF_ELEMENTALIST] = "Ele";
            lang[(int)E_translate.LANG_COMMON_PROF_TEMPEST] = "Tmp";
            lang[(int)E_translate.LANG_COMMON_PROF_MESMER] = "Mes";
            lang[(int)E_translate.LANG_COMMON_PROF_CHRONOMANCER] = "Chr";
            lang[(int)E_translate.LANG_COMMON_PROF_NECROMANCER] = "Nec";
            lang[(int)E_translate.LANG_COMMON_PROF_REAPER] = "Rea";
            lang[(int)E_translate.LANG_COMMON_PROF_RECKONER] = "Rev";
            lang[(int)E_translate.LANG_COMMON_PROF_HERALD] = "Her";
            lang[(int)E_translate.LANG_COMMON_PROF_FIREBRAND] = "Fbd";
            lang[(int)E_translate.LANG_COMMON_PROF_SPELLBREAKER] = "Spb";
            lang[(int)E_translate.LANG_COMMON_PROF_HOLOSMITH] = "Hls";
            lang[(int)E_translate.LANG_COMMON_PROF_SOULBEAST] = "Slb";
            lang[(int)E_translate.LANG_COMMON_PROF_DEADEYE] = "Ded";
            lang[(int)E_translate.LANG_COMMON_PROF_WEAVER] = "Wea";
            lang[(int)E_translate.LANG_COMMON_PROF_MIRAGE] = "Mir";
            lang[(int)E_translate.LANG_COMMON_PROF_SCOURGE] = "Scg";
            lang[(int)E_translate.LANG_COMMON_PROF_RENEGADE] = "Ren";

            /* common: skill itemization */
            lang[(int)E_translate.LANG_COMMON_SKILLS_ACTIVATIONS] = "activations";
            lang[(int)E_translate.LANG_COMMON_SKILLS_CANCELS] = "cancels";
            lang[(int)E_translate.LANG_COMMON_SKILLS_WASTED] = "time wasted";
            lang[(int)E_translate.LANG_COMMON_SKILLS_HITSCOMPRESS] = "hits (cmprs)";
            lang[(int)E_translate.LANG_COMMON_SKILLS_HITSTOTAL] = "hits (dmg)";
            lang[(int)E_translate.LANG_COMMON_SKILLS_NINETY] = "over 90";
            lang[(int)E_translate.LANG_COMMON_SKILLS_FIFTY] = "under 50";
            lang[(int)E_translate.LANG_COMMON_SKILLS_MOVING] = "moving";
            lang[(int)E_translate.LANG_COMMON_SKILLS_FLANKING] = "flanking";
            lang[(int)E_translate.LANG_COMMON_SKILLS_CRITS] = "crit";
            lang[(int)E_translate.LANG_COMMON_SKILLS_VALUE] = "total";
            lang[(int)E_translate.LANG_COMMON_SKILLS_MIN] = "min";
            lang[(int)E_translate.LANG_COMMON_SKILLS_AVG] = "avg";
            lang[(int)E_translate.LANG_COMMON_SKILLS_MAX] = "max";
            lang[(int)E_translate.LANG_COMMON_SKILLS_APXDMG] = "apx dmg";
            lang[(int)E_translate.LANG_COMMON_SKILLS_OVERSTACK] = "overstack";
            lang[(int)E_translate.LANG_COMMON_SKILLS_NOSKILLS] = "No skills logged";
            lang[(int)E_translate.LANG_COMMON_SKILLS_REMOVED] = "removed";
            lang[(int)E_translate.LANG_COMMON_SKILLS_RESISTED] = "resisted";
            lang[(int)E_translate.LANG_COMMON_SKILLS_GLANCE] = "glance";
            lang[(int)E_translate.LANG_COMMON_SKILLS_MISSES] = "misses";
            lang[(int)E_translate.LANG_COMMON_SKILLS_NOTARGETS] = "No targets logged";

            /* common: skills 2 */
            lang[(int)E_translate.LANG_COMMON_SKILLS2_NOEVENTS] = "No events";
            lang[(int)E_translate.LANG_COMMON_SKILLS2_SHIELDED] = "shielded";
            lang[(int)E_translate.LANG_COMMON_SKILLS2_HITSANY] = "hits (all)";
            lang[(int)E_translate.LANG_COMMON_SKILLS2_DMGPHYS] = "dmg (phys)";
            lang[(int)E_translate.LANG_COMMON_SKILLS2_DMGBUFF] = "dmg (buff)";
            lang[(int)E_translate.LANG_COMMON_SKILLS2_CHANNELED] = "time cast";
            lang[(int)E_translate.LANG_COMMON_SKILLS2_PROTECTED] = "protected";
            lang[(int)E_translate.LANG_COMMON_SKILLS2_KILLINGBLOWS] = "killed";
            lang[(int)E_translate.LANG_COMMON_SKILLS2_DOWNEDS] = "downed";
            lang[(int)E_translate.LANG_COMMON_SKILLS2_VALUESHIELD] = "shield total";
            lang[(int)E_translate.LANG_COMMON_SKILLS2_BLOCKS] = "blocks";
            lang[(int)E_translate.LANG_COMMON_SKILLS2_EVADES] = "evades";
            lang[(int)E_translate.LANG_COMMON_SKILLS2_ABSORBS] = "absorbs";
            lang[(int)E_translate.LANG_COMMON_SKILLS2_ZEROES] = "zeroes";

            /* common: custom skills */
            lang[(int)E_translate.LANG_COMMON_CSK_DODGE] = "Dodge";

            /* panels: dps */
            lang[(int)E_translate.LANG_PAN_PERSONALDPS_HEADER] = "Self Stats";
            lang[(int)E_translate.LANG_PAN_PERSONALDPS_DAMAGE] = "damage";
            lang[(int)E_translate.LANG_PAN_PERSONALDPS_HEALING] = "healing";
            lang[(int)E_translate.LANG_PAN_PERSONALDPS_HISTLEFT] = "current";
            lang[(int)E_translate.LANG_PAN_PERSONALDPS_HISTRIGHT] = "current";
            lang[(int)E_translate.LANG_PAN_PERSONALDPS_SHIELDS] = "barrier";

            /* panels: skills */
            lang[(int)E_translate.LANG_PAN_PERSONALSKILLS_HEADER] = "Self Skills";

            /* panels: healthbar */
            lang[(int)E_translate.LANG_PAN_HEALTHBAR_HEADER] = "Healthbar";

            /* panels: chcli */
            lang[(int)E_translate.LANG_PAN_CHCLI_HEADER] = "Area Stats";
            lang[(int)E_translate.LANG_PAN_CHCLI_DISABLED] = "Disabled on out-of-party players";
            lang[(int)E_translate.LANG_PAN_CHCLI_NOPLAYERS] = "No players in range";
            lang[(int)E_translate.LANG_PAN_CHCLI_HISTLEFT] = "current";
            lang[(int)E_translate.LANG_PAN_CHCLI_HISTRIGHT] = "current";

            /* panels: summary */
            lang[(int)E_translate.LANG_PAN_SUMMARY_HEADER] = "Summary";
            lang[(int)E_translate.LANG_PAN_SUMMARY_CBTTIME] = "combat time";
            lang[(int)E_translate.LANG_PAN_SUMMARY_ADPSOUT] = "dps out";
            lang[(int)E_translate.LANG_PAN_SUMMARY_ADPSIN] = "dps in";
            lang[(int)E_translate.LANG_PAN_SUMMARY_CRITPCT] = "crit";
            lang[(int)E_translate.LANG_PAN_SUMMARY_NINETYPCT] = "ninety";
            lang[(int)E_translate.LANG_PAN_SUMMARY_FIFTYPCT] = "fifty";
            lang[(int)E_translate.LANG_PAN_SUMMARY_MOVINGPCT] = "moving";
            lang[(int)E_translate.LANG_PAN_SUMMARY_FLANKPCT] = "flank";
            lang[(int)E_translate.LANG_PAN_SUMMARY_CANCELTIME] = "cancel time";
            lang[(int)E_translate.LANG_PAN_SUMMARY_RESCOUNT] = "res count";
            lang[(int)E_translate.LANG_PAN_SUMMARY_RESTIME] = "res time";
            lang[(int)E_translate.LANG_PAN_SUMMARY_DOWNCOUNT] = "down count";
            lang[(int)E_translate.LANG_PAN_SUMMARY_CLEANSEDOUT] = "cleanse out";
            lang[(int)E_translate.LANG_PAN_SUMMARY_STRIPPEDOUT] = "strip out";
            lang[(int)E_translate.LANG_PAN_SUMMARY_GLANCEPCT] = "glance";
            lang[(int)E_translate.LANG_PAN_SUMMARY_EVADES] = "evades";
            lang[(int)E_translate.LANG_PAN_SUMMARY_INTERRUPTS] = "interrupts";
            lang[(int)E_translate.LANG_PAN_SUMMARY_MISSES] = "misses";
            lang[(int)E_translate.LANG_PAN_SUMMARY_DODGE] = "dodges used";
            lang[(int)E_translate.LANG_PAN_SUMMARY_HIST] = "History";
            lang[(int)E_translate.LANG_PAN_SUMMARY_SQSHORT1] = "player must be";
            lang[(int)E_translate.LANG_PAN_SUMMARY_SQSHORT2] = "in party/squad";
            lang[(int)E_translate.LANG_PAN_SUMMARY_CLEANSEDIN] = "cleanse in";
            lang[(int)E_translate.LANG_PAN_SUMMARY_STRIPPEDIN] = "strip in";
            lang[(int)E_translate.LANG_PAN_SUMMARY_DOWNTIME] = "down time";
            lang[(int)E_translate.LANG_PAN_SUMMARY_CANCELCOUNT] = "cancel count";
            lang[(int)E_translate.LANG_PAN_SUMMARY_SHIELDPCT] = "shield";
            lang[(int)E_translate.LANG_PAN_SUMMARY_SHIELDEFF] = "shield eff";
            lang[(int)E_translate.LANG_PAN_SUMMARY_BLOCKS] = "blocks";
            lang[(int)E_translate.LANG_PAN_SUMMARY_ABSORBS] = "absorbs";
            lang[(int)E_translate.LANG_PAN_SUMMARY_CLEANSEDSELF] = "cleanse self";
            lang[(int)E_translate.LANG_PAN_SUMMARY_DURATION] = "duration";
            lang[(int)E_translate.LANG_PAN_SUMMARY_INTENSITY] = "intensity";
            lang[(int)E_translate.LANG_PAN_SUMMARY_PHYS] = "phys";
            lang[(int)E_translate.LANG_PAN_SUMMARY_COND] = "cond";
            lang[(int)E_translate.LANG_PAN_SUMMARY_DPSUPTIME] = "dps uptime";
            lang[(int)E_translate.LANG_PAN_SUMMARY_PROTPCT] = "prot";
            lang[(int)E_translate.LANG_PAN_SUMMARY_KILLINGBLOWS] = "killed";
            lang[(int)E_translate.LANG_PAN_SUMMARY_DOWNEDS] = "downed";
            lang[(int)E_translate.LANG_PAN_SUMMARY_DOWNEDPCT] = "down";
            lang[(int)E_translate.LANG_PAN_SUMMARY_ZEROES] = "zeroes";
            lang[(int)E_translate.LANG_PAN_SUMMARY_DEATHCOUNT] = "death count";

            /* panels: logger */
            lang[(int)E_translate.LANG_PAN_LOGGER_HEADER] = "Log";
            lang[(int)E_translate.LANG_PAN_LOGGER_HEADER_CBT] = "cbt";
            lang[(int)E_translate.LANG_PAN_LOGGER_ENG] = "eng";
            lang[(int)E_translate.LANG_PAN_LOGGER_GME] = "gme";
            lang[(int)E_translate.LANG_PAN_LOGGER_FILTER] = "filter";
            lang[(int)E_translate.LANG_PAN_LOGGER_RESQ] = "res.qdep";
            lang[(int)E_translate.LANG_PAN_LOGGER_CBTQ] = "cbt.qdep";
            lang[(int)E_translate.LANG_PAN_LOGGER_MBLK] = "m.blks";
            lang[(int)E_translate.LANG_PAN_LOGGER_MSZ] = "m.sz";
            lang[(int)E_translate.LANG_PAN_LOGGER_AG] = "lim.ag";
            lang[(int)E_translate.LANG_PAN_LOGGER_CH] = "lim.ch";
            lang[(int)E_translate.LANG_PAN_LOGGER_CEA] = "ces";
            lang[(int)E_translate.LANG_PAN_LOGGER_GRC] = "grc";
            lang[(int)E_translate.LANG_PAN_LOGGER_SCS] = "cbs";
            lang[(int)E_translate.LANG_PAN_LOGGER_SCC] = "ccx";
            lang[(int)E_translate.LANG_PAN_LOGGER_STG] = "tgc";
            lang[(int)E_translate.LANG_PAN_LOGGER_SAG] = "scr";
            lang[(int)E_translate.LANG_PAN_LOGGER_RTH] = "rth";
            lang[(int)E_translate.LANG_PAN_LOGGER_CCS] = "ccs";
            lang[(int)E_translate.LANG_PAN_LOGGER_HS] = "rs";
            lang[(int)E_translate.LANG_PAN_LOGGER_UI0] = "ui0";
            lang[(int)E_translate.LANG_PAN_LOGGER_UI1] = "ui1";
            lang[(int)E_translate.LANG_PAN_LOGGER_HU] = "ru";
            lang[(int)E_translate.LANG_PAN_LOGGER_CHANNEL] = "Channel";
            lang[(int)E_translate.LANG_PAN_LOGGER_SIM] = "sim";
            lang[(int)E_translate.LANG_PAN_LOGGER_MCI] = "mci";
            lang[(int)E_translate.LANG_PAN_LOGGER_MCO] = "mco";
            lang[(int)E_translate.LANG_PAN_LOGGER_LINES] = "lines";
            lang[(int)E_translate.LANG_PAN_LOGGER_SUPPRESS] = "suppress logging";
            lang[(int)E_translate.LANG_PAN_LOGGER_PERFTIME] = "perf.time";
            lang[(int)E_translate.LANG_PAN_LOGGER_PERFUSE] = "perf.use";
            lang[(int)E_translate.LANG_PAN_LOGGER_EVENTS] = "Events";
            lang[(int)E_translate.LANG_PAN_LOGGER_CBTSTATECHANGE] = "statechange";
            lang[(int)E_translate.LANG_PAN_LOGGER_CBTACTIVATION] = "activation";
            lang[(int)E_translate.LANG_PAN_LOGGER_CBTBUFFREMOVE] = "buffremove";
            lang[(int)E_translate.LANG_PAN_LOGGER_CBTBUFFAPPLY] = "buffapply";
            lang[(int)E_translate.LANG_PAN_LOGGER_CBTBUFFDAMAGE] = "buffdamage";
            lang[(int)E_translate.LANG_PAN_LOGGER_CBTBUFFHEAL] = "buffheal";
            lang[(int)E_translate.LANG_PAN_LOGGER_CBTDIRECTDAMAGE] = "directdamage";
            lang[(int)E_translate.LANG_PAN_LOGGER_CBTDIRECTHEAL] = "directheal";
            lang[(int)E_translate.LANG_PAN_LOGGER_DEBUG] = "Debug";
            lang[(int)E_translate.LANG_PAN_LOGGER_CBTMINION] = "minion";

            /* panels: metrics */
            lang[(int)E_translate.LANG_PAN_METRICS_HEADER] = "Metrics";
            lang[(int)E_translate.LANG_PAN_METRICS_FPS] = "F";
            lang[(int)E_translate.LANG_PAN_METRICS_PING] = "P";
            lang[(int)E_translate.LANG_PAN_METRICS_MAPTYPE] = "Map.type";
            lang[(int)E_translate.LANG_PAN_METRICS_MAPID] = "Map.ID";
            lang[(int)E_translate.LANG_PAN_METRICS_MAPLV] = "Map.level";
            lang[(int)E_translate.LANG_PAN_METRICS_BUILDGW] = "B.gw2";
            lang[(int)E_translate.LANG_PAN_METRICS_BUILDARC] = "B.arc";
            lang[(int)E_translate.LANG_PAN_METRICS_TICK] = "R";

            /* panels: buffs */
            lang[(int)E_translate.LANG_PAN_BUFFS_HEADER] = "Buffs";
            lang[(int)E_translate.LANG_PAN_BUFFS_WARNING] = "WARNING: CPU HEAVY";

            /* panels: detail */
            lang[(int)E_translate.LANG_PAN_DETAIL_HEADER] = "Detail";
            lang[(int)E_translate.LANG_PAN_DETAIL_MIN] = "min";
            lang[(int)E_translate.LANG_PAN_DETAIL_MAX] = "max";
            lang[(int)E_translate.LANG_PAN_DETAIL_ELAPSED] = "elapsed";
            lang[(int)E_translate.LANG_PAN_DETAIL_REMOVED] = "Agent doesn't exist";

            /* panels: options */
            lang[(int)E_translate.LANG_PAN_OPTIONS_HEADER] = "Arcdps Options";
            lang[(int)E_translate.LANG_PAN_OPTIONS_PANELS] = "Windows";
            lang[(int)E_translate.LANG_PAN_OPTIONS_SUMMARIES] = "Tooltip";
            lang[(int)E_translate.LANG_PAN_OPTIONS_BASIC] = "General";
            lang[(int)E_translate.LANG_PAN_OPTIONS_SM_ADPSOUT] = "dps out";
            lang[(int)E_translate.LANG_PAN_OPTIONS_SM_ADPSIN] = "dps in";
            lang[(int)E_translate.LANG_PAN_OPTIONS_SM_BUFFS] = "buffs";
            lang[(int)E_translate.LANG_PAN_OPTIONS_SM_RATES] = "rates";
            lang[(int)E_translate.LANG_PAN_OPTIONS_SM_AGSTATES] = "states";
            lang[(int)E_translate.LANG_PAN_OPTIONS_SM_BUFFEVENTS] = "buff events";
            lang[(int)E_translate.LANG_PAN_OPTIONS_SM_RESULTS] = "results";
            lang[(int)E_translate.LANG_PAN_OPTIONS_BS_LOCKTARGET] = "Lock target to encounter NPC";
            lang[(int)E_translate.LANG_PAN_OPTIONS_BS_SAVELOGS] = "Save EVTC logs after encounters";
            lang[(int)E_translate.LANG_PAN_OPTIONS_BS_NPCINPATH] = "Use NPC name in EVTC save path";
            lang[(int)E_translate.LANG_PAN_OPTIONS_BS_COMPRESS] = "Compress logs with PowerShell (Win10)";
            lang[(int)E_translate.LANG_PAN_OPTIONS_BS_GUILDINPATH] = "Use guild in EVTC save path";
            lang[(int)E_translate.LANG_PAN_OPTIONS_BS_BGBARS] = "Draw bars";
            lang[(int)E_translate.LANG_PAN_OPTIONS_BS_PLAYERINPATH] = "Use player name in EVTC save path";
            lang[(int)E_translate.LANG_PAN_OPTIONS_BS_ALTUIMOVELOCK] = "Moving requires modifiers";
            lang[(int)E_translate.LANG_PAN_OPTIONS_BS_ALTUICLICKLOCK] = "Clicking requires modifiers (unsupported)";
            lang[(int)E_translate.LANG_PAN_OPTIONS_BS_LOGGING] = "Logging";
            lang[(int)E_translate.LANG_PAN_OPTIONS_SM_HIDEZEROBUFFS] = "hide empty buffs";
            lang[(int)E_translate.LANG_PAN_OPTIONS_BS_FASTCLOSE] = "Esc closes windows";
            lang[(int)E_translate.LANG_PAN_OPTIONS_BS_LOGS] = "Logs (open folder)";
            lang[(int)E_translate.LANG_PAN_OPTIONS_BS_CONFIG] = "Config (open folder)";
            lang[(int)E_translate.LANG_PAN_OPTIONS_BS_STYLE] = "Style";
            lang[(int)E_translate.LANG_PAN_OPTIONS_BS_COLOURSIMGUI] = "Colours: ImGui";
            lang[(int)E_translate.LANG_PAN_OPTIONS_BS_COLOURSARC] = "Colours: Arc";
            lang[(int)E_translate.LANG_PAN_OPTIONS_BS_COLOURSPROF] = "Colours: Profession";
            lang[(int)E_translate.LANG_PAN_OPTIONS_BS_COLOURSSQUAD] = "Colours: Squad";
            lang[(int)E_translate.LANG_PAN_OPTIONS_BS_APPEARANCE] = "Appearance";

            /* common assorted out of lazy */
            lang[(int)E_translate.LANG_COMMON_AS_SUCCESS] = "success";
            lang[(int)E_translate.LANG_COMMON_AS_FAIL] = "failed";
            lang[(int)E_translate.LANG_COMMON_AS_PADDING] = "padding";
            lang[(int)E_translate.LANG_COMMON_AS_BACKGROUND] = "background";
            lang[(int)E_translate.LANG_COMMON_AS_ONELINE] = "one line";
            lang[(int)E_translate.LANG_COMMON_AS_ALIGNRIGHT] = "align right";
            lang[(int)E_translate.LANG_COMMON_AS_RESET] = "Reset";
            lang[(int)E_translate.LANG_COMMON_AS_TOTAL] = "total";
            lang[(int)E_translate.LANG_COMMON_AS_CLEAVE] = "cleave";
            lang[(int)E_translate.LANG_COMMON_AS_TARGET] = "target";
            lang[(int)E_translate.LANG_COMMON_AS_IN] = "in";
            lang[(int)E_translate.LANG_COMMON_AS_TITLE] = "title bar";
            lang[(int)E_translate.LANG_COMMON_AS_NOHISTORY] = "no history";
            lang[(int)E_translate.LANG_COMMON_AS_AUTOSIZE] = "auto size";
            lang[(int)E_translate.LANG_COMMON_AS_LISTLENGTH] = "max displayed";
            lang[(int)E_translate.LANG_COMMON_AS_SCROLLBAR] = "scroll bar";
            lang[(int)E_translate.LANG_COMMON_AS_FRIENDLY] = "friendly";
            lang[(int)E_translate.LANG_COMMON_AS_LIST] = "List";
            lang[(int)E_translate.LANG_COMMON_AS_SKILLS] = "skills";
            lang[(int)E_translate.LANG_COMMON_AS_TARGETS] = "targets";
            lang[(int)E_translate.LANG_COMMON_AS_LOG] = "log";
            lang[(int)E_translate.LANG_COMMON_AS_COMBATTIME] = "combat time";
            lang[(int)E_translate.LANG_COMMON_AS_SORTDPS] = "sort per second";
            lang[(int)E_translate.LANG_COMMON_AS_STYLE] = "Style";
            lang[(int)E_translate.LANG_COMMON_AS_BUFFS] = "buffs";
            lang[(int)E_translate.LANG_COMMON_AS_SORTTARGET] = "sort vs target";
            lang[(int)E_translate.LANG_COMMON_AS_DISPLAY] = "Display";
            lang[(int)E_translate.LANG_COMMON_AS_COLOURSUBGROUP] = "colour by subgroup";
            lang[(int)E_translate.LANG_COMMON_AS_FORMATTOOLTIP] = "@1: cleave total\n@2: cleave per second\n@3: cleave percent\n@4: target total\n@5: target per second\n@6: target percent";
            lang[(int)E_translate.LANG_COMMON_AS_PLAYERFORMAT] = "stats format";
            lang[(int)E_translate.LANG_COMMON_AS_DEBUG] = "debug";
            lang[(int)E_translate.LANG_COMMON_AS_DATA] = "Data";
            lang[(int)E_translate.LANG_COMMON_AS_LABELS] = "labels";
            lang[(int)E_translate.LANG_COMMON_AS_NUMBERS] = "index numbers";
            lang[(int)E_translate.LANG_COMMON_AS_PROF] = "profession";
            lang[(int)E_translate.LANG_COMMON_AS_TOPSKILLS] = "top skills";
            lang[(int)E_translate.LANG_COMMON_AS_TOPTARGETS] = "top targets";
            lang[(int)E_translate.LANG_COMMON_AS_WIDTH] = "window width";
            lang[(int)E_translate.LANG_COMMON_AS_DAMAGE] = "Damage";
            lang[(int)E_translate.LANG_COMMON_AS_TAKEN] = "taken";
            lang[(int)E_translate.LANG_COMMON_AS_TITLEMATCHFRAME] = "use window colour for title bar";
            lang[(int)E_translate.LANG_COMMON_AS_TITLEFORMATTOOLTIP] = "@1: cleave per second\n@2: cleave total\n@3: target per second\n@4: target total\n@5: target name";
            lang[(int)E_translate.LANG_COMMON_AS_TITLEFORMAT] = "title bar format";
            lang[(int)E_translate.LANG_COMMON_AS_INTERVAL] = "interval";
            lang[(int)E_translate.LANG_COMMON_AS_NAMECHARWIDTH] = "max name length";
            lang[(int)E_translate.LANG_COMMON_AS_SHOWADVANCEDSTYLEOPTS] = "show advanced style options";
            lang[(int)E_translate.LANG_COMMON_AS_SHOWADVANCEDSTYLEOPTSINFO] = "Warning: modifying ImGui style\nmay not do what you want it to do.\nThis is unsupported and no layout\ncompatibility is guaranteed";
            lang[(int)E_translate.LANG_COMMON_AS_SHOWADVANCEDSTYLEOPTSCOL] = "Some colours are hardcoded and\ncannot be changed";
            lang[(int)E_translate.LANG_COMMON_AS_SHOWADVANCEDSTYLEOPTSPREC] = "Colours defined in config ini\ntake precedence when loaded";
            lang[(int)E_translate.LANG_COMMON_AS_NAME] = "name";
            lang[(int)E_translate.LANG_COMMON_AS_NAMECOLPROF] = "name colour using profession";
            lang[(int)E_translate.LANG_COMMON_AS_NAMECOLSUBGROUP] = "name colour using subgroup";
            lang[(int)E_translate.LANG_COMMON_AS_SORTSUBGROUP] = "sort by subgroup";
            lang[(int)E_translate.LANG_COMMON_AS_MEMGW2] = "M.gw2";
            lang[(int)E_translate.LANG_COMMON_AS_MEMARC] = "M.arc";
            lang[(int)E_translate.LANG_COMMON_AS_DISTCBT] = "Dist.cbt";
            lang[(int)E_translate.LANG_COMMON_AS_DISTOOC] = "Dist.ooc";
            lang[(int)E_translate.LANG_COMMON_AS_TIMECBT] = "Time.cbt";
            lang[(int)E_translate.LANG_COMMON_AS_TIMEOOC] = "Time.ooc";
            lang[(int)E_translate.LANG_COMMON_AS_DETAILED] = "detailed";
            lang[(int)E_translate.LANG_COMMON_AS_SIMDISABLED] = "simulation disabled";
            lang[(int)E_translate.LANG_COMMON_AS_SORTADV] = "sort advanced";
            lang[(int)E_translate.LANG_COMMON_AS_SORTADVTOOLTIP] = "Advanced sort options override default\nsort options and player format strings,\nas well as require more CPU";
            lang[(int)E_translate.LANG_COMMON_AS_SHOWADVANCEDSTYLEOPTSTOOLTIP] = "Changes to default style will\nnot retroactively apply to\nthese. Delete the appearance_ keys\nin the ini to reset";
            lang[(int)E_translate.LANG_COMMON_AS_HISTORY] = "history";
            lang[(int)E_translate.LANG_COMMON_AS_SORTADV_ADVANCED] = "Adv";
            lang[(int)E_translate.LANG_COMMON_AS_SORTADV_FNNONE] = "none";
            lang[(int)E_translate.LANG_COMMON_AS_SORTADV_FNDOWN] = "downeds";
            lang[(int)E_translate.LANG_COMMON_AS_SORTADV_FNDOWNPERSIST] = "time between downeds";
            lang[(int)E_translate.LANG_COMMON_AS_SORTADV_FNDEATH] = "deaths";
            lang[(int)E_translate.LANG_COMMON_AS_SORTADV_FNDEATHPERSIST] = "time between deaths";
            lang[(int)E_translate.LANG_COMMON_AS_SORTADV_FNRESCOUNT] = "res count";
            lang[(int)E_translate.LANG_COMMON_AS_SORTADV_FNRESTIME] = "res time";
            lang[(int)E_translate.LANG_COMMON_AS_SORTADV_FNCLEANSE] = "cleanses";
            lang[(int)E_translate.LANG_COMMON_AS_SORTADV_FNSTRIP] = "strips";
            lang[(int)E_translate.LANG_COMMON_AS_SORTADV_FNDPSOUTNEARPERSIST] = "dps out persist";
            lang[(int)E_translate.LANG_COMMON_AS_SORTADV_FNDPSINNEARPERSIST] = "dps in persist";
            lang[(int)E_translate.LANG_COMMON_AS_STATSEXCLUDE] = "stats exclude";
            lang[(int)E_translate.LANG_COMMON_AS_STATSEXCLUDETOOLTIP] = "Exclusion applies to all area stats\nand details windows, aggregate and skills";
            lang[(int)E_translate.LANG_COMMON_AS_STATSEXCLUDEACTIVE] = "excl";
            lang[(int)E_translate.LANG_COMMON_AS_STATSEXCLUDEVSPLAYER] = "vs players";
            lang[(int)E_translate.LANG_COMMON_AS_STATSEXCLUDEVSNPC] = "vs npcs";
            lang[(int)E_translate.LANG_COMMON_AS_STATSEXCLUDEVSGADGET] = "vs gadgets";
            lang[(int)E_translate.LANG_COMMON_AS_STATSEXCLUDEFROMPLAYER] = "from players";
            lang[(int)E_translate.LANG_COMMON_AS_STATSEXCLUDEFROMNPC] = "from npcs";
            lang[(int)E_translate.LANG_COMMON_AS_STATSEXCLUDEFROMGADGET] = "from gadgets";
            lang[(int)E_translate.LANG_COMMON_AS_OPTSBASICTOOLTIP] = "Global interface options";
            lang[(int)E_translate.LANG_COMMON_AS_OPTSLOGSTOOLTIP] = "Boss encounter logging options";
            lang[(int)E_translate.LANG_COMMON_AS_OPTSPLAYERTOOLTIP] = "Player tooltips";
            lang[(int)E_translate.LANG_COMMON_AS_OPTSDISPLAYTOOLTIP] = "Data display";
            lang[(int)E_translate.LANG_COMMON_AS_OPTSSTYLETOOLTIP] = "Window style";
            lang[(int)E_translate.LANG_COMMON_AS_PERSISTRESET] = "Reset persistent";
            lang[(int)E_translate.LANG_COMMON_AS_SORTADV_FNDPSOUTNEARSQUAD] = "squad time dps out";
            lang[(int)E_translate.LANG_COMMON_AS_SORTADV_FNDPSINNEARSQUAD] = "squad time dps in";
            lang[(int)E_translate.LANG_COMMON_AS_ALWAYSSHOWWINDOWS] = "Always draw windows";
            lang[(int)E_translate.LANG_COMMON_AS_PERSISTPARTYRESET] = "Reset persistent on party join/leave";
            lang[(int)E_translate.LANG_COMMON_AS_PERSISTPROFRESET] = "Reset persistent on prof change";
            lang[(int)E_translate.LANG_COMMON_AS_DETAILDEFAULT] = "detail default";
            lang[(int)E_translate.LANG_COMMON_AS_DETAILDEFAULTTOOLTIP] = "Details windows initial settings\nwhen opened from this";
            lang[(int)E_translate.LANG_COMMON_AS_SAVEWVWLOGS] = "Save EVTC logs on WvW squad combat";
            lang[(int)E_translate.LANG_COMMON_AS_SAVEWVWLOGSTHRESHOLDMIN] = "Min participants for WvW squad logs";
            lang[(int)E_translate.LANG_COMMON_AS_SAVEWVWLOGSTHRESHOLDMAX] = "Max participants for WvW squad logs";
            lang[(int)E_translate.LANG_COMMON_AS_SAVEWVWLOGSTOOLTIP] = "Matches advanced sort squad stats,\nstart on damage event in reporting radius\nof squad center, stop on all members\nout of combat";
            lang[(int)E_translate.LANG_COMMON_AS_DMGOUT] = "Damage out";
            lang[(int)E_translate.LANG_COMMON_AS_DMGIN] = "Damage in";
            lang[(int)E_translate.LANG_COMMON_AS_SAVEWVWLOGSENEMYMIN] = "Min player enemies for WvW squad logs";
            lang[(int)E_translate.LANG_COMMON_AS_ADVANCEDFUNCOPTS] = "Advanced";
            lang[(int)E_translate.LANG_COMMON_AS_SHOWADVANCEDFUNCOPTS] = "show advanced function options";
            lang[(int)E_translate.LANG_COMMON_AS_SHOWADVANCEDFUNCOPTSTOOLTIP] = "Changes may cause crashes\nor not play nice\nwith other applications";
            lang[(int)E_translate.LANG_COMMON_AS_DRAWCOMPAT] = "Use D3DX9";
            lang[(int)E_translate.LANG_COMMON_AS_SHOWTARGETINFO] = "show target info";
            lang[(int)E_translate.LANG_COMMON_AS_TARGETINFOTARGET] = "Target";
            lang[(int)E_translate.LANG_COMMON_AS_PERSISTBUILDRESET] = "Reset persistent on build change";

            /* ext: templates */
            lang[(int)E_translate.LANG_PAN_TEMPLATES_HEADER] = "Templates";
            lang[(int)E_translate.LANG_PAN_TEMPLATES_LOAD] = "Load";
            lang[(int)E_translate.LANG_PAN_TEMPLATES_SAVE] = "Save";
            lang[(int)E_translate.LANG_PAN_TEMPLATES_SORTNUMBER] = "Sort by number";
            lang[(int)E_translate.LANG_PAN_TEMPLATES_TRAITS] = "Traits";
            lang[(int)E_translate.LANG_PAN_TEMPLATES_GEAR] = "Gear";
            lang[(int)E_translate.LANG_PAN_TEMPLATES_SKILLS] = "Skills";
            lang[(int)E_translate.LANG_PAN_TEMPLATES_LEGENDARY] = "Legendary";
            lang[(int)E_translate.LANG_PAN_TEMPLATES_PVP] = "PvP";
            lang[(int)E_translate.LANG_PAN_TEMPLATES_PREEQUIP] = "Pre-equip avail 2h";
            lang[(int)E_translate.LANG_PAN_TEMPLATES_SORTALPHA] = "Sort alphabetically";
            lang[(int)E_translate.LANG_PAN_TEMPLATES_COPY] = "Copied";
            lang[(int)E_translate.LANG_PAN_TEMPLATES_NAME] = "Name";
            lang[(int)E_translate.LANG_PAN_TEMPLATES_DELETE] = "Delete";
            lang[(int)E_translate.LANG_PAN_TEMPLATES_OVERWRITE] = "Overwrite";
            lang[(int)E_translate.LANG_PAN_TEMPLATES_SAVED] = "Saved";
            lang[(int)E_translate.LANG_PAN_TEMPLATES_LOADING] = "Loading...";
            lang[(int)E_translate.LANG_PAN_TEMPLATES_REDUCEDRATE] = "Map rate restrictions in place (500ms)";
            lang[(int)E_translate.LANG_PAN_TEMPLATES_DISABLED] = "Unavailable";
            lang[(int)E_translate.LANG_PAN_TEMPLATES_CANCEL] = "Cancel";

            /* ext: extras */
            lang[(int)E_translate.LANG_COMMON_AS_EXTRAS] = "Extras";
            lang[(int)E_translate.LANG_COMMON_AS_VERSIONCHECK] = "Check recommended minimum version";
            lang[(int)E_translate.LANG_COMMON_AS_NOOBLACH] = "Suppress objective achievements";
            lang[(int)E_translate.LANG_COMMON_AS_NOOBLQUEST] = "Suppress objective quests";
            lang[(int)E_translate.LANG_COMMON_AS_NOCOMBATTEXT] = "Suppress floating combat text";
            lang[(int)E_translate.LANG_COMMON_AS_CUR] = "cur";
            lang[(int)E_translate.LANG_COMMON_AS_REC] = "rec";
            lang[(int)E_translate.LANG_COMMON_AS_LOGSINVALID] = "Logs will be invalid";
            lang[(int)E_translate.LANG_COMMON_AS_MAPRELOAD] = "requires map reload";
            lang[(int)E_translate.LANG_COMMON_AS_NOOBLEVENT] = "Suppress objective events";
            lang[(int)E_translate.LANG_COMMON_AS_SLOWVATOOLTIP] = "Warning: results unpredictable";
            lang[(int)E_translate.LANG_COMMON_AS_SLOWVA] = "Slow worldstep when window inactive";
            lang[(int)E_translate.LANG_COMMON_AS_OPTSEXTRASTOOLTIP] = "Options provided by extras dll";
            lang[(int)E_translate.LANG_COMMON_AS_SAVEPROFKEYBINDS] = "Save/restore some profession keybinds";
            lang[(int)E_translate.LANG_COMMON_AS_SAVEPROFKEYBINDSTOOLTIP] = "Automatically load last keybinds on map\nenter, and save on map exit\n(skills group, stow weapon)";
            return lang;
        }

    

	/* common: professions */
	
    }
}
