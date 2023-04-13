using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    private int m_Int;
    private uint m_UInt;
    private long m_Long;
    private ulong m_ULong;
    private short m_Short;
    private ushort m_UShort;
    private byte m_Byte;
    private float m_Float;
    private double m_Double;
    private decimal m_Decimal;

    private string m_OperationFirst;
    private string m_OperationSecond;
    private string m_OperationThird;
    private string m_OperationFourth;

    [SerializeField] private Button m_ToByteButton;
    [SerializeField] private Button m_ToLongButton;
    [SerializeField] private Button m_ToDoubleButton;
    [SerializeField] private Button m_ToDecimalButton;
    [SerializeField] private Button m_ToStringButton;
    [SerializeField] private Button m_ToFileButton;

    [SerializeField] private TMP_InputField m_FirstText;
    [SerializeField] private TMP_Text m_SecondText;
    [SerializeField] private TMP_Text m_ThirdText;

    private void Start()
    {
        m_ToByteButton.onClick.AddListener(ChangeTypeToByte);
        m_ToLongButton.onClick.AddListener(ChangeTypeToLong);
        m_ToDoubleButton.onClick.AddListener(ChangeTypeToDouble);
        m_ToDecimalButton.onClick.AddListener(ChangeTypeToDecimal);
        m_ToStringButton.onClick.AddListener(AddToString);
        m_ToFileButton.onClick.AddListener(CreateFile);
    }
    private void ChangeTypeToByte()
    {
        m_UShort = ushort.Parse(m_FirstText.text);
        m_OperationFirst = m_SecondText.text = ((byte)m_UShort).ToString();
    }

    private void ChangeTypeToLong()
    {
        m_Int = int.Parse(m_FirstText.text);
        m_OperationSecond = m_SecondText.text = ((long)m_Int).ToString();
    }

    private void ChangeTypeToDouble()
    {
        m_Float = float.Parse(m_FirstText.text);
        m_OperationThird = m_SecondText.text = ((double)m_Float).ToString();
    }

    private void ChangeTypeToDecimal()
    {
        m_Double = double.Parse(m_FirstText.text);
        m_OperationFourth = m_SecondText.text = ((decimal)m_Double).ToString();
    }

    private void AddToString()
    {
        m_ThirdText.text = $"short {m_UShort} "  + m_OperationFirst + "\n" +
                           $"int {m_Int} " + m_OperationSecond + "\n" +
                           $"float {m_Float} " + m_OperationThird + "\n" +
                           $"double {m_Double} "  + m_OperationFourth;

    }

    private void CreateFile()
    {
        File.WriteAllText("Assets/file.txt", m_ThirdText.text);
    }
}

