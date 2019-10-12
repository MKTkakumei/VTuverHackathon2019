using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour {
    [SerializeField] Transform m_TG;

	void Update () {
        if (m_TG) {
            transform.LookAt(m_TG);
        }
	}
}
