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

public class FsgModel : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FsgModel(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FsgModel obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FsgModel() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          sphinxbasePINVOKE.delete_FsgModel(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FsgModel(string name, LogMath logmath, float lw, int n) : this(sphinxbasePINVOKE.new_FsgModel__SWIG_0(name, LogMath.getCPtr(logmath), lw, n), true) {
  }

  public FsgModel(SWIGTYPE_p_fsg_model_t ptr) : this(sphinxbasePINVOKE.new_FsgModel__SWIG_1(SWIGTYPE_p_fsg_model_t.getCPtr(ptr)), true) {
  }

  public FsgModel(string path, LogMath logmath, float lw) : this(sphinxbasePINVOKE.new_FsgModel__SWIG_2(path, LogMath.getCPtr(logmath), lw), true) {
  }

  public int word_id(string word) {
    int ret = sphinxbasePINVOKE.FsgModel_word_id(swigCPtr, word);
    return ret;
  }

  public int word_add(string word) {
    int ret = sphinxbasePINVOKE.FsgModel_word_add(swigCPtr, word);
    return ret;
  }

  public void trans_add(int src, int dst, int logp, int wid) {
    sphinxbasePINVOKE.FsgModel_trans_add(swigCPtr, src, dst, logp, wid);
  }

  public int null_trans_add(int src, int dst, int logp) {
    int ret = sphinxbasePINVOKE.FsgModel_null_trans_add(swigCPtr, src, dst, logp);
    return ret;
  }

  public int tag_trans_add(int src, int dst, int logp, int wid) {
    int ret = sphinxbasePINVOKE.FsgModel_tag_trans_add(swigCPtr, src, dst, logp, wid);
    return ret;
  }

  public int add_silence(string silword, int state, float silprob) {
    int ret = sphinxbasePINVOKE.FsgModel_add_silence(swigCPtr, silword, state, silprob);
    return ret;
  }

  public int add_alt(string baseword, string altword) {
    int ret = sphinxbasePINVOKE.FsgModel_add_alt(swigCPtr, baseword, altword);
    return ret;
  }

  public void writefile(string path) {
    sphinxbasePINVOKE.FsgModel_writefile(swigCPtr, path);
  }

}

}
