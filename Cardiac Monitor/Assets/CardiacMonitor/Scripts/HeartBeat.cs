using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Numerics;

public class HeartBeat : MonoBehaviour
{


    //this is the name of the camera that we are using
    public WebCamTexture backCam;
    //these are the sizes oin pixels of the camera
    public int Cwidth, Cheight;
    //samplingfrequency of camera
    public int samplingFrequency ;

    //these are the images on post-traitement
    //COLOR IMAGE
    public Color32[] colImage;

    // window size for the DFT(discrete fourrier transform);
    public int windowSize = 64;

    //brightness obtained for each frame
    public List<double> brightness;
    public List<double> heartBeatRate;
    public double lastHB;

    //line renderer to show points of spectrum
    public LineRenderer linR;

    //input values for the FFT
    double[] X_inputValues;
    double[] Y_inputValues;

    //reference object
    public double f_obtained;
    public Image imFill;

    //transform parameters to draw the heart rate
    double a, b, x0, y0;

    //displaytext
    public Text brtText;

    //peak in fourrier transform
    public int peakIndex = 0;
    
    //this is the time that takes to compute the calculations
    public float computeTime;

    void Start()
    {
        
    }


    //this is the call to the corrutine
    public void startMeasuring()
    {
        //if the camera is not null, set its dimensions
        if (backCam == null)
            backCam = new WebCamTexture(Cwidth, Cheight, samplingFrequency);

        //get the image attached to the gameobject and set the texture of the camera
        //GetComponent<Image>().material.mainTexture = backCam;

        //if it is not playing, set to play
        if (!backCam.isPlaying)
            backCam.Play();

        //re-calculate sizes in case that the originals are not compatible
        Cwidth = backCam.width;
        Cheight = backCam.height;
        samplingFrequency = (int)backCam.requestedFPS;

        //initialize the input values to zeros
        X_inputValues = new double[windowSize];
        Y_inputValues = new double[windowSize];

        //sampling frequency is imposed by the fixedupdate time
        samplingFrequency = (int) (1 / Time.fixedDeltaTime);

        //for initialization, the list is set to zero at the beginning of the chart
        for(int ii=0;ii<windowSize;ii++)
        {
            brightness.Add(0);
        }

        //this is the main corrutine that performs the heartbeat calculation
        StartCoroutine(imageTreatment());
    }

    public void stopMeasuring()
    {
        StopAllCoroutines();
        backCam.Stop();
    }



    /// <summary>
    ///  This corrutine obtains these steps in order:
    ///  1) reads the pixels of the image
    ///  2) obtains the brightness of the image and adds it to the list
    ///  3) calculates the FFT of the brightness
    ///  4) obtains the heart rate frequency
    /// </summary>

