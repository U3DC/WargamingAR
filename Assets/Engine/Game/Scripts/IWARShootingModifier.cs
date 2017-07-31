﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WAR.Game {
	public interface IWARShootingModifier {
		// handler to modify a shooting attack 
		void modifyShootingAttack(out ShootingAttack attack);
	}
}