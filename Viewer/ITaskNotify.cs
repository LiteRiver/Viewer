using System;

namespace Viewer {
    public interface ITaskNotify {

        void OnStart();

        void OnView(Uri uri, int index);

        void OnComplete();
    }
}
