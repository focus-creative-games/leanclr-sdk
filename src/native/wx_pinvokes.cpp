

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

    // Wx.Context

    // --- Canvas/CanvasContext P/Invoke ---
#ifdef __EMSCRIPTEN__
    EM_JS(void, console_log_impl, (const uint16_t *msg, size_t length), {
        if (!msg || !length)
            return;
        // 读取 UTF-16 字符串
        let arr = HEAPU16.subarray(msg >> 1, (msg >> 1) + length);
        let jsStr = String.fromCharCode.apply(null, arr);
        console.log(jsStr);
    });
    EM_JS(void, console_err_impl, (const uint16_t *msg, size_t length), {
        if (!msg || !length)
            return;
        // 读取 UTF-16 字符串
        let arr = HEAPU16.subarray(msg >> 1, (msg >> 1) + length);
        let jsStr = String.fromCharCode.apply(null, arr);
        console.error(jsStr);
    });
    EM_JS(int32_t, screen_info_get_screen_width, (), {
        const windowInfo = wx.getWindowInfo ? wx.getWindowInfo() : wx.getSystemInfoSync();

        return windowInfo.screenWidth;
    });

    EM_JS(int32_t, screen_info_get_screen_height, (), {
        const windowInfo = wx.getWindowInfo ? wx.getWindowInfo() : wx.getSystemInfoSync();

        return windowInfo.screenHeight;
    });
    EM_JS(intptr_t, canvas_create_canvas_impl, (), {
        var canvas = wx.createCanvas();
        return Module.pinvokes.get_id_for_object(canvas);
    });

    EM_JS(intptr_t, canvas_get_context_impl, (intptr_t canvasHandle, const uint16_t *ctxName, size_t len), {
        // 读取 UTF-16 字符串
        let arr = HEAPU16.subarray(ctxName >> 1, (ctxName >> 1) + len);
        let name = String.fromCharCode.apply(null, arr);

        var canvas = Module.pinvokes.get_object_by_id(canvasHandle);
        var ctx = canvas.getContext(name);
        return Module.pinvokes.get_id_for_object(ctx);
    });

    EM_JS(void, canvas_context_clear_rect_impl, (intptr_t ctxHandle, double x, double y, double w, double h), {
        let ctx = Module.pinvokes.get_object_by_id(ctxHandle);
        ctx.clearRect(x, y, w, h);
    });
    EM_JS(void, canvas_context_draw_image_impl, (intptr_t ctxHandle, intptr_t imgHandle, double dx, double dy, double dWidth, double dHeight), {
        let ctx = Module.pinvokes.get_object_by_id(ctxHandle);
        let img = Module.pinvokes.get_object_by_id(imgHandle);
        ctx.drawImage(img, dx, dy, dWidth, dHeight);
    });

    EM_JS(void, canvas_context_set_font_impl, (intptr_t ctxHandle, const uint16_t *font, size_t len), {
        let arr = HEAPU16.subarray(font >> 1, (font >> 1) + len);
        let jsFont = String.fromCharCode.apply(null, arr);
        let ctx = Module.pinvokes.get_object_by_id(ctxHandle);
        ctx.font = jsFont;
    });

    EM_JS(void, canvas_context_set_fill_style_impl, (intptr_t ctxHandle, const uint16_t *fillStyle, size_t len), {
        let arr = HEAPU16.subarray(fillStyle >> 1, (fillStyle >> 1) + len);
        let jsFill = String.fromCharCode.apply(null, arr);
        let ctx = Module.pinvokes.get_object_by_id(ctxHandle);
        ctx.fillStyle = jsFill;
    });
    EM_JS(void, canvas_context_fill_text_impl, (intptr_t ctxHandle, const uint16_t *text, size_t len, double x, double y), {
        let arr = HEAPU16.subarray(text >> 1, (text >> 1) + len);
        let jsText = String.fromCharCode.apply(null, arr);
        let ctx = Module.pinvokes.get_object_by_id(ctxHandle);
        ctx.fillText(jsText, x, y);
    });
#else
    void console_log_impl(const uint16_t *msg, size_t length) {}
    void console_err_impl(const uint16_t *msg, size_t length) {}

    int32_t screen_info_get_screen_width() { return 0; }
    int32_t screen_info_get_screen_height() { return 0; }

    intptr_t canvas_create_canvas_impl() { return 0; }
    intptr_t canvas_get_context_impl(intptr_t canvasHandle, const uint16_t *, size_t) { return 0; }

    void canvas_context_clear_rect_impl(intptr_t, double, double, double, double) {}
    void canvas_context_draw_image_impl(intptr_t, intptr_t, double, double, double, double) {}
    void canvas_context_set_font_impl(intptr_t, const uint16_t *, size_t) {}
    void canvas_context_set_fill_style_impl(intptr_t, const uint16_t *, size_t) {}
    void canvas_context_fill_text_impl(intptr_t, const uint16_t *, size_t, double, double) {}
