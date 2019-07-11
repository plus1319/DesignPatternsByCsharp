using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace Multiton.Sample1
{
    public sealed class Camera
    {
        static ConcurrentDictionary<int, Camera> _cameras =
            new ConcurrentDictionary<int, Camera>(new Dictionary<int, Camera>());
        static object _syncLock = new object();

        private Camera() {}

        public static Camera GetCamera(int cameraCode)
        {
            if (!_cameras.ContainsKey(cameraCode))
                lock (_syncLock)
                    if (!_cameras.ContainsKey(cameraCode))
                        _cameras.GetOrAdd(cameraCode, new Camera());

            return _cameras[cameraCode];
        }

    }
}
