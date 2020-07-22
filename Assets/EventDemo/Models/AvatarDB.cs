using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AvatarDB", menuName = "Avatar/AvatarDB")]
public class AvatarDB : ScriptableObject
{
    public AvatarItem[] avatars;
}
