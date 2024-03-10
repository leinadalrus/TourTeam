<script setup lang="ts">
// to-fix: code ...

import { defineStore } from "pinia"

const useShipCommandStore = defineStore("ships", {
  state: () => ({
    ships: [],
    filter: "all",
    uuid: 0
  }),

  getters: {
    finishedShips(state) {
      return state.ships
    },

    unfinishedShips(state) {
      return !state.ships
    }
  },

  actions: {
    createShip() {
      this.ships.push()
    },

    destroyShip() {
      this.ships.pop()
    }
  }
})
</script>

<template>
  <article>
    <form action="" method="post">
      {{ useShipCommandStore }}
    </form>
  </article>
</template>

<style scoped module="styles" lang="scss"></style>
