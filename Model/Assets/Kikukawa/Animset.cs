using UnityEngine;

namespace kikukawa.script {
    public class Animset : MonoBehaviour {
        [Header("Animationの発生時間")]
        [SerializeField] float m_Time = 0.1f;
        [Header("検知するAnimator")]
        [SerializeField] Animator[] m_Anims;

        void Update() {
            m_Time -= Time.deltaTime;
            if (m_Time <= 0.0f) {
                for (int i = 0; i < m_Anims.Length; i++) {
                    if (m_Anims[i]) {
                        m_Anims[i].SetBool("Set", true);
                    }
                }
                Destroy(this);
            }            

        }
    }
}