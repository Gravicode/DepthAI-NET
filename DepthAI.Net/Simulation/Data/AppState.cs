// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace WebviewAppTest
{
    public class AppState
    {
        public event EventHandler<HeadMoveArgs> HeadMoved;

        public void MoveHead(float newHeadPoseRoll,
float newHeadPoseYaw,
            float newHeadPosePitch,
float oldHeadPoseRoll,
float oldHeadPoseYaw,
                float oldHeadPosePitch
)
        {
            HeadMoved?.Invoke(this, new HeadMoveArgs() { newHeadPosePitch = newHeadPosePitch, newHeadPoseRoll = newHeadPoseRoll, newHeadPoseYaw=newHeadPoseYaw,
             oldHeadPosePitch = oldHeadPosePitch, oldHeadPoseRoll= oldHeadPoseRoll, oldHeadPoseYaw = oldHeadPoseYaw});
        }
        public int Counter { get; set; }
    }

    public class HeadMoveArgs:EventArgs
    {
        public float newHeadPoseRoll { get; set; }
        public float newHeadPoseYaw { get; set; }
        public float newHeadPosePitch { get; set; }
        public float oldHeadPoseRoll { get; set; }
        public float oldHeadPoseYaw { get; set; }
        public float oldHeadPosePitch { get; set; }
    }

}