    IEnumerator imageTreatment()
    {
        while (true)
        {
            float time0 = Time.fixedTime;
            //only if the camera is playing
            if (backCam.isPlaying)
            {
                
                //get the stored pixels into the colImage 
                colImage = backCam.GetPixels32();

                //loop trough the image
                double TempBrightness = 0;
                for (int ii = 1; ii < Cheight - 1; ii++)
                {
                    for (int jj = 1; jj < Cwidth - 1; jj++)
                    {
                        //matrix index to go from 1D to 2D
                        int indxMatrix = ii * Cwidth + jj;

                        //compute brightness
                        TempBrightness += colImage[indxMatrix].r;

                    }
                }
                //this is the temporal brightness computed in the image
                TempBrightness = TempBrightness /(double) (Cwidth * Cheight);

                //it is then added to the list
                brightness.Add(TempBrightness);

                
                if (brightness.Count > windowSize)
                {
                    //THESE ARE THE INPUT VALUES

                    //this is the window size
                    for (int ii = 0; ii < windowSize; ii++)
                    {
                        //Debug.Log(ii);Y_inputValues = new double[windowSize];
                        X_inputValues[ii] = ii;
                        Y_inputValues[ii] = (brightness[ii + brightness.Count - 1 - windowSize]);
                       
                    }

                                                         
                    //perform complex opterations and set up the arrays
                    Complex[] inputSignal_Time = new Complex[windowSize];
                    Complex[] outputSignal_Freq = new Complex[windowSize];

                    // sample array to complex that will be send to the FFT
                    inputSignal_Time = doubleToComplex(Y_inputValues);


                    //result is the output values once FFT has been applied
                    outputSignal_Freq = FastFourierTransform.FFT(inputSignal_Time,false);

                    
                    double[] outputV = new double[windowSize];
                    //get module of complex number
                    for (int ii = 0; ii < windowSize; ii++)
                    {
                        //Debug.Log(ii);
                        outputV[ii] = (double)Complex.Abs(outputSignal_Freq[ii]);
                    }


                    // find peak only in the first half of the chart
                    // draw in the debug mode the FFT output 
                    double MaxPeak = -1000;
                    peakIndex = 0;

                    // looping in the FFT
                    for (int i = 1; i < outputV.Length/2 - 1; i++)
                    {
                        Debug.DrawLine(new UnityEngine.Vector3((i - 1)*3, (float)outputV[i] + 10, 0), new UnityEngine.Vector3(i*3, (float)outputV[i + 1] + 10, 0), Color.red);

                        // discard very low frequencies i>5
                        if (outputV[i] > MaxPeak && i>5)
                        {
                            MaxPeak = outputV[i];
                            peakIndex = i;
                        }
                    }

                    //obtain the frequency in beats/second using the FFT
                    f_obtained = (double)peakIndex / (double)windowSize * (double)samplingFrequency * 60;

                    //display results
                    brtText.text = "" + Mathf.Round((float)f_obtained);
                    
                    imFill.fillAmount = (float)f_obtained/220;
                }

            }
            yield return new WaitForFixedUpdate();

            float time1 = Time.fixedTime;

            //time that takes this loop to finish
            computeTime=(time1 - time0);
        }

    }

    //stop the camera when quitting application
    private void OnApplicationQuit()
    {
        backCam.Stop();    
    }

    /// <summary>
    /// in the fixed update we draw the input data from the sensor considering only the window of values
    /// </summary>
    void FixedUpdate()
    {

        if (brightness.Count > 0)
        {

            linR.positionCount = windowSize;

            //transform parameters to draw the heart rate
            a = transform.localScale.x;
            b = transform.localScale.y;
            x0 = transform.position.x;
            y0 = transform.position.y;

            
            //maximum value of array
            double max_X = MaxD(X_inputValues);
            double min_X = MinD(X_inputValues);
            double max_Y = MaxD(Y_inputValues);
            double min_Y = MinD(Y_inputValues);

            //drawing factors
            double factorA_X = (x0 + a / 2 - (x0 - a / 2)) / (max_X - min_X + 0.01f);
            double factorB_X = factorA_X * (-min_X) + (x0 - a / 2);
            double factorA_Y = (y0+b/2 - (y0-b/2)) / (max_Y - min_Y + 0.01f);
            double factorB_Y = factorA_Y*(-min_Y) +(y0-b/2);


            //draw using the lineRender
            for (int ii = 0; ii < linR.positionCount; ii++)
            {
                // Debug.Log(ii);
                double xt = X_inputValues[ii]*factorA_X+factorB_X;
                double yt = Y_inputValues[ii]*factorA_Y+factorB_Y;
                
                linR.SetPosition(ii, new UnityEngine.Vector3((float)xt, (float)yt, transform.position.z));
            }
        }
    }





    /// <summary>
    /// maximum and minimum funtions for double arrays
    /// </summary>
    
    public double MaxD(double[] inp)
    {
        double outp = -1e10;

        for (int ii = 0; ii < inp.Length; ii++)
        {
            if (inp[ii]>outp)
            {
                outp = inp[ii];
            }
        }

        return outp;
    }
    
    public double MinD(double[] inp)
    {
        double outp = 1e10;

        for (int ii = 0; ii < inp.Length; ii++)
        {
            if (inp[ii] < outp)
            {
                outp = inp[ii];
            }
        }

        return outp;
    }



    /// <summary>
    /// transforms an array of doubles to an array of real complex numbers
    /// </summary>
    
    public Complex[] doubleToComplex(double[] inp)
    {
        Complex[] outp = new Complex[inp.Length];

        //convert to complex number
        for (int ii = 0; ii < windowSize; ii++)
        {

            outp[ii] = new Complex(inp[ii], 0);
        }

        return outp;
    }

}
