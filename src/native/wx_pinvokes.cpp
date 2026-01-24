
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

    EM_JS(void, canvas_set_width_impl, (intptr_t canvasHandle, int32_t width), {
        let canvas = Module.pinvokes.get_object_by_id(canvasHandle);
        canvas.width = width;
    });

    EM_JS(void, canvas_set_height_impl, (intptr_t canvasHandle, int32_t height), {
        let canvas = Module.pinvokes.get_object_by_id(canvasHandle);
        canvas.height = height;
    });

    EM_JS(int32_t, canvas_get_width_impl, (intptr_t canvasHandle), {
        let canvas = Module.pinvokes.get_object_by_id(canvasHandle);
        return canvas.width;
    });

    EM_JS(int32_t, canvas_get_height_impl, (intptr_t canvasHandle), {
        let canvas = Module.pinvokes.get_object_by_id(canvasHandle);
        return canvas.height;
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
    EM_JS(void, canvas_context_draw_image_impl2, (intptr_t ctxHandle, intptr_t imgHandle, double dx, double dy, double dWidth, double dHeight, double screenX, double screenY, double screenWidth, double screenHeight), {
        let ctx = Module.pinvokes.get_object_by_id(ctxHandle);
        let img = Module.pinvokes.get_object_by_id(imgHandle);
        ctx.drawImage(img, dx, dy, dWidth, dHeight, screenX, screenY, screenWidth, screenHeight);
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

    EM_JS(intptr_t, create_image, (), {
        var img = wx.createImage();
        return Module.pinvokes.get_id_for_object(img);
    });

    EM_JS(void, set_image_src, (intptr_t imgHandle, const uint16_t *src, size_t len), {
        let arr = HEAPU16.subarray(src >> 1, (src >> 1) + len);
        let jsSrc = String.fromCharCode.apply(null, arr);
        let img = Module.pinvokes.get_object_by_id(imgHandle);
        img.src = jsSrc;
    });

    EM_JS(int32_t, get_image_width, (intptr_t imgHandle), {
        let img = Module.pinvokes.get_object_by_id(imgHandle);
        return img.width;
    });

    EM_JS(int32_t, get_image_height, (intptr_t imgHandle), {
        let img = Module.pinvokes.get_object_by_id(imgHandle);
        return img.height;
    });
    EM_JS(intptr_t, audio_create_impl, (), {
        return Module.pinvokes.get_id_for_object(wx.createInnerAudioContext());
    });
    EM_JS(void, audio_set_src_impl, (intptr_t audioHandle, const uint16_t *src, size_t len), {
        let arr = HEAPU16.subarray(src >> 1, (src >> 1) + len);
        let jsSrc = String.fromCharCode.apply(null, arr);
        let audio = Module.pinvokes.get_object_by_id(audioHandle);
        if (audio)
            audio.src = jsSrc;
    });
    EM_JS(void, audio_set_loop_impl, (intptr_t audioHandle, int32_t loop), {
        let audio = Module.pinvokes.get_object_by_id(audioHandle);
        if (audio)
            audio.loop = !!loop;
    });
    EM_JS(int32_t, audio_get_loop_impl, (intptr_t audioHandle), {
        let audio = Module.pinvokes.get_object_by_id(audioHandle);
        return audio && audio.loop ? 1 : 0;
    });
    EM_JS(void, audio_set_autoplay_impl, (intptr_t audioHandle, int32_t autoplay), {
        let audio = Module.pinvokes.get_object_by_id(audioHandle);
        if (audio)
            audio.autoplay = !!autoplay;
    });
    EM_JS(int32_t, audio_get_autoplay_impl, (intptr_t audioHandle), {
        let audio = Module.pinvokes.get_object_by_id(audioHandle);
        return audio && audio.autoplay ? 1 : 0;
    });
    EM_JS(void, audio_set_current_time_impl, (intptr_t audioHandle, float currentTime), {
        let audio = Module.pinvokes.get_object_by_id(audioHandle);
        if (audio)
            audio.currentTime = currentTime;
    });
    EM_JS(float, audio_get_current_time_impl, (intptr_t audioHandle), {
        let audio = Module.pinvokes.get_object_by_id(audioHandle);
        return audio && audio.currentTime ? audio.currentTime : 0.0;
    });
    EM_JS(void, audio_play_impl, (intptr_t audioHandle), {
        let audio = Module.pinvokes.get_object_by_id(audioHandle);
        if (audio && audio.play)
            audio.play();
    });
    EM_JS(void, audio_pause_impl, (intptr_t audioHandle), {
        let audio = Module.pinvokes.get_object_by_id(audioHandle);
        if (audio && audio.pause)
            audio.pause();
    });
    EM_JS(void, audio_stop_impl, (intptr_t audioHandle), {
        let audio = Module.pinvokes.get_object_by_id(audioHandle);
        if (audio && audio.stop)
            audio.stop();
    });
#else
    void console_log_impl(const uint16_t *msg, size_t length) {}
    void console_err_impl(const uint16_t *msg, size_t length) {}

    int32_t screen_info_get_screen_width() { return 0; }
    int32_t screen_info_get_screen_height() { return 0; }

    intptr_t canvas_create_canvas_impl() { return 0; }
    intptr_t canvas_get_context_impl(intptr_t canvasHandle, const uint16_t *, size_t) { return 0; }
    void canvas_set_width_impl(intptr_t, int32_t) {}
    void canvas_set_height_impl(intptr_t, int32_t) {}
    int32_t canvas_get_width_impl(intptr_t) { return 0; }
    int32_t canvas_get_height_impl(intptr_t) { return 0; }

    void canvas_context_clear_rect_impl(intptr_t, double, double, double, double) {}
    void canvas_context_draw_image_impl(intptr_t, intptr_t, double, double, double, double) {}
    void canvas_context_draw_image_impl2(intptr_t, intptr_t, double, double, double, double, double, double, double, double) {}
    void canvas_context_set_font_impl(intptr_t, const uint16_t *, size_t) {}
    void canvas_context_set_fill_style_impl(intptr_t, const uint16_t *, size_t) {}
    void canvas_context_fill_text_impl(intptr_t, const uint16_t *, size_t, double, double) {}

    intptr_t create_image() { return 0; }
    void set_image_src(intptr_t, const uint16_t *, size_t) {}
    int32_t get_image_width(intptr_t) { return 0; }
    int32_t get_image_height(intptr_t) { return 0; }

    intptr_t audio_create_impl() { return 0; }
    void audio_set_src_impl(intptr_t, const uint16_t *, size_t) {}
    void audio_set_loop_impl(intptr_t, int32_t) {}
    int32_t audio_get_loop_impl(intptr_t) { return 0; }
    void audio_set_autoplay_impl(intptr_t, int32_t) {}
    int32_t audio_get_autoplay_impl(intptr_t) { return 0; }
    void audio_set_current_time_impl(intptr_t, float) {}
    float audio_get_current_time_impl(intptr_t) { return 0.0f; }
    void audio_play_impl(intptr_t) {}
    void audio_pause_impl(intptr_t) {}
    void audio_stop_impl(intptr_t) {}
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

    void canvas_set_width(intptr_t canvasHandle, int32_t width)
    {
        canvas_set_width_impl(canvasHandle, width);
    }

    void canvas_set_height(intptr_t canvasHandle, int32_t height)
    {
        canvas_set_height_impl(canvasHandle, height);
    }

    int32_t canvas_get_width(intptr_t canvasHandle)
    {
        return canvas_get_width_impl(canvasHandle);
    }

    int32_t canvas_get_height(intptr_t canvasHandle)
    {
        return canvas_get_height_impl(canvasHandle);
    }

    void canvas_context_clear_rect(intptr_t ctxHandle, double x, double y, double w, double h)
    {
        canvas_context_clear_rect_impl(ctxHandle, x, y, w, h);
    }
    void canvas_context_draw_image(intptr_t ctxHandle, intptr_t imgHandle, double dx, double dy, double dWidth, double dHeight)
    {
        canvas_context_draw_image_impl(ctxHandle, imgHandle, dx, dy, dWidth, dHeight);
    }
    void canvas_context_draw_image2(intptr_t ctxHandle, intptr_t imgHandle, double dx, double dy, double dWidth, double dHeight, double screenX, double screenY, double screenWidth, double screenHeight)
    {
        canvas_context_draw_image_impl2(ctxHandle, imgHandle, dx, dy, dWidth, dHeight, screenX, screenY, screenWidth, screenHeight);
    }
    void canvas_context_set_font(intptr_t ctxHandle, const uint16_t *font, size_t len)
    {
        canvas_context_set_font_impl(ctxHandle, font, len);
    }
    void canvas_context_set_fill_style(intptr_t ctxHandle, const uint16_t *fillStyle, size_t len)
    {
        canvas_context_set_fill_style_impl(ctxHandle, fillStyle, len);
    }
    void canvas_context_fill_text(intptr_t ctxHandle, const uint16_t *text, size_t len, double x, double y)
    {
        canvas_context_fill_text_impl(ctxHandle, text, len, x, y);
    }

    intptr_t create_image_internal()
    {
        return create_image();
    }

    void set_image_src_internal(intptr_t imgHandle, vm::RtString *src)
    {
        const Utf16Char *chars = vm::String::get_chars_ptr(src);
        size_t len = vm::String::get_length(src);
        set_image_src(imgHandle, chars, len);
    }

    int32_t get_image_width_internal(intptr_t imgHandle)
    {
        return get_image_width(imgHandle);
    }

    int32_t get_image_height_internal(intptr_t imgHandle)
    {
        return get_image_height(imgHandle);
    }

    intptr_t audio_create() { return audio_create_impl(); }
    void audio_set_src(intptr_t audioHandle, const uint16_t *src, size_t len) { audio_set_src_impl(audioHandle, src, len); }
    void audio_set_loop(intptr_t audioHandle, int32_t loop) { audio_set_loop_impl(audioHandle, loop); }
    int32_t audio_get_loop(intptr_t audioHandle) { return audio_get_loop_impl(audioHandle); }
    void audio_set_autoplay(intptr_t audioHandle, int32_t autoplay) { audio_set_autoplay_impl(audioHandle, autoplay); }
    int32_t audio_get_autoplay(intptr_t audioHandle) { return audio_get_autoplay_impl(audioHandle); }
    void audio_set_current_time(intptr_t audioHandle, float currentTime) { audio_set_current_time_impl(audioHandle, currentTime); }
    float audio_get_current_time(intptr_t audioHandle) { return audio_get_current_time_impl(audioHandle); }
    void audio_play(intptr_t audioHandle) { audio_play_impl(audioHandle); }
    void audio_pause(intptr_t audioHandle) { audio_pause_impl(audioHandle); }
    void audio_stop(intptr_t audioHandle) { audio_stop_impl(audioHandle); }

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

    RtResultVoid canvas_set_width_invoker(metadata::RtManagedMethodPointer, const metadata::RtMethodInfo *, const interp::RtStackObject *params, interp::RtStackObject *ret)
    {
        size_t offset = 0;
        intptr_t canvasHandle = RuntimeApi::get_argument<intptr_t>(params, offset);
        int32_t width = RuntimeApi::get_argument<int32_t>(params, offset);
        canvas_set_width(canvasHandle, width);
        RET_VOID_OK();
    }

    RtResultVoid canvas_set_height_invoker(metadata::RtManagedMethodPointer, const metadata::RtMethodInfo *, const interp::RtStackObject *params, interp::RtStackObject *ret)
    {
        size_t offset = 0;
        intptr_t canvasHandle = RuntimeApi::get_argument<intptr_t>(params, offset);
        int32_t height = RuntimeApi::get_argument<int32_t>(params, offset);
        canvas_set_height(canvasHandle, height);
        RET_VOID_OK();
    }

    RtResultVoid canvas_get_width_invoker(metadata::RtManagedMethodPointer, const metadata::RtMethodInfo *, const interp::RtStackObject *params, interp::RtStackObject *ret)
    {
        size_t offset = 0;
        intptr_t canvasHandle = RuntimeApi::get_argument<intptr_t>(params, offset);
        int32_t width = canvas_get_width(canvasHandle);
        RuntimeApi::set_return_value<int32_t>(ret, width);
        RET_VOID_OK();
    }

    RtResultVoid canvas_get_height_invoker(metadata::RtManagedMethodPointer, const metadata::RtMethodInfo *, const interp::RtStackObject *params, interp::RtStackObject *ret)
    {
        size_t offset = 0;
        intptr_t canvasHandle = RuntimeApi::get_argument<intptr_t>(params, offset);
        int32_t height = canvas_get_height(canvasHandle);
        RuntimeApi::set_return_value<int32_t>(ret, height);
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

    RtResultVoid canvas_context_draw_image2_invoker(metadata::RtManagedMethodPointer, const metadata::RtMethodInfo *, const interp::RtStackObject *params, interp::RtStackObject *ret)
    {
        size_t offset = 0;
        intptr_t ctx = RuntimeApi::get_argument<intptr_t>(params, offset);
        intptr_t img = RuntimeApi::get_argument<intptr_t>(params, offset);
        double dx = RuntimeApi::get_argument<double>(params, offset);
        double dy = RuntimeApi::get_argument<double>(params, offset);
        double dw = RuntimeApi::get_argument<double>(params, offset);
        double dh = RuntimeApi::get_argument<double>(params, offset);
        double sx = RuntimeApi::get_argument<double>(params, offset);
        double sy = RuntimeApi::get_argument<double>(params, offset);
        double sw = RuntimeApi::get_argument<double>(params, offset);
        double sh = RuntimeApi::get_argument<double>(params, offset);
        canvas_context_draw_image2(ctx, img, dx, dy, dw, dh, sx, sy, sw, sh);
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

    RtResultVoid create_image_internal_invoker(metadata::RtManagedMethodPointer, const metadata::RtMethodInfo *, const interp::RtStackObject *params, interp::RtStackObject *ret)
    {
        intptr_t imgHandle = create_image_internal();
        RuntimeApi::set_return_value<intptr_t>(ret, imgHandle);
        RET_VOID_OK();
    }

    RtResultVoid set_image_src_internal_invoker(metadata::RtManagedMethodPointer, const metadata::RtMethodInfo *, const interp::RtStackObject *params, interp::RtStackObject *ret)
    {
        size_t offset = 0;
        intptr_t imgHandle = RuntimeApi::get_argument<intptr_t>(params, offset);
        auto str = RuntimeApi::get_argument<vm::RtString *>(params, offset);
        set_image_src_internal(imgHandle, str);
        RET_VOID_OK();
    }

    RtResultVoid get_image_width_internal_invoker(metadata::RtManagedMethodPointer, const metadata::RtMethodInfo *, const interp::RtStackObject *params, interp::RtStackObject *ret)
    {
        size_t offset = 0;
        intptr_t imgHandle = RuntimeApi::get_argument<intptr_t>(params, offset);
        int32_t width = get_image_width_internal(imgHandle);
        RuntimeApi::set_return_value<int32_t>(ret, width);
        RET_VOID_OK();
    }

    RtResultVoid get_image_height_internal_invoker(metadata::RtManagedMethodPointer, const metadata::RtMethodInfo *, const interp::RtStackObject *params, interp::RtStackObject *ret)
    {
        size_t offset = 0;
        intptr_t imgHandle = RuntimeApi::get_argument<intptr_t>(params, offset);
        int32_t height = get_image_height_internal(imgHandle);
        RuntimeApi::set_return_value<int32_t>(ret, height);
        RET_VOID_OK();
    }

    RtResultVoid audio_create_invoker(metadata::RtManagedMethodPointer, const metadata::RtMethodInfo *, const interp::RtStackObject *params, interp::RtStackObject *ret)
    {
        intptr_t handle = audio_create();
        RuntimeApi::set_return_value<intptr_t>(ret, handle);
        RET_VOID_OK();
    }
    RtResultVoid audio_set_src_invoker(metadata::RtManagedMethodPointer, const metadata::RtMethodInfo *, const interp::RtStackObject *params, interp::RtStackObject *ret)
    {
        size_t offset = 0;
        intptr_t handle = RuntimeApi::get_argument<intptr_t>(params, offset);
        auto str = RuntimeApi::get_argument<vm::RtString *>(params, offset);
        if (str)
            audio_set_src(handle, vm::String::get_chars_ptr(str), vm::String::get_length(str));
        RET_VOID_OK();
    }
    RtResultVoid audio_set_loop_invoker(metadata::RtManagedMethodPointer, const metadata::RtMethodInfo *, const interp::RtStackObject *params, interp::RtStackObject *ret)
    {
        size_t offset = 0;
        intptr_t handle = RuntimeApi::get_argument<intptr_t>(params, offset);
        int32_t loop = RuntimeApi::get_argument<int32_t>(params, offset);
        audio_set_loop(handle, loop);
        RET_VOID_OK();
    }
    RtResultVoid audio_get_loop_invoker(metadata::RtManagedMethodPointer, const metadata::RtMethodInfo *, const interp::RtStackObject *params, interp::RtStackObject *ret)
    {
        size_t offset = 0;
        intptr_t handle = RuntimeApi::get_argument<intptr_t>(params, offset);
        int32_t result = audio_get_loop(handle);
        RuntimeApi::set_return_value<int32_t>(ret, result);
        RET_VOID_OK();
    }
    RtResultVoid audio_set_autoplay_invoker(metadata::RtManagedMethodPointer, const metadata::RtMethodInfo *, const interp::RtStackObject *params, interp::RtStackObject *ret)
    {
        size_t offset = 0;
        intptr_t handle = RuntimeApi::get_argument<intptr_t>(params, offset);
        int32_t autoplay = RuntimeApi::get_argument<int32_t>(params, offset);
        audio_set_autoplay(handle, autoplay);
        RET_VOID_OK();
    }
    RtResultVoid audio_get_autoplay_invoker(metadata::RtManagedMethodPointer, const metadata::RtMethodInfo *, const interp::RtStackObject *params, interp::RtStackObject *ret)
    {
        size_t offset = 0;
        intptr_t handle = RuntimeApi::get_argument<intptr_t>(params, offset);
        int32_t result = audio_get_autoplay(handle);
        RuntimeApi::set_return_value<int32_t>(ret, result);
        RET_VOID_OK();
    }
    RtResultVoid audio_set_current_time_invoker(metadata::RtManagedMethodPointer, const metadata::RtMethodInfo *, const interp::RtStackObject *params, interp::RtStackObject *ret)
    {
        size_t offset = 0;
        intptr_t handle = RuntimeApi::get_argument<intptr_t>(params, offset);
        float currentTime = RuntimeApi::get_argument<float>(params, offset);
        audio_set_current_time(handle, currentTime);
        RET_VOID_OK();
    }
    RtResultVoid audio_get_current_time_invoker(metadata::RtManagedMethodPointer, const metadata::RtMethodInfo *, const interp::RtStackObject *params, interp::RtStackObject *ret)
    {
        size_t offset = 0;
        intptr_t handle = RuntimeApi::get_argument<intptr_t>(params, offset);
        float result = audio_get_current_time(handle);
        RuntimeApi::set_return_value<float>(ret, result);
        RET_VOID_OK();
    }
    RtResultVoid audio_play_invoker(metadata::RtManagedMethodPointer, const metadata::RtMethodInfo *, const interp::RtStackObject *params, interp::RtStackObject *ret)
    {
        size_t offset = 0;
        intptr_t handle = RuntimeApi::get_argument<intptr_t>(params, offset);
        audio_play(handle);
        RET_VOID_OK();
    }
    RtResultVoid audio_pause_invoker(metadata::RtManagedMethodPointer, const metadata::RtMethodInfo *, const interp::RtStackObject *params, interp::RtStackObject *ret)
    {
        size_t offset = 0;
        intptr_t handle = RuntimeApi::get_argument<intptr_t>(params, offset);
        audio_pause(handle);
        RET_VOID_OK();
    }
    RtResultVoid audio_stop_invoker(metadata::RtManagedMethodPointer, const metadata::RtMethodInfo *, const interp::RtStackObject *params, interp::RtStackObject *ret)
    {
        size_t offset = 0;
        intptr_t handle = RuntimeApi::get_argument<intptr_t>(params, offset);
        audio_stop(handle);
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
        {"[WxSdk]Wx.Canvas::SetWidthInternal", (vm::PInvokeFunction)(&canvas_set_width), canvas_set_width_invoker},
        {"[WxSdk]Wx.Canvas::SetHeightInternal", (vm::PInvokeFunction)(&canvas_set_height), canvas_set_height_invoker},
        {"[WxSdk]Wx.Canvas::GetWidthInternal", (vm::PInvokeFunction)(&canvas_get_width), canvas_get_width_invoker},
        {"[WxSdk]Wx.Canvas::GetHeightInternal", (vm::PInvokeFunction)(&canvas_get_height), canvas_get_height_invoker},

        {"[WxSdk]Wx.CanvasContext::ClearRectInternal", (vm::PInvokeFunction)(&canvas_context_clear_rect), canvas_context_clear_rect_invoker},
        {"[WxSdk]Wx.CanvasContext::DrawImageInternal", (vm::PInvokeFunction)(&canvas_context_draw_image), canvas_context_draw_image_invoker},
        {"[WxSdk]Wx.CanvasContext::DrawImageInternal2", (vm::PInvokeFunction)(&canvas_context_draw_image2), canvas_context_draw_image2_invoker},
        {"[WxSdk]Wx.CanvasContext::SetFontInternal", (vm::PInvokeFunction)(&canvas_context_set_font), canvas_context_set_font_invoker},
        {"[WxSdk]Wx.CanvasContext::SetFillStyleInternal", (vm::PInvokeFunction)(&canvas_context_set_fill_style), canvas_context_set_fill_style_invoker},
        {"[WxSdk]Wx.CanvasContext::FillTextInternal", (vm::PInvokeFunction)(&canvas_context_fill_text), canvas_context_fill_text_invoker},

        {"[WxSdk]Wx.Image::CreateImageInternal", (vm::PInvokeFunction)(&create_image_internal), create_image_internal_invoker},
        {"[WxSdk]Wx.Image::SetImageSrcInternal", (vm::PInvokeFunction)(&set_image_src_internal), set_image_src_internal_invoker},
        {"[WxSdk]Wx.Image::GetImageWidthInternal", (vm::PInvokeFunction)(&get_image_width_internal), get_image_width_internal_invoker},
        {"[WxSdk]Wx.Image::GetImageHeightInternal", (vm::PInvokeFunction)(&get_image_height_internal), get_image_height_internal_invoker},
        // AudioContext P/Invoke
        {"[WxSdk]Wx.AudioContext::CreateAudioInternal", (vm::PInvokeFunction)(&audio_create), audio_create_invoker},
        {"[WxSdk]Wx.AudioContext::SetSrcInternal", (vm::PInvokeFunction)(&audio_set_src), audio_set_src_invoker},
        {"[WxSdk]Wx.AudioContext::SetLoopInternal", (vm::PInvokeFunction)(&audio_set_loop), audio_set_loop_invoker},
        {"[WxSdk]Wx.AudioContext::GetLoopInternal", (vm::PInvokeFunction)(&audio_get_loop), audio_get_loop_invoker},
        {"[WxSdk]Wx.AudioContext::SetAutoPlayInternal", (vm::PInvokeFunction)(&audio_set_autoplay), audio_set_autoplay_invoker},
        {"[WxSdk]Wx.AudioContext::GetAutoPlayInternal", (vm::PInvokeFunction)(&audio_get_autoplay), audio_get_autoplay_invoker},
        {"[WxSdk]Wx.AudioContext::SetCurrentTimeInternal", (vm::PInvokeFunction)(&audio_set_current_time), audio_set_current_time_invoker},
        {"[WxSdk]Wx.AudioContext::GetCurrentTimeInternal", (vm::PInvokeFunction)(&audio_get_current_time), audio_get_current_time_invoker},
        {"[WxSdk]Wx.AudioContext::PlayInternal", (vm::PInvokeFunction)(&audio_play), audio_play_invoker},
        {"[WxSdk]Wx.AudioContext::PauseInternal", (vm::PInvokeFunction)(&audio_pause), audio_pause_invoker},
        {"[WxSdk]Wx.AudioContext::StopInternal", (vm::PInvokeFunction)(&audio_stop), audio_stop_invoker},
    };

    void initialize_wx_pinvokes()
    {
        for (const auto &reg : g_pinvoke_registrations)
        {
            RuntimeApi::register_pinvoke_func(reg.name, reg.func, reg.invoker);
        }
    }
}