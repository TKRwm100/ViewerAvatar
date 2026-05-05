using System.Windows.Input;
using TransportX.Input;

namespace TransportX.Plugins.Toukaitetudou.ViewerAvatar.Input
{
    internal class KeyboardInput : IInput
    {

        public bool IsWorld => worldKey.IsPressed;

        public bool IsSpeedShift => speedKey.IsPressed;
        public bool IsLeftMove => leftKey.IsPressed;

        public bool IsRightMove => rightKey.IsPressed;

        public bool IsUpMove => uptKey.IsPressed;

        public bool IsDownMove => downKey.IsPressed;

        public bool IsFowardMove => fowardKey.IsPressed;

        public bool IsBackMove => backKey.IsPressed;

        public bool IsRotateYPlus => rypKey.IsPressed;

        public bool IsRotateYMinus => rymKey.IsPressed;

        public bool IsRotateXPlus => rxpKey.IsPressed;

        public bool IsRotateXMinus => rxmKey.IsPressed;

        public bool IsRotateZPlus => rzpKey.IsPressed;

        public bool IsRotateZMinus => rzmKey.IsPressed;

        public bool IsReset => resetKey.IsPressed;

        public bool IsOpenForm
        {
            get
            {
                if (field)
                {
                    IsOpenForm = false;
                    return true;
                }
                return false;
            }
            private set;
        }


        private readonly KeyObserver resetKey;
        private readonly KeyObserver openFormKey;
        private readonly KeyObserver worldKey;
        private readonly KeyObserver speedKey;
        private readonly KeyObserver leftKey;
        private readonly KeyObserver rightKey;
        private readonly KeyObserver uptKey;
        private readonly KeyObserver downKey;
        private readonly KeyObserver fowardKey;
        private readonly KeyObserver backKey;
        private readonly KeyObserver rypKey;
        private readonly KeyObserver rymKey;
        private readonly KeyObserver rxpKey;
        private readonly KeyObserver rxmKey;
        private readonly KeyObserver rzpKey;
        private readonly KeyObserver rzmKey;

        public KeyboardInput(TransportX.Input.InputManager inputManager)
        {
            resetKey = inputManager.ObserveKey(Key.R);
            openFormKey = inputManager.ObserveKey(Key.Enter);
            openFormKey.Pressed += OpenFormKey_Pressed;
            worldKey = inputManager.ObserveKey(Key.LeftCtrl);
            speedKey = inputManager.ObserveKey(Key.LeftShift);
            leftKey = inputManager.ObserveKey(Key.A);
            rightKey = inputManager.ObserveKey(Key.D);
            uptKey = inputManager.ObserveKey(Key.W);
            downKey = inputManager.ObserveKey(Key.S);
            fowardKey = inputManager.ObserveKey(Key.Q);
            backKey = inputManager.ObserveKey(Key.E);
            rypKey = inputManager.ObserveKey(Key.NumPad6);
            rymKey = inputManager.ObserveKey(Key.NumPad4);
            rxpKey = inputManager.ObserveKey(Key.NumPad2);
            rxmKey = inputManager.ObserveKey(Key.NumPad8);
            rzpKey = inputManager.ObserveKey(Key.NumPad7);
            rzmKey = inputManager.ObserveKey(Key.NumPad9);

        }

        private void OpenFormKey_Pressed(object? sender, System.EventArgs e)
        {
            IsOpenForm = true;
        }
    }
}