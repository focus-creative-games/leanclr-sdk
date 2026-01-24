#include "wx_pinvoke.h"

#include "public/leanclr.hpp"
#include "vm/rt_string.h"
#include "utils/string_util.h"
#include "utils/string_builder.h"

#ifdef EMSCRIPTEN
#include <emscripten.h>
#else
#define EMSCRIPTEN_KEEPALIVE
#endif

namespace wx
{
    using namespace leanclr;

#ifdef __EMSCRIPTEN__
    EM_JS(void, console_log_impl, (const uint16_t *msg, size_t length), {
        if (!msg || !length)
            return;
        // 读取 UTF-16 字符串
        let arr = HEAPU16.subarray(msg >> 1, (msg >> 1) + length);
        let jsStr = String.fromCharCode.apply(null, arr);
        console.log(jsStr);
    });
#else
    void console_log_impl(const uint16_t *msg, size_t length)
    {
        // native fallback
    }
#endif

    void console_log(vm::RtString *msg)
    {
        if (!msg)
        {
            return;
        }
        // utils::StringBuilder sb;
        // sb.append_utf16_str(vm::String::get_chars_ptr(msg), vm::String::get_length(msg));
        console_log_impl(vm::String::get_chars_ptr(msg), vm::String::get_length(msg));
    }

    RtResultVoid console_log_invoker(metadata::RtManagedMethodPointer, const metadata::RtMethodInfo *, const interp::RtStackObject *params, interp::RtStackObject *ret)
    {
        size_t offset = 0;
        auto str_ptr = RuntimeApi::get_argument<vm::RtString *>(params, offset);
        console_log(str_ptr);
        RET_VOID_OK();
    }

#ifdef __EMSCRIPTEN__
    EM_JS(void, console_err_impl, (const uint16_t *msg, size_t length), {
        if (!msg || !length)
            return;
        // 读取 UTF-16 字符串
        let arr = HEAPU16.subarray(msg >> 1, (msg >> 1) + length);
        let jsStr = String.fromCharCode.apply(null, arr);
        console.error(jsStr);
    });
#else
    void console_err_impl(const uint16_t *msg, size_t length)
    {
        // native fallback
    }
#endif

    void console_err(vm::RtString *msg)
    {
        if (!msg)
        {
            return;
        }
        // utils::StringBuilder sb;
        // sb.append_utf16_str(vm::String::get_chars_ptr(msg), vm::String::get_length(msg));
        console_err_impl(vm::String::get_chars_ptr(msg), vm::String::get_length(msg));
    }

    RtResultVoid console_err_invoker(metadata::RtManagedMethodPointer, const metadata::RtMethodInfo *, const interp::RtStackObject *params, interp::RtStackObject *ret)
    {
        size_t offset = 0;
        auto str_ptr = RuntimeApi::get_argument<vm::RtString *>(params, offset);
        console_err(str_ptr);
        RET_VOID_OK();
    }

#ifdef __EMSCRIPTEN__
    EM_JS(int32_t, screen_info_get_screen_width, (), {
        const windowInfo = wx.getWindowInfo ? wx.getWindowInfo() : wx.getSystemInfoSync();

        return windowInfo.screenWidth;
    });

    EM_JS(int32_t, screen_info_get_screen_height, (), {
        const windowInfo = wx.getWindowInfo ? wx.getWindowInfo() : wx.getSystemInfoSync();

        return windowInfo.screenHeight;
    });
#else
    int32_t screen_info_get_screen_width() { return 0; }
    int32_t screen_info_get_screen_height() { return 0; }
#endif

    RtResultVoid screen_info_get_screen_width_invoker(metadata::RtManagedMethodPointer, const metadata::RtMethodInfo *, const interp::RtStackObject *params, interp::RtStackObject *ret)
    {
        int32_t width = screen_info_get_screen_width();
        RuntimeApi::set_return_value<int32_t>(ret, width);
        RET_VOID_OK();
    }

    RtResultVoid screen_info_get_screen_height_invoker(metadata::RtManagedMethodPointer, const metadata::RtMethodInfo *, const interp::RtStackObject *params, interp::RtStackObject *ret)
    {
        int32_t height = screen_info_get_screen_height();
        RuntimeApi::set_return_value<int32_t>(ret, height);
        RET_VOID_OK();
    }

    struct PInvokeRegistration
    {
        const char *name;
        vm::PInvokeFunction func;
        vm::PInvokeInvoker invoker;
    };

    static PInvokeRegistration g_pinvoke_registrations[] = {
        {"Wx.Console::Log", (vm::PInvokeFunction)(&console_log), console_log_invoker},
        {"[WxSdk]Wx.Console::Err", (vm::PInvokeFunction)(&console_err), console_err_invoker},
        // ScreenInfo P/Invoke
        {"[WxSdk]Wx.ScreenInfo.GetScreenWidthInternal", (vm::PInvokeFunction)(&screen_info_get_screen_width), screen_info_get_screen_width_invoker},
        {"[WxSdk]Wx.ScreenInfo.GetScreenHeightInternal", (vm::PInvokeFunction)(&screen_info_get_screen_height), screen_info_get_screen_height_invoker},
    };

    void initialize_wx_pinvokes()
    {
        for (const auto &reg : g_pinvoke_registrations)
        {
            RuntimeApi::register_pinvoke_func(reg.name, reg.func, reg.invoker);
        }
    }
}