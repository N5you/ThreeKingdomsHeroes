using UnityEngine;
using System.Collections;

public class MusicController : MonoBehaviour {

	private bool isShow;
	private float volume;

	private float timeTick;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		timeTick += Time.deltaTime;
		if (timeTick < 0.5f) {
			if (isShow) {
				audio.volume = Mathf.Lerp(0, volume, timeTick * 2);
			} else {
				audio.volume = Mathf.Lerp(volume, 0, timeTick * 2);
			}
		} else {
			if (isShow) {
				audio.volume = volume;
				Destroy(this);
			} else {
				Destroy(gameObject);
			}
		}
	}

	public void SetInfo(bool isShow, float volume) {

		this.isShow = isShow;
		this.volume = volume;

		if (isShow) {
			audio.volume = 0;
		}
	}
}
