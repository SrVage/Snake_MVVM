using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace View
{
    public class HeadView:MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.GetComponent<TailView>())
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}