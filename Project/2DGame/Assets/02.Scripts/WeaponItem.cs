﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponItem : PickupItem {

	public int WeaponIndex = 0;

	protected override void Pickup(Collider2D collision)
	{
		collision.GetComponent<Player>().SetWeapon(WeaponIndex);
	}
}