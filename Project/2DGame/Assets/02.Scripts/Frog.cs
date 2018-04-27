using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class Frog : Enemy
{
	GroundChecker groundChecker;

	public float JumpForce = 1;


	public override void Setup()
	{
		GetAnimator = GetComponent<Animator>();
		Rigid = GetComponent<Rigidbody2D>();
		groundChecker = GetComponent<GroundChecker>();

		AddState("Idle", new IdleState(this, false));
		AddState("Jump", new JumpState(this, true));

		ChangeState("Idle");
	}

	protected override void FixedUpdate()
	{
		GetAnimator.SetBool("IsGround", groundChecker.IsGround);
		GetAnimator.SetFloat("VelocityY", Rigid.velocity.y);

		base.FixedUpdate();
	}

	



}
