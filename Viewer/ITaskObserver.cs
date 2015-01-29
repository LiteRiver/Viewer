using System;

namespace Viewer {
    public interface ITaskObserver {

        void OnStart();

        void OnView(Uri uri, int index);

        void OnReport(TimeSpan left);

        void OnComplete();
    }
}
