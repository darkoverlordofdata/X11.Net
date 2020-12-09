using System;
using System.Runtime.InteropServices;

namespace X11
{
   public enum KeySym : long 
   {
        NoSymbol = 0,
        /*
        * TTY function keys, cleverly chosen to map to ASCII, for convenience of
        * programming, but could have been arbitrary (at the cost of lookup
        * tables in client code).
        */

        XK_BackSpace                     = 0xff08,  /* Back space, back char */
        XK_Tab                           = 0xff09,
        XK_Linefeed                      = 0xff0a,  /* Linefeed, LF */
        XK_Clear                         = 0xff0b,
        XK_Return                        = 0xff0d,  /* Return, enter */
        XK_Pause                         = 0xff13,  /* Pause, hold */
        XK_Scroll_Lock                   = 0xff14,
        XK_Sys_Req                       = 0xff15,
        XK_Escape                        = 0xff1b,
        XK_Delete                        = 0xffff,  /* Delete, rubout */



        /* International & multi-key character composition */

        XK_Multi_key                     = 0xff20,  /* Multi-key character compose */
        XK_Codeinput                     = 0xff37,
        XK_SingleCandidate               = 0xff3c,
        XK_MultipleCandidate             = 0xff3d,
        XK_PreviousCandidate             = 0xff3e,

        /* Japanese keyboard support */

        XK_Kanji                         = 0xff21,  /* Kanji, Kanji convert */
        XK_Muhenkan                      = 0xff22,  /* Cancel Conversion */
        XK_Henkan_Mode                   = 0xff23,  /* Start/Stop Conversion */
        XK_Henkan                        = 0xff23,  /* Alias for Henkan_Mode */
        XK_Romaji                        = 0xff24,  /* to Romaji */
        XK_Hiragana                      = 0xff25,  /* to Hiragana */
        XK_Katakana                      = 0xff26,  /* to Katakana */
        XK_Hiragana_Katakana             = 0xff27,  /* Hiragana/Katakana toggle */
        XK_Zenkaku                       = 0xff28,  /* to Zenkaku */
        XK_Hankaku                       = 0xff29,  /* to Hankaku */
        XK_Zenkaku_Hankaku               = 0xff2a,  /* Zenkaku/Hankaku toggle */
        XK_Touroku                       = 0xff2b,  /* Add to Dictionary */
        XK_Massyo                        = 0xff2c,  /* Delete from Dictionary */
        XK_Kana_Lock                     = 0xff2d,  /* Kana Lock */
        XK_Kana_Shift                    = 0xff2e,  /* Kana Shift */
        XK_Eisu_Shift                    = 0xff2f,  /* Alphanumeric Shift */
        XK_Eisu_toggle                   = 0xff30,  /* Alphanumeric toggle */
        XK_Kanji_Bangou                  = 0xff37,  /* Codeinput */
        XK_Zen_Koho                      = 0xff3d,  /* Multiple/All Candidate(s) */
        XK_Mae_Koho                      = 0xff3e,  /* Previous Candidate */

        /* = 0xff31, thru = 0xff3f, are under XK_KOREAN */

        /* Cursor control & motion */

        XK_Home                          = 0xff50,
        XK_Left                          = 0xff51,  /* Move left, left arrow */
        XK_Up                            = 0xff52,  /* Move up, up arrow */
        XK_Right                         = 0xff53,  /* Move right, right arrow */
        XK_Down                          = 0xff54,  /* Move down, down arrow */
        XK_Prior                         = 0xff55,  /* Prior, previous */
        XK_Page_Up                       = 0xff55,
        XK_Next                          = 0xff56,  /* Next */
        XK_Page_Down                     = 0xff56,
        XK_End                           = 0xff57,  /* EOL */
        XK_Begin                         = 0xff58,  /* BOL */


        /* Misc functions */

        XK_Select                        = 0xff60,  /* Select, mark */
        XK_Print                         = 0xff61,
        XK_Execute                       = 0xff62,  /* Execute, run, do */
        XK_Insert                        = 0xff63,  /* Insert, insert here */
        XK_Undo                          = 0xff65,
        XK_Redo                          = 0xff66,  /* Redo, again */
        XK_Menu                          = 0xff67,
        XK_Find                          = 0xff68,  /* Find, search */
        XK_Cancel                        = 0xff69,  /* Cancel, stop, abort, exit */
        XK_Help                          = 0xff6a,  /* Help */
        XK_Break                         = 0xff6b,
        XK_Mode_switch                   = 0xff7e,  /* Character set switch */
        XK_script_switch                 = 0xff7e,  /* Alias for mode_switch */
        XK_Num_Lock                      = 0xff7f,

        /* Keypad functions, keypad numbers cleverly chosen to map to ASCII */

