using UnityEngine;

public class WallHitParticle : MonoBehaviour {
    
    public float deathDelay = 0.2f;

	void Start () {
        Destroy(gameObject, deathDelay);
	}
}
