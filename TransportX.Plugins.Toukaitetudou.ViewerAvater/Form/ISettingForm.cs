using Reactive.Bindings;
using System;
using TransportX.Spatial;

namespace TransportX.Plugins.Toukaitetudou.AvaterTest.Form
{
    internal interface ISettingForm
    {
        public event EventHandler Closed;

        public ReactivePropertySlim<float> TransX { get; }
        public ReactivePropertySlim<float> TransY { get; }
        public ReactivePropertySlim<float> TransZ { get; }

        public ReactivePropertySlim<float> QuatX { get; }
        public ReactivePropertySlim<float> QuatY { get; }
        public ReactivePropertySlim<float> QuatZ { get; }
        public ReactivePropertySlim<float> QuatW { get; }

        public ReactivePropertySlim<float> RotateX { get; }
        public ReactivePropertySlim<float> RotateY { get; }
        public ReactivePropertySlim<float> RotateZ { get; }
        public event EventHandler? UpdateToSource;

        public event EventHandler? ApplyEuler;
        public void Show();
        public void Update(in Pose pose, in ChunkOffset chunkOffset);
        public void Close();
    }
}