        XK_KP_Space                      = 0xff80,  /* Space */
        XK_KP_Tab                        = 0xff89,
        XK_KP_Enter                      = 0xff8d,  /* Enter */
        XK_KP_F1                         = 0xff91,  /* PF1, KP_A, ... */
        XK_KP_F2                         = 0xff92,
        XK_KP_F3                         = 0xff93,
        XK_KP_F4                         = 0xff94,
        XK_KP_Home                       = 0xff95,
        XK_KP_Left                       = 0xff96,
        XK_KP_Up                         = 0xff97,
        XK_KP_Right                      = 0xff98,
        XK_KP_Down                       = 0xff99,
        XK_KP_Prior                      = 0xff9a,
        XK_KP_Page_Up                    = 0xff9a,
        XK_KP_Next                       = 0xff9b,
        XK_KP_Page_Down                  = 0xff9b,
        XK_KP_End                        = 0xff9c,
        XK_KP_Begin                      = 0xff9d,
        XK_KP_Insert                     = 0xff9e,
        XK_KP_Delete                     = 0xff9f,
        XK_KP_Equal                      = 0xffbd,  /* Equals */
        XK_KP_Multiply                   = 0xffaa,
        XK_KP_Add                        = 0xffab,
        XK_KP_Separator                  = 0xffac,  /* Separator, often comma */
        XK_KP_Subtract                   = 0xffad,
        XK_KP_Decimal                    = 0xffae,
        XK_KP_Divide                     = 0xffaf,

        XK_KP_0                          = 0xffb0,
        XK_KP_1                          = 0xffb1,
        XK_KP_2                          = 0xffb2,
        XK_KP_3                          = 0xffb3,
        XK_KP_4                          = 0xffb4,
        XK_KP_5                          = 0xffb5,
        XK_KP_6                          = 0xffb6,
        XK_KP_7                          = 0xffb7,
        XK_KP_8                          = 0xffb8,
        XK_KP_9                          = 0xffb9,



        /*
        * Auxilliary functions; note the duplicate definitions for left and right
        * function keys;  Sun keyboards and a few other manufactures have such
        * function key groups on the left and/or right sides of the keyboard.
        * We've not found a keyboard with more than 35 function keys total.
        */

        XK_F1                            = 0xffbe,
        XK_F2                            = 0xffbf,
        XK_F3                            = 0xffc0,
        XK_F4                            = 0xffc1,
        XK_F5                            = 0xffc2,
        XK_F6                            = 0xffc3,
        XK_F7                            = 0xffc4,
        XK_F8                            = 0xffc5,
        XK_F9                            = 0xffc6,
        XK_F10                           = 0xffc7,
        XK_F11                           = 0xffc8,
        XK_L1                            = 0xffc8,
        XK_F12                           = 0xffc9,
        XK_L2                            = 0xffc9,
        XK_F13                           = 0xffca,
        XK_L3                            = 0xffca,
        XK_F14                           = 0xffcb,
        XK_L4                            = 0xffcb,
        XK_F15                           = 0xffcc,
        XK_L5                            = 0xffcc,
        XK_F16                           = 0xffcd,
        XK_L6                            = 0xffcd,
        XK_F17                           = 0xffce,
        XK_L7                            = 0xffce,
        XK_F18                           = 0xffcf,
        XK_L8                            = 0xffcf,
        XK_F19                           = 0xffd0,
        XK_L9                            = 0xffd0,
        XK_F20                           = 0xffd1,
        XK_L10                           = 0xffd1,
        XK_F21                           = 0xffd2,
        XK_R1                            = 0xffd2,
        XK_F22                           = 0xffd3,
        XK_R2                            = 0xffd3,
        XK_F23                           = 0xffd4,
        XK_R3                            = 0xffd4,
        XK_F24                           = 0xffd5,
        XK_R4                            = 0xffd5,
        XK_F25                           = 0xffd6,
        XK_R5                            = 0xffd6,
        XK_F26                           = 0xffd7,
        XK_R6                            = 0xffd7,
        XK_F27                           = 0xffd8,
        XK_R7                            = 0xffd8,
        XK_F28                           = 0xffd9,
        XK_R8                            = 0xffd9,
        XK_F29                           = 0xffda,
        XK_R9                            = 0xffda,
        XK_F30                           = 0xffdb,
        XK_R10                           = 0xffdb,
        XK_F31                           = 0xffdc,
        XK_R11                           = 0xffdc,
        XK_F32                           = 0xffdd,
        XK_R12                           = 0xffdd,
        XK_F33                           = 0xffde,
        XK_R13                           = 0xffde,
        XK_F34                           = 0xffdf,
        XK_R14                           = 0xffdf,
        XK_F35                           = 0xffe0,
        XK_R15                           = 0xffe0,

        /* Modifiers */

        XK_Shift_L                       = 0xffe1,  /* Left shift */
        XK_Shift_R                       = 0xffe2,  /* Right shift */
        XK_Control_L                     = 0xffe3,  /* Left control */
        XK_Control_R                     = 0xffe4,  /* Right control */
        XK_Caps_Lock                     = 0xffe5,  /* Caps lock */
        XK_Shift_Lock                    = 0xffe6,  /* Shift lock */

        XK_Meta_L                        = 0xffe7,  /* Left meta */
        XK_Meta_R                        = 0xffe8,  /* Right meta */
        XK_Alt_L                         = 0xffe9,  /* Left alt */
        XK_Alt_R                         = 0xffea,  /* Right alt */
        XK_Super_L                       = 0xffeb,  /* Left super */
        XK_Super_R                       = 0xffec,  /* Right super */
        XK_Hyper_L                       = 0xffed,  /* Left hyper */
        XK_Hyper_R                       = 0xffee,  /* Right hyper */

    }

}