using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class objectManager : MonoBehaviour
{
    public GameObject avatarPrefab;
    public AvatarDB avatarDB;
    public int AvatarIndexToUse;

    Image _spriteImage;
    Text _headerText;
    AvatarItem _avatarItem;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newAvatar = GameObject.Instantiate(avatarPrefab, Vector3.zero, Quaternion.identity, GameObject.Find("Canvas").transform);

        _avatarItem = avatarDB.avatars[AvatarIndexToUse];

        _headerText = newAvatar.transform.Find("AvatarName").GetComponent<Text>();
        _headerText.text = _avatarItem.AvatarName; 

        _spriteImage = newAvatar.transform.Find("AvatarPlaceholder").GetComponent<Image>();
        _spriteImage.sprite = _avatarItem.AvatarSprite;
        _spriteImage.name = _avatarItem.AvatarName;
    }
}
