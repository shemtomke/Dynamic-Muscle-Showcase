using UnityEngine;
#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem;
#endif

namespace StarterAssets
{
	public class StarterAssetsInputs : MonoBehaviour
	{
		[Header("Character Input Values")]
		public Vector2 move;
		public Vector2 look;
		public bool jump;
		public bool sprint;
		public bool sit;
        public bool sitUps;
        public bool stretch;
		public bool drive;
		public bool kickBall;
		public bool squat;
		public bool jumpingJack;
		public bool plank;
		public bool bicep;
		public bool liftPart;
		public bool pickUpNPlace;
		public bool pikeWalk;
        public bool bowl;
		public bool battle;

        [Header("Movement Settings")]
		public bool analogMovement;

		[Header("Mouse Cursor Settings")]
		public bool cursorLocked = true;
		public bool cursorInputForLook = true;

#if ENABLE_INPUT_SYSTEM
		public void OnMove(InputValue value)
		{
			MoveInput(value.Get<Vector2>());
		}

		public void OnLook(InputValue value)
		{
			if(cursorInputForLook)
			{
				LookInput(value.Get<Vector2>());
			}
		}

		public void OnJump(InputValue value)
		{
			JumpInput(value.isPressed);
		}

		public void OnSprint(InputValue value)
		{
			SprintInput(value.isPressed);
		}

        public void OnSit(InputValue value)
        {
            SitInput(value.isPressed);
        }
        public void OnStretch(InputValue value)
        {
            StretchInput(value.isPressed);
        }
        public void OnJumpingJack(InputValue value)
        {
            JumpingJackInput(value.isPressed);
        }
        public void OnKickBall(InputValue value)
        {
            KickBallInput(value.isPressed);
        }
        public void OnDrive(InputValue value)
        {
            DriveInput(value.isPressed);
        }
        public void OnLiftingPart(InputValue value)
        {
            LiftPartInput(value.isPressed);
        }
        public void OnBicep(InputValue value)
        {
            BicepInput(value.isPressed);
        }
        public void OnPickUpNPlace(InputValue value)
        {
            PickPlaceInput(value.isPressed);
        }
        public void OnPlank(InputValue value)
        {
            PlankInput(value.isPressed);
        }
        public void OnSquat(InputValue value)
        {
            SquatInput(value.isPressed);
        }
        public void OnPikeWalk(InputValue value)
        {
            PikeWalkInput(value.isPressed);
        }
        public void OnSitUps(InputValue value)
        {
            SitupsInput(value.isPressed);
        }
#endif


        public void MoveInput(Vector2 newMoveDirection)
		{
			move = newMoveDirection;
		} 

		public void LookInput(Vector2 newLookDirection)
		{
			look = newLookDirection;
		}

		public void JumpInput(bool newJumpState)
		{
			jump = newJumpState;
		}

		public void SprintInput(bool newSprintState)
		{
			sprint = newSprintState;
		}
        public void SitInput(bool sitButtonPressed)
        {
            if (sitButtonPressed)
            {
                sit = !sit;
            }
        }
        public void StretchInput(bool stretchButtonPressed)
        {
            if (stretchButtonPressed)
            {
                stretch = !stretch;
            }
        }
        public void JumpingJackInput(bool jumpingJackButtonPressed)
        {
            if (jumpingJackButtonPressed)
            {
                jumpingJack = !jumpingJack;
            }
        }
        public void KickBallInput(bool kickBallButtonPressed)
        {
            if (kickBallButtonPressed)
            {
                kickBall = !kickBall;
            }
        }
        public void DriveInput(bool newDriveState)
        {
            if (newDriveState)
            {
                drive = !drive;
            }
        }
        public void SqautInput(bool newSquatState)
        {
            if (newSquatState)
            {
                squat = !squat;
            }
        }
        public void BicepInput(bool newBicepState)
        {
            if (newBicepState)
            {
                bicep = !bicep;
            }
        }
        public void PikeWalkInput(bool newPikeWalkState)
        {
            if (newPikeWalkState)
            {
                pikeWalk = !pikeWalk;
            }
        }
        public void LiftPartInput(bool newLiftPart)
        {
            if (newLiftPart)
            {
                liftPart = !liftPart;
            }
        }
        public void SitupsInput(bool newSitupsState)
        {
            if (newSitupsState)
            {
                sitUps = !sitUps;
            }
        }
        public void SquatInput(bool newSquatState)
        {
            if (newSquatState)
            {
                squat = !squat;
            }
        }
        public void PickPlaceInput(bool pickUpPlaceState)
        {
            if (pickUpPlaceState)
            {
                pickUpNPlace = !pickUpNPlace;
            }
        }
        public void PlankInput(bool newPlankState)
        {
            if (newPlankState)
            {
                plank = !plank;
            }
        }
        private void OnApplicationFocus(bool hasFocus)
		{
			SetCursorState(cursorLocked);
		}

		private void SetCursorState(bool newState)
		{
			Cursor.lockState = newState ? CursorLockMode.Locked : CursorLockMode.None;
		}
	}
	
}