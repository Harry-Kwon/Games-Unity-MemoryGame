using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SequenceButton : MonoBehaviour
{
	Animation anim;

    // Start is called before the first frame update
    void Start()
    {
		anim = GetComponent<Animation>();
    }

	public void PlayAnimation()
	{
		anim.Play(anim.clip.name);
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
