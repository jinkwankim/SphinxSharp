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

public class NBestIterator : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal NBestIterator(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(NBestIterator obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~NBestIterator() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PocketSphinxPINVOKE.delete_NBestIterator(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_ps_nbest_t ptr {
    set {
      PocketSphinxPINVOKE.NBestIterator_ptr_set(swigCPtr, SWIGTYPE_p_ps_nbest_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = PocketSphinxPINVOKE.NBestIterator_ptr_get(swigCPtr);
      SWIGTYPE_p_ps_nbest_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_ps_nbest_t(cPtr, false);
      return ret;
    } 
  }

  public NBestIterator(SWIGTYPE_p_ps_nbest_t ptr) : this(PocketSphinxPINVOKE.new_NBestIterator(SWIGTYPE_p_ps_nbest_t.getCPtr(ptr)), true) {
  }

}

}
