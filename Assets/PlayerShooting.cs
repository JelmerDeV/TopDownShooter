using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {
	AudioSource shot;
	public Projectile projectile;
	public Projectile projectile2;
	public Transform muzzle;
	public Transform muzzle2;
	public float bulletSpeed;
	public float fireRate = 0.4F;
	private float nextFire = 0.0F;
	public float fireRate2 = 0.4F;
	private float nextFire2 = 0.0F;

	void Start (){
		shot = GetComponent (typeof(AudioSource)) as AudioSource;

	}

	void Update()
	{

		if (Input.GetMouseButton (0) && Time.time > nextFire) {
			Shoot ();
			shot.Play ();

		}

		if (Input.GetMouseButton (1) && Time.time > nextFire2) {
			Shoot2 ();
			shot.Play ();

		}

	}
	private void Shoot()
	{
		nextFire = Time.time + fireRate;
		Projectile newProjectile = Instantiate (
			                          projectile,
			                          muzzle.position,
			                          muzzle.rotation) as Projectile;
		newProjectile.SetSpeed (bulletSpeed);
	}

	private void Shoot2()
	{
		nextFire2 = Time.time + fireRate2;
		Projectile newProjectile2 = Instantiate (
			projectile2,
			muzzle2.position,
			muzzle2.rotation) as Projectile;
		newProjectile2.SetSpeed (bulletSpeed);
	}
}
