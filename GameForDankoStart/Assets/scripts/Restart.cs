using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public GameObject InputWidth;
    public GameObject InputHeight;
    public GameObject InputColor;
    string errors;

    private void CheckInputWidth()
    {
        if (InputWidth.GetComponent<Text>().text != null)
        {
            int Width;
            if (int.TryParse(InputWidth.GetComponent<Text>().text, out Width))
            {
                if ((Width >= 10) && (Width <= 50))
                {
                    GetConteinerSize.conteinerSizeX = Width;
                }
                else
                {
                    errors += "Разрешен ввод ширины от 10 до 50 ";
                }
            }
            else
            {
                errors += "Введены не целые числа (ширина) ";
            }
        }
    }

    private void CheckInputHeight()
    {
        if (InputHeight.GetComponent<Text>().text != null)
        {
            int Width;
            if (int.TryParse(InputHeight.GetComponent<Text>().text, out Width))
            {
                if ((Width >= 10) && (Width <= 50))
                {
                    GetConteinerSize.conteinerSizeY = Width;
                }
                else
                {
                    errors += "Разрешен ввод высоты от 10 до 50 ";
                }
            }
            else
            {
                errors += "Введены не целые числа (высота) ";
            }
        }
    }

    private void CheckInputColor()
    {
        if (InputColor.GetComponent<Text>().text != null)
        {
            int Width;
            if (int.TryParse(InputColor.GetComponent<Text>().text, out Width))
            {
                if ((Width >= 2) && (Width <= 5))
                {
                    GetConteinerSize.colorCount = Width;
                }
                else
                {
                    errors += "Разрешен ввод цветов от 2 до 5 ";
                }
            }
            else
            {
                errors += "Введены не целые числа (цвета) ";
            }
        }
    }

    public void Button_Start()
    {
        errors = "";
        CheckInputWidth();
        CheckInputHeight();
        CheckInputColor();
        if (errors == "")
        { 
            SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
        }
        else
        {
            Debug.Log(errors);
        }
    }
}
