using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matrix
{
    public int numOfRows;
    public int numOfColumns;
    List<List<int>> matrix;


    void InitializeMatrix()
    {
        matrix = new List<List<int>>();
    }

    public Matrix()
    {
        InitializeMatrix();
    }
    public Matrix(int NumOfRows, int NumOfCols)
    {
        numOfRows = NumOfRows;
        numOfColumns = NumOfCols;
        InitializeMatrix();
        for (int i = 0; i < NumOfRows; i++)
        {
            matrix.Add(new List<int>());
            for (int j = 0; j < NumOfCols; j++)
            {
                matrix[i].Add(0);
            }
        }
    }

    public Matrix(int[,] array)
    {
        SetMatrix(array);
    }

    public void SetMatrix(int[,] array)
    {
        InitializeMatrix();
        numOfRows = array.GetLength(0);
        numOfColumns = array.GetLength(1);
        for (int i = 0; i < numOfRows; i++)
        {
            matrix.Add(new List<int>());
            for (int j = 0; j < numOfColumns; j++)
            {
                matrix[i].Add(array[i,j]);
            }
        }
    }

    public void PrintMatrix()
    {
        string displayMatrix = "";
        for (int i = 0; i < numOfRows; i++)
        {
            matrix.Add(new List<int>());
            for (int j = 0; j < numOfColumns; j++)
            {
                displayMatrix += matrix[i][j] + "   ";

            }
            displayMatrix += '\n';

        }
        Debug.Log(displayMatrix);
        Debug.Log("HelloJe");
    }

    public void SetElement(int r, int c, int v)
    {
        if (r < numOfRows && c < numOfColumns)
        {
            matrix[r][c] = v;
        }
        else
        {
            Debug.Log("Matrix is Smaller");
        }
    }

    public int GetElement(int r, int c)
    {
        if (r < numOfRows && c < numOfColumns)
        {
            return matrix[r][c];
        }
        else
        {
            Debug.Log("Matrix size is smaller");
            return 0;
        }
    }

    public void SetAllElements(int number)
    {
        for (int i = 0; i < numOfRows; i++)
        {
            for (int j = 0; j < numOfColumns; j++)
            {
                matrix[i][j] = number;
            }
        }
    }

    public Matrix Multiply(Matrix toMultiply)
    {
        if (numOfRows == toMultiply.numOfColumns)
        {
            Matrix multipliedMatrix = new Matrix(numOfRows, numOfColumns);
            for (int i = 0; i < numOfRows; i++)
            {
                for (int j = 0; j < numOfColumns; i++)
                {
                    
                }


            }
            return multipliedMatrix;
        }
        
        
    }
}
