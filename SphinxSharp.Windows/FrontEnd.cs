//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Pocketsphinx {

public class FrontEnd : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FrontEnd(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FrontEnd obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FrontEnd() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          sphinxbasePINVOKE.delete_FrontEnd(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FrontEnd(SWIGTYPE_p_fe_t ptr) : this(sphinxbasePINVOKE.new_FrontEnd(SWIGTYPE_p_fe_t.getCPtr(ptr)), true) {
  }

  public int output_size() {
    int ret = sphinxbasePINVOKE.FrontEnd_output_size(swigCPtr);
    return ret;
  }

  public void start_utt() {
    sphinxbasePINVOKE.FrontEnd_start_utt(swigCPtr);
  }

  public int process_utt(SWIGTYPE_p_int16 spch, uint nsamps, SWIGTYPE_p_p_p_mfcc_t cep_block) {
    int ret = sphinxbasePINVOKE.FrontEnd_process_utt(swigCPtr, SWIGTYPE_p_int16.getCPtr(spch), nsamps, SWIGTYPE_p_p_p_mfcc_t.getCPtr(cep_block));
    return ret;
  }

  public int end_utt(SWIGTYPE_p_mfcc_t out_cepvector) {
    int ret = sphinxbasePINVOKE.FrontEnd_end_utt(swigCPtr, SWIGTYPE_p_mfcc_t.getCPtr(out_cepvector));
    return ret;
  }

}

}
