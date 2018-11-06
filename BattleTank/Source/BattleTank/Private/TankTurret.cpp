// Fill out your copyright notice in the Description page of Project Settings.

#include "BattleTank.h"
#include "TankTurret.h"



void UTankTurret::Rotate(float RelativeSpeed)
{
	// Move the barrel the right amount this frame
	// Given a max elevation speed, and the frame time

	RelativeSpeed = FMath::Clamp<float>(RelativeSpeed, -1, +1);

	auto RotateChange = RelativeSpeed * MaxDegreesPerSecond * GetWorld()->DeltaTimeSeconds;
	auto Rotate = RelativeRotation.Yaw + RotateChange;

	SetRelativeRotation(FRotator(0, Rotate, 0));
}
