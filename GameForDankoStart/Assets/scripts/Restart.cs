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
                    errors += "�������� ���� ������ �� 10 �� 50 ";
                }
            }
            else
            {
                errors += "������� �� ����� ����� (������) ";
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
                    errors += "�������� ���� ������ �� 10 �� 50 ";
                }
            }
            else
            {
                errors += "������� �� ����� ����� (������) ";
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
                    errors += "�������� ���� ������ �� 2 �� 5 ";
                }
            }
            else
            {
                errors += "������� �� ����� ����� (�����) ";
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
