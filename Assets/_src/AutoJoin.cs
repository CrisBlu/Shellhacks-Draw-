using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Alteruna;

public class AutoJoin : CommunicationBridge 
{
  void Start() => Multiplayer.JoinFirstAvailable();
}