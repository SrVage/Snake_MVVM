using UnityEngine;
using ViewModel;

namespace View
{
    public sealed class TailView:MonoBehaviour
    {
        public void Initialize(MoveVM moveVm)
        {
            moveVm.MoveTail += ChangePosition;
        }
        
        private void ChangePosition(Vector3 position)
        {
            transform.position = position;
        }
    }
}