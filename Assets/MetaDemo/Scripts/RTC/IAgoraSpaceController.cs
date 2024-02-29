﻿using System;
using UnityEngine;
using Agora.Rtc;

namespace Agora.Spaces
{
    public interface IRTCController
    {
        bool JoinedChannel { get; }
        uint LocalUID { get; }

        event Action<uint> OnOfflineNotify;

        void JoinChannel(string channelName, string userName, Vector3 position);
        void LeaveChannel();
        void MuteCamera(bool mute);
        void MuteMic(bool mute);
        int UpdateRemotePosition(uint uid, RemoteVoicePositionInfo posInfo);
        int UpdateSelfPosition(float[] position, float[] axisForward, float[] axisRight, float[] axisUp);
        void updateSpatialAudioPosition(uint remoteUid, float sourceDistance);
    }
}