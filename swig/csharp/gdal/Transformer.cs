/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.39
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace OSGeo.GDAL {

using System;
using System.Runtime.InteropServices;

public class Transformer : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;
  protected object swigParentRef;

  protected static object ThisOwn_true() { return null; }
  protected object ThisOwn_false() { return this; }

  public Transformer(IntPtr cPtr, bool cMemoryOwn, object parent) {
    swigCMemOwn = cMemoryOwn;
    swigParentRef = parent;
    swigCPtr = new HandleRef(this, cPtr);
  }

  public static HandleRef getCPtr(Transformer obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }
  public static HandleRef getCPtrAndDisown(Transformer obj, object parent) {
    if (obj != null)
    {
      obj.swigCMemOwn = false;
      obj.swigParentRef = parent;
      return obj.swigCPtr;
    }
    else
    {
      return new HandleRef(null, IntPtr.Zero);
    }
  }
  public static HandleRef getCPtrAndSetReference(Transformer obj, object parent) {
    if (obj != null)
    {
      obj.swigParentRef = parent;
      return obj.swigCPtr;
    }
    else
    {
      return new HandleRef(null, IntPtr.Zero);
    }
  }

  ~Transformer() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        GdalPINVOKE.delete_Transformer(swigCPtr);
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      GC.SuppressFinalize(this);
    }
  }

  public Transformer(Dataset src, Dataset dst, string[] options) : this(GdalPINVOKE.new_Transformer(Dataset.getCPtr(src), Dataset.getCPtr(dst), (options != null)? new GdalPINVOKE.StringListMarshal(options)._ar : null), true, null) {
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
  }

  public int TransformPoint(int bDstToSrc, double[] inout) {
    int ret = GdalPINVOKE.Transformer_TransformPoint__SWIG_0(swigCPtr, bDstToSrc, inout);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int TransformPoint(double[] argout, int bDstToSrc, double x, double y, double z) {
    int ret = GdalPINVOKE.Transformer_TransformPoint__SWIG_1(swigCPtr, argout, bDstToSrc, x, y, z);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int TransformPoints(int bDstToSrc, int nCount, double[] x, double[] y, double[] z, double[] panSuccess) {
    int ret = GdalPINVOKE.Transformer_TransformPoints(swigCPtr, bDstToSrc, nCount, x, y, z, panSuccess);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int TransformGeolocations(Band xBand, Band yBand, Band zBand, Gdal.GDALProgressFuncDelegate callback, string callback_data, string[] options) {
    int ret = GdalPINVOKE.Transformer_TransformGeolocations(swigCPtr, Band.getCPtr(xBand), Band.getCPtr(yBand), Band.getCPtr(zBand), callback, callback_data, (options != null)? new GdalPINVOKE.StringListMarshal(options)._ar : null);
    if (GdalPINVOKE.SWIGPendingException.Pending) throw GdalPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
