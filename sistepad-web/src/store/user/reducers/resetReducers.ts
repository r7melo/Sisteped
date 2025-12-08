import type { ActionReducerMapBuilder } from "@reduxjs/toolkit";
import type { UserState } from "../state";
import { resetUserStateAction } from "../actions/reset";

export const resetReducers = (builder : ActionReducerMapBuilder<UserState>) =>{
    builder
    .addCase(resetUserStateAction.pending, (state) => {
        state.error = null;
        state.successLogin = undefined;
        state.successRegister = undefined;
        state.loading = false;
        state.user = null;
    });
}