﻿// Copyright 2017 Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hamster {

  // String constants used by MechaHamster.
  class StringConstants {

    // Names for Buttons:
    public const string ButtonSave = "Save";
    public const string ButtonLoad = "Load";
    public const string ButtonClear = "Clear";
    public const string ButtonPlay = "Play";
    public const string ButtonMainMenu = "Main Menu";
    public const string ButtonEditor = "Editor";
    public const string ButtonInvite = "Share Map";
    public const string ButtonPlayShared = "Play Shared Map";
    public const string ButtonPlayBonus = "Play Bonus Maps";
    public const string ButtonOkay = "Okay";
    public const string ButtonCancel = "Cancel";
    public const string ButtonMenu = "Menu";
    public const string ButtonAccount = "Account";
    public const string ButtonRetry = "Retry";
    public const string ButtonExit = "Exit";

    // Title screen text:
    public const string TitleText = "MechaHamster!";
    public const string SubTitleText = "The thrilling adventures of Col. Hammy D. Hamster!";
    public const string LabelFetchingUserData = "Fetching User Data";

    // Save/Load screen text:
    public const string LabelSaveMap = "Save Map:";
    public const string LabelSaveBonusMap = "Save Bonus Map:";
    public const string LabelLoadMap = "Load Map:";
    public const string ButtonSaveInNew = "Save as New Map";
    public const string ButtonSaveUpdate = "Save Map";
    public const string LabelName = "Name:";
    public const string LabelMapId = "Map Id:";
    public const string LabelOverwrite = "Overwrite an existing map:";

    // Default names:
    public const string DefaultUserName = "Unnamed User";
    public const string DefaultMapName = "Unnamed Map";
    public const string DefaultMapId = "<<default mapid>>";

    // Level finished screen text:
    public const string FinishedTopText = "Great Job!";

    // Auth:
    //--------------------------

    public const string LabelSignIn = "Sign In!";
    public const string LabelCreateAccount = "Create an Account!";
    public const string LabelAddEmail = "Add an Email!";

    public const string LabelEmail = "Email:";
    public const string LabelPassword = "Password:";
    public const string ButtonSignIn = "Sign in!";
    public const string ButtonCreateAccount = "Create Account!";

    public const string ButtonSignInWithEmail = "Sign In with account";
    public const string ButtonSignInAnonymously = "Sign In Later";

    public const string LabelSigningIn = "Signing In...";

    public const string LabelAnonymousAccount = "You are signed in on an anonymous account.";
    public const string LabelPasswordAccount = "You are signed in to an email/password account.";

    public const string ButtonAddEmailPassword = "Add Email/Password";
    public const string ButtonLogout = "Log out";
    public const string LabelAnonymousWarning = "You are currently using an anonymous account.\n" +
        "If you log out, you will lose anything you have saved.\nAre you sure you want to log out?";

    // Invites:
    //--------------------------
    public const string RemoteConfigInviteTitleText = "invite_title_text";
    public const string DefaultInviteTitleText = "Try out this map I made!";

    public const string RemoteConfigInviteMessageText = "invite_message_text";
    public const string DefaultInviteMessageText = "Try out this map I made for MechaHamster!";

    public const string RemoteConfigInviteCallToActionText = "invite_call_to_action_text";
    public const string DefaultInviteCallToActionText = "Play my map!";

    public const string DefaultInviteDeepLinkUrl = "https://firebase.google.com/?mapid={0}";

    public const string SharedMapUserMessage = "Someone has shared a new map with you!:\n" +
      "{0}\nFind it under 'Shared Maps'!";

    // Remote Config:
    //--------------------------
    public const string RemoteConfigPhysicsGravity = "physics_gravity";

    // Messaging:
    //--------------------------
    // Type of the message being received.
    public const string MessageKeyType = "type";

    // Bonus Map message.
    // Received when a new bonus map is granted.
    // Params:
    // MessageDataMapId, MessageDataMapName
    public const string MessageTypeBonusMap = "bonus_map";

    // A map id being sent.  Usually for a new bonus level.
    public const string MessageDataMapId = "map_id";

    // The plaintext name of the map being sent.  Usually for a new bonus level.
    public const string MessageDataMapName = "map_name";

    public const string BonusMapUserMessage = "You received the bonus map:\n" +
      "{0}\n Play it from the main menu!  Be careful - you can only play it once!";


    // Analytics tags:
    //--------------------------
    // Called when a level is started.
    // Properties:
    // AnalyticsParamMapId : string representing the mapid of the level.
    public const string AnalyticsEventMapStart = "map_start";

    // Analytics properties:
    //--------------------------

    // Specifies a map ID in the database.
    public const string AnalyticsParamMapId = "map_id";

  }
}