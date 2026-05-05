namespace TransportX.Plugins.Toukaitetudou.ViewerAvatar.Input
{
    internal interface IInput
    {
        bool IsReset { get; }
        bool IsOpenForm { get; }
        bool IsWorld { get; }
        bool IsSpeedShift { get; }
        bool IsLeftMove { get; }
        bool IsRightMove { get; }
        bool IsUpMove { get; }
        bool IsDownMove { get; }
        bool IsFowardMove { get; }
        bool IsBackMove { get; }
        bool IsRotateYPlus { get; }
        bool IsRotateYMinus { get; }
        bool IsRotateXPlus { get; }
        bool IsRotateXMinus { get; }
        bool IsRotateZPlus { get; }
        bool IsRotateZMinus { get; }
    }
}