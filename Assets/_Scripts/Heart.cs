using UnityEngine.UI;
using System;

public class Heart
{
    public static readonly int HeartPiecesPerHeart = 4;

    private const float FillPerHeartPiece = 0.25f;
    private readonly Image _image;
    public Heart(Image image)
    {
        _image = image;
    }

    public int CurrentNumberOfHeartPieces { get { return (int)(_image.fillAmount * HeartPiecesPerHeart); }  }

    public void Replenish(int numberOfHeartPieces)
    {
        if (numberOfHeartPieces < 0)
            throw new ArgumentOutOfRangeException("numberOfHeartPieces must be positive", "numberOfHeartPieces");
        _image.fillAmount += numberOfHeartPieces * FillPerHeartPiece;
    }

    public void Deplete(int numberOfHeartPieces)
    {
        if (numberOfHeartPieces < 0)
            throw new ArgumentOutOfRangeException("numberOfHeartPieces must be positive", "numberOfHeartPieces");
        _image.fillAmount -= numberOfHeartPieces * FillPerHeartPiece;
    }
}
