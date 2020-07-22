using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class objectManager : MonoBehaviour
{
    public GameObject avatarPrefab;
    public Sprite newImage;
    Image _spriteImage;
    Text _headerText;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newAvatar = GameObject.Instantiate(avatarPrefab, Vector3.zero, Quaternion.identity, GameObject.Find("Canvas").transform);

        string _newName = "Ellis";

        _headerText = newAvatar.transform.Find("AvatarName").GetComponent<Text>();
        _headerText.text = _newName;

        _spriteImage = newAvatar.transform.Find("AvatarPlaceholder").GetComponent<Image>();
        _spriteImage.sprite = newImage;
        _spriteImage.name = _newName;
    }
}