#endif

    void console_log(vm::RtString *msg)
    {
        if (!msg)
        {
            return;
        }
        console_log_impl(vm::String::get_chars_ptr(msg), vm::String::get_length(msg));
    }
    void console_err(vm::RtString *msg)
    {
        if (!msg)
        {
            return;
        }
        console_err_impl(vm::String::get_chars_ptr(msg), vm::String::get_length(msg));
    }
    // impl

    intptr_t canvas_create_canvas()
    {
        return canvas_create_canvas_impl();
    }

    intptr_t canvas_get_context(intptr_t canvasHandle, vm::RtString *ctxName)
    {
        return canvas_get_context_impl(canvasHandle, vm::String::get_chars_ptr(ctxName), vm::String::get_length(ctxName));
    }

    void canvas_context_clear_rect(intptr_t ctxHandle, double x, double y, double w, double h) { canvas_context_clear_rect_impl(ctxHandle, x, y, w, h); }
    void canvas_context_draw_image(intptr_t ctxHandle, intptr_t imgHandle, double dx, double dy, double dWidth, double dHeight) { canvas_context_draw_image_impl(ctxHandle, imgHandle, dx, dy, dWidth, dHeight); }
    void canvas_context_set_font(intptr_t ctxHandle, const uint16_t *font, size_t len) { canvas_context_set_font_impl(ctxHandle, font, len); }
    void canvas_context_set_fill_style(intptr_t ctxHandle, const uint16_t *fillStyle, size_t len) { canvas_context_set_fill_style_impl(ctxHandle, fillStyle, len); }
    void canvas_context_fill_text(intptr_t ctxHandle, const uint16_t *text, size_t len, double x, double y) { canvas_context_fill_text_impl(ctxHandle, text, len, x, y); }

    // invoker

    RtResultVoid console_log_invoker(metadata::RtManagedMethodPointer, const metadata::RtMethodInfo *, const interp::RtStackObject *params, interp::RtStackObject *ret)
    {
        size_t offset = 0;
        auto str_ptr = RuntimeApi::get_argument<vm::RtString *>(params, offset);
        console_log(str_ptr);
        RET_VOID_OK();
    }

    RtResultVoid console_err_invoker(metadata::RtManagedMethodPointer, const metadata::RtMethodInfo *, const interp::RtStackObject *params, interp::RtStackObject *ret)
    {
        size_t offset = 0;
        auto str_ptr = RuntimeApi::get_argument<vm::RtString *>(params, offset);
        console_err(str_ptr);
        RET_VOID_OK();
    }

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

    RtResultVoid canvas_create_canvas_invoker(metadata::RtManagedMethodPointer, const metadata::RtMethodInfo *, const interp::RtStackObject *params, interp::RtStackObject *ret)
    {
        intptr_t canvasHandle = canvas_create_canvas();
        RuntimeApi::set_return_value<intptr_t>(ret, canvasHandle);
        RET_VOID_OK();
    }

    RtResultVoid canvas_get_context_invoker(metadata::RtManagedMethodPointer, const metadata::RtMethodInfo *, const interp::RtStackObject *params, interp::RtStackObject *ret)
    {
        size_t offset = 0;
        intptr_t canvasHandle = RuntimeApi::get_argument<intptr_t>(params, offset);
        auto str = RuntimeApi::get_argument<vm::RtString *>(params, offset);
        intptr_t ctx = canvas_get_context(canvasHandle, str);
        RuntimeApi::set_return_value<intptr_t>(ret, ctx);
        RET_VOID_OK();
    }
    RtResultVoid canvas_context_clear_rect_invoker(metadata::RtManagedMethodPointer, const metadata::RtMethodInfo *, const interp::RtStackObject *params, interp::RtStackObject *ret)
    {
        size_t offset = 0;
        intptr_t ctx = RuntimeApi::get_argument<intptr_t>(params, offset);
        double x = RuntimeApi::get_argument<double>(params, offset);
        double y = RuntimeApi::get_argument<double>(params, offset);
        double w = RuntimeApi::get_argument<double>(params, offset);
        double h = RuntimeApi::get_argument<double>(params, offset);
        canvas_context_clear_rect(ctx, x, y, w, h);
        RET_VOID_OK();
    }
    RtResultVoid canvas_context_draw_image_invoker(metadata::RtManagedMethodPointer, const metadata::RtMethodInfo *, const interp::RtStackObject *params, interp::RtStackObject *ret)
    {
        size_t offset = 0;
        intptr_t ctx = RuntimeApi::get_argument<intptr_t>(params, offset);
        intptr_t img = RuntimeApi::get_argument<intptr_t>(params, offset);
        double dx = RuntimeApi::get_argument<double>(params, offset);
        double dy = RuntimeApi::get_argument<double>(params, offset);
        double dw = RuntimeApi::get_argument<double>(params, offset);
        double dh = RuntimeApi::get_argument<double>(params, offset);
        canvas_context_draw_image(ctx, img, dx, dy, dw, dh);
        RET_VOID_OK();
    }
    RtResultVoid canvas_context_set_font_invoker(metadata::RtManagedMethodPointer, const metadata::RtMethodInfo *, const interp::RtStackObject *params, interp::RtStackObject *ret)
    {
        size_t offset = 0;
        intptr_t ctx = RuntimeApi::get_argument<intptr_t>(params, offset);
        auto str = RuntimeApi::get_argument<vm::RtString *>(params, offset);
        canvas_context_set_font(ctx, vm::String::get_chars_ptr(str), vm::String::get_length(str));
        RET_VOID_OK();
    }
    RtResultVoid canvas_context_set_fill_style_invoker(metadata::RtManagedMethodPointer, const metadata::RtMethodInfo *, const interp::RtStackObject *params, interp::RtStackObject *ret)
    {
        size_t offset = 0;
        intptr_t ctx = RuntimeApi::get_argument<intptr_t>(params, offset);
        auto str = RuntimeApi::get_argument<vm::RtString *>(params, offset);
        canvas_context_set_fill_style(ctx, vm::String::get_chars_ptr(str), vm::String::get_length(str));
        RET_VOID_OK();
    }
    RtResultVoid canvas_context_fill_text_invoker(metadata::RtManagedMethodPointer, const metadata::RtMethodInfo *, const interp::RtStackObject *params, interp::RtStackObject *ret)
    {
        size_t offset = 0;
        intptr_t ctx = RuntimeApi::get_argument<intptr_t>(params, offset);
        auto str = RuntimeApi::get_argument<vm::RtString *>(params, offset);
        double x = RuntimeApi::get_argument<double>(params, offset);
        double y = RuntimeApi::get_argument<double>(params, offset);
        canvas_context_fill_text(ctx, vm::String::get_chars_ptr(str), vm::String::get_length(str), x, y);
        RET_VOID_OK();
    }

    struct PInvokeRegistration
    {
        const char *name;
        vm::PInvokeFunction func;
        vm::PInvokeInvoker invoker;
    };

    static PInvokeRegistration g_pinvoke_registrations[] = {
        {"[WxSdk]Wx.Console::Log", (vm::PInvokeFunction)(&console_log), console_log_invoker},
        {"[WxSdk]Wx.Console::Err", (vm::PInvokeFunction)(&console_err), console_err_invoker},
        // ScreenInfo P/Invoke
        {"[WxSdk]Wx.ScreenInfo::GetScreenWidthInternal", (vm::PInvokeFunction)(&screen_info_get_screen_width), screen_info_get_screen_width_invoker},
        {"[WxSdk]Wx.ScreenInfo::GetScreenHeightInternal", (vm::PInvokeFunction)(&screen_info_get_screen_height), screen_info_get_screen_height_invoker},
        // Canvas/CanvasContext P/Invoke
        {"[WxSdk]Wx.Canvas::CreateCanvasInternal", (vm::PInvokeFunction)(&canvas_create_canvas), canvas_create_canvas_invoker},
        {"[WxSdk]Wx.Canvas::GetContextInternal", (vm::PInvokeFunction)(&canvas_get_context), canvas_get_context_invoker},
        {"[WxSdk]Wx.CanvasContext::ClearRectInternal", (vm::PInvokeFunction)(&canvas_context_clear_rect), canvas_context_clear_rect_invoker},
        {"[WxSdk]Wx.CanvasContext::DrawImageInternal", (vm::PInvokeFunction)(&canvas_context_draw_image), canvas_context_draw_image_invoker},
        {"[WxSdk]Wx.CanvasContext::SetFontInternal", (vm::PInvokeFunction)(&canvas_context_set_font), canvas_context_set_font_invoker},
        {"[WxSdk]Wx.CanvasContext::SetFillStyleInternal", (vm::PInvokeFunction)(&canvas_context_set_fill_style), canvas_context_set_fill_style_invoker},
        {"[WxSdk]Wx.CanvasContext::FillTextInternal", (vm::PInvokeFunction)(&canvas_context_fill_text), canvas_context_fill_text_invoker},
    };

    void initialize_wx_pinvokes()
    {
        for (const auto &reg : g_pinvoke_registrations)
        {
            RuntimeApi::register_pinvoke_func(reg.name, reg.func, reg.invoker);
        }
    }
}