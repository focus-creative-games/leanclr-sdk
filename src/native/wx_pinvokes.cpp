#include "wx_pinvoke.h"

#include "public/leanclr.hpp"

namespace wx
{
    using namespace leanclr;

#ifdef __EMSCRIPTEN__
    // Declare the external PInvoke function implemented in JavaScript
    extern "C" int32_t my_add(int32_t a, int32_t b);
#else
    int32_t my_add(int32_t a, int32_t b)
    {
        return a + b;
    }
#endif

    RtResultVoid my_add_invoker(metadata::RtManagedMethodPointer, const metadata::RtMethodInfo *, const interp::RtStackObject *params, interp::RtStackObject *ret)
    {
        size_t offset = 0;
        auto a = RuntimeApi::get_argument<int32_t>(params, offset);
        auto b = RuntimeApi::get_argument<int32_t>(params, offset);
        int32_t result = my_add(a, b);
        RuntimeApi::set_return_value<int32_t>(ret, result);
        RET_VOID_OK();
    }

    struct PInvokeRegistration
    {
        const char *name;
        vm::PInvokeFunction func;
        vm::PInvokeInvoker invoker;
    };

    static PInvokeRegistration g_pinvoke_registrations[] = {
        // Add wxWidgets related PInvoke registrations here
        // Example:
        {"[WxAssembly]wx.Class::Method(System.Int32)", (vm::PInvokeFunction)(&my_add), my_add_invoker},
    };

    void initialize_wx_pinvokes()
    {
        for (const auto &reg : g_pinvoke_registrations)
        {
            RuntimeApi::register_pinvoke_func(reg.name, reg.func, reg.invoker);
        }
    }
}