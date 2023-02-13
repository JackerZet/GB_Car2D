using UnityEngine;

namespace Game.InputLogic
{
    internal class InputKeyboardView : BaseInputView
    {
        [SerializeField] private float _inputMultiplier = 1f;

        protected override void Move()
        {
            float axisOffset = Input.GetAxis("Horizontal");
            float moveValue = _speed * _inputMultiplier * Time.deltaTime * axisOffset;

            float abs = Mathf.Abs(moveValue);
            float sign = Mathf.Sign(moveValue);

            if (sign > 0)
                OnRightMove(abs);
            else if (sign < 0)
                OnLeftMove(abs);
        }
    }
}